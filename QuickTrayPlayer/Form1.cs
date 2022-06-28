using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTrayPlayer
{
    using Properties;
    using MinPlayer;
    using GHotKey;
    using System.Threading;

    public partial class Form1 : Form
    {
        static private Assembly asm = Assembly.GetExecutingAssembly();
        private Icon playIcon = IconList.icon_QuickTrayPlayer;
        private Icon pauseIcon = IconList.icon_QuickTrayPlayer_pause;
        public MinPlayer Player { get; private set; } = new MinPlayer();
        private readonly Dictionary<double, ToolStripMenuItem> volumes = new Dictionary<double, ToolStripMenuItem>();
        private readonly Dictionary<double, ToolStripMenuItem> speeds = new Dictionary<double, ToolStripMenuItem>();
        private readonly Dictionary<double, ToolStripMenuItem> panpots = new Dictionary<double, ToolStripMenuItem>();
        private readonly Dictionary<int, ToolStripMenuItem> loops = new Dictionary<int, ToolStripMenuItem>();
        public int LoopCount { get; private set; } = 0;
        public int LoopMax { get; private set; } = 0;
        private bool loaded = false;
        private readonly Dictionary<string, HotKey> hotkeys = new Dictionary<string, HotKey>();
        public void ReadSetting()
        {
            double volume = Settings.Default.Volume;
            Item_RadioCheck(volumes, volume, MenuVolume);
            Player.Volume = volume;
            MenuList_VolumeText.Text = (volume * 100).ToString();
            MenuList_VolumeText.BackColor = Color.White;
            double speed = Settings.Default.Speed;
            Item_RadioCheck(speeds, speed, MenuSpeed);
            Player.SpeedRatio = speed;
            MenuList_SpeedText.Text = speed.ToString();
            MenuList_SpeedText.BackColor = Color.White;
            double panpot = Settings.Default.PanPot;
            Item_RadioCheck(panpots, panpot, MenuPanPot);
            Player.Balance = panpot;
            MenuList_PanPotText.Text = (panpot * 100).ToString();
            MenuList_PanPotText.BackColor = Color.White;
            LoopCount = 0;
            LoopMax = Settings.Default.Loop;
            Item_RadioCheck(loops, LoopMax, MenuLoop);
            MenuLoop.Checked = LoopMax != 0;
            MenuList_LoopText.Text = LoopMax.ToString();
            MenuList_LoopText.BackColor = Color.White;
            MenuAutoExit.Checked = Settings.Default.AutoExit;
            MenuDuplication.Checked = Settings.Default.Duplication;
            MenuHotKey.Checked = Settings.Default.HotKey;
            if (MenuHotKey.Checked) { EnableHotKey(); } else { DisableHotkey(); }
        }
        public void EnableHotKey(string keyStr, MOD_KEY mod, Keys key, Action action)
        {
            if (!hotkeys.ContainsKey(keyStr))
            {
                HotKey hotKey = new HotKey(mod, key);
                hotkeys.Add(keyStr, hotKey);
                hotKey.HotKeyPush += new EventHandler(
                    (object sender, EventArgs e) => { action(); }
                );
            }
        }
        public void EnableHotKey()
        {
            EnableHotKey("MediaPlayPause",
                MOD_KEY.NONE, Keys.MediaPlayPause, () => { PlayPause(); }
            );
            EnableHotKey("MediaPreviousTrack",
                MOD_KEY.NONE, Keys.MediaPlayPause, () => { Replay(); }
            );
            EnableHotKey("MediaNextTrack",
                MOD_KEY.NONE, Keys.MediaNextTrack, () => { Stop(); EndSwitch(); }
            );
        }
        public void DisableHotkey()
        {
            foreach (KeyValuePair<string, HotKey> hkp in hotkeys)
            {
                hkp.Value.Dispose();
            }
            hotkeys.Clear();
        }
        static public void FilterToolStripItem(ToolStripItemCollection items, Action<ToolStripMenuItem> action)
        {
            foreach (object _item in items)
            {
                if (_item.GetType().Name == "ToolStripMenuItem")
                {
                    var _item_tsmi = (ToolStripMenuItem)_item;
                    action(_item_tsmi);
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
            FilterToolStripItem(MenuVolume.DropDownItems, (_item) =>
            {
                volumes.Add(Convert.ToDouble(_item.Tag), _item);
            });
            FilterToolStripItem(MenuSpeed.DropDownItems, (_item) =>
            {
                speeds.Add(Convert.ToDouble(_item.Tag), _item);
            });
            FilterToolStripItem(MenuLoop.DropDownItems, (_item) =>
            {
                loops.Add(Convert.ToInt32(_item.Tag), _item);
            });
            FilterToolStripItem(MenuPanPot.DropDownItems, (_item) =>
            {
                panpots.Add(Convert.ToDouble(_item.Tag), _item);
            });
            ReadSetting();
        }
        ~Form1()
        {
            DisableHotkey();
        }
        public void SetPlayer(string str)
        {
            Player.Open(str);
            string text = Path.GetFileName(str);
            if (text.Length > 63) text = text.Substring(0, 63);
            notifyIcon1.Text = text;
        }
        public void OpenFileDialog()
        {
            openFileDialog1.Filter = Resources.FileExtsFilter;
            openFileDialog1.ShowDialog();
        }
        void SyncIcon()
        {
            if (Player.NowPlay) { notifyIcon1.Icon = pauseIcon; }
            else { notifyIcon1.Icon = playIcon; }
        }
        public void Play()
        {
            Player.Play();
            SyncIcon();
        }
        public void Replay()
        {
            LoopCount = 0;
            Player.Position = TimeSpan.Zero;
            Play();
        }
        public void OpenPlayInvoke(string str)
        {
            Invoke((Action)(() => { OpenPlay(str); }));
        }
        public void OpenPlay(string str)
        {
            ReadSetting();
            SetPlayer(str);
            Replay();
        }
        public void Pause()
        {
            Player.Pause();
            SyncIcon();
        }
        public void Stop()
        {
            LoopCount = 0;
            Player.Stop();
            SyncIcon();
        }
        public void PlayPause()
        {
            Player.PlayPause();
            SyncIcon();
        }
        private void CloseEnd()
        {
            Player.Close();
            Thread.Sleep(500);
            Close();
        }
        private void EndSwitch()
        {
            bool looped = false;
            if (LoopMax != 0)
            {
                if (LoopMax < 0)
                {
                    looped = true;
                }
                else if (LoopCount < LoopMax)
                {
                    LoopCount++;
                    looped = true;
                }
            }
            if (looped)
            {
                Player.Position = TimeSpan.Zero;
            }
            else
            {
                if (MenuAutoExit.Checked)
                {
                    CloseEnd();
                }
                else
                {
                    Stop();
                }
            }
        }
        private void EventEnd(object sender, EventArgs e)
        {
            EndSwitch();
        }
        public void SetArgs(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                SetPlayer(args[0]);
            }
            else
            {
                OpenFileDialog();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            loaded = true;
            if (Player.Source == null)
            {
                if (!MenuAutoExit.Checked) SyncIcon();
                EndSwitch();
            }
            else
            {
                Player.MediaEnded += new EventHandler(EventEnd);
                Play();
            }
        }
        private void TaskMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PlayPause();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            CloseEnd();
        }
        private void Item_RadioCheck(ToolStripMenuItem item, ToolStripMenuItem parentItem)
        {
            FilterToolStripItem(parentItem.DropDownItems, (_item) =>
            {
                _item.Checked = false;
            });
            if (item != null) item.Checked = true;
        }
        private void Item_RadioCheck<T>(Dictionary<T, ToolStripMenuItem> dic, T key, ToolStripMenuItem parentItem)
        {
            Item_RadioCheck(dic.ContainsKey(key) ? dic[key] : null, parentItem);
        }
        private void Save_Volume(double volume)
        {
            Item_RadioCheck(volumes, volume, MenuVolume);
            Settings.Default.Volume = volume;
            Settings.Default.Save();
            Player.Volume = volume;
            MenuList_VolumeText.Text = (volume * 100).ToString();
            MenuList_VolumeText.BackColor = Color.White;
        }
        private void Volume_Click(object sender, EventArgs e)
        {
            Save_Volume(Convert.ToDouble(((ToolStripMenuItem)sender).Tag));
        }
        private void Volume_Parent_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Save_Volume(Player.Volume != 0.5 ? 0.5 : 1);
            }
        }
        private void Save_Speed(double speed)
        {
            Item_RadioCheck(speeds, speed, MenuSpeed);
            Settings.Default.Speed = speed;
            Settings.Default.Save();
            Player.SpeedRatio = speed;
            MenuList_SpeedText.Text = speed.ToString();
            MenuList_SpeedText.BackColor = Color.White;
        }
        private void Speed_Click(object sender, EventArgs e)
        {
            Save_Speed(Convert.ToDouble(((ToolStripMenuItem)sender).Tag));
        }
        private void Speed_Parent_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Save_Speed(Player.SpeedRatio != 1 ? 1 : 2);
            }
        }
        private void Set_Time(double per)
        {
            Player.SetPositionFromRadio(per);
            Play();
        }
        private void Time_Click(object sender, EventArgs e)
        {
            Set_Time(Convert.ToDouble(((ToolStripMenuItem)sender).Tag));
        }
        private void MenuTime_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Set_Time(0);
            }
        }

        private void Save_PanPot(double panpot)
        {
            Item_RadioCheck(panpots, panpot, MenuPanPot);
            Settings.Default.PanPot = panpot;
            Settings.Default.Save();
            Player.Balance = panpot;
            MenuList_PanPotText.Text = (panpot * 100).ToString();
            MenuList_PanPotText.BackColor = Color.White;
        }
        private void PanPot_Click(object sender, EventArgs e)
        {
            Save_PanPot(Convert.ToDouble(((ToolStripMenuItem)sender).Tag));
        }
        private void PanPot_Parent_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Save_PanPot(Player.Balance == 0 ? -1 : 
                    (Player.Balance == -1 ? 1 : 0));
            }
        }

        private void Save_Loop()
        {
            Item_RadioCheck(loops, LoopMax, MenuLoop);
            LoopCount = 0;
            Settings.Default.Loop = LoopMax;
            Settings.Default.Save();
            MenuLoop.Checked = LoopMax != 0;
            MenuList_LoopText.Text = LoopMax.ToString();
            MenuList_LoopText.BackColor = Color.White;
        }
        private void Save_Loop(int value)
        {
            LoopMax = value;
            Save_Loop();
        }
        private void Loop_Click(object sender, EventArgs e)
        {
            Save_Loop(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
        }
        private void Loop_Parent_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Save_Loop(LoopMax == 0 ? -1 : 0);
            }
        }
        private void AutoExit_Click(object sender, EventArgs e)
        {
            MenuAutoExit.Checked = !MenuAutoExit.Checked;
            Settings.Default.AutoExit = MenuAutoExit.Checked;
            Settings.Default.Save();
        }
        private void Duplication_Click(object sender, EventArgs e)
        {
            MenuDuplication.Checked = !MenuDuplication.Checked;
            Settings.Default.Duplication = MenuDuplication.Checked;
            Settings.Default.Save();
        }
        private void HotKey_Click(object sender, EventArgs e)
        {
            MenuHotKey.Checked = !MenuHotKey.Checked;
            Settings.Default.HotKey = MenuHotKey.Checked;
            Settings.Default.Save();
            if (MenuHotKey.Checked) { EnableHotKey(); } else { DisableHotkey(); }
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SetPlayer(openFileDialog1.FileName);
            if (loaded)
            {
                Replay();
            }
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }

        private bool RangeLimit(ToolStripTextBox item, int min, int max)
        {
            if (Int32.TryParse(item.Text, out int v))
            {
                int vc = v;
                if (v > max) { vc = max; }
                else if (v < min) { vc = min; item.Text = min.ToString(); }
                if (v != vc) item.Text = vc.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool RangeLimit(ToolStripTextBox item, double min, double max)
        {
            if (Double.TryParse(item.Text, out double v))
            {
                double vc = v;
                if (v > max) { vc = max; }
                else if (v < min) { vc = min; item.Text = min.ToString(); }
                if (v != vc) item.Text = vc.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MenuListTextInc(ToolStripTextBox item, double step = 1)
        {
            Double.TryParse(item.Text, out double v);
            item.Text = (v + step).ToString();
        }

        private void MenuText_KeyDown(ToolStripTextBox _MenuText, Keys key, double inc)
        {
            switch (key)
            {
                case Keys.Up:
                    MenuListTextInc(_MenuText, inc);
                    _MenuText.BackColor = Color.White;
                    break;
                case Keys.Down:
                    MenuListTextInc(_MenuText, -inc);
                    _MenuText.BackColor = Color.White;
                    break;
            }
        }
        private void MenuList_SpeedText_KeyDown(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            MenuText_KeyDown(_MenuText, e.KeyData, 0.05);
            if (Double.TryParse(_MenuText.Text, out double v))
            {
                if (e.KeyCode == Keys.Enter) Save_Speed(v);
            }
        }

        private void MenuList_SpeedText_KeyUp(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    if (Double.TryParse(_MenuText.Text, out double v))
                    {
                        Save_Speed(v);
                    }
                    break;
            }
        }

        private void MenuList_PanPotText_KeyDown(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            MenuText_KeyDown(_MenuText, e.KeyData, 1);
            if (Double.TryParse(_MenuText.Text, out double v))
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                    case Keys.Down:
                        Player.Balance = v / 100;
                        break;
                    case Keys.Enter:
                        Save_PanPot(v / 100);
                        break;
                }
            }
        }

        private void MenuList_PanPotText_KeyUp(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    if (Double.TryParse(_MenuText.Text, out double v))
                    {
                        Save_PanPot(v / 100);
                        _MenuText.BackColor = Color.White;
                    }
                    break;
            }
        }

        private void MenuList_VolumeText_KeyDown(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            MenuText_KeyDown(_MenuText, e.KeyData, 1);
            if (Double.TryParse(_MenuText.Text, out double v))
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                    case Keys.Down:
                        Player.Volume = v / 100;
                        break;
                    case Keys.Enter:
                        Save_Volume(v / 100);
                        break;
                }
            }
        }

        private void MenuList_VolumeText_KeyUp(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    if (Double.TryParse(_MenuText.Text, out double v))
                    {
                        Save_Volume(v / 100);
                    }
                    break;
            }
        }

        private void MenuList_LoopText_KeyDown(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            MenuText_KeyDown(_MenuText, e.KeyData, 1);
            if (Int32.TryParse(_MenuText.Text, out int v))
            {
                if (e.KeyCode == Keys.Enter) Save_Loop(v);
            }
        }

        private void MenuList_LoopText_KeyUp(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    if (Int32.TryParse(_MenuText.Text, out int v))
                    {
                        Save_Loop(v);
                    }
                    break;
            }
        }

        private void MenuList_TimeText_KeyDown(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            MenuText_KeyDown(_MenuText, e.KeyData, 1);
            if (e.KeyData == Keys.Enter)
            {
                if (Double.TryParse(_MenuText.Text, out double v))
                {
                    Set_Time(v / 100);
                }
            }
        }

        private void MenuList_TimeText_KeyUp(object sender, KeyEventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    if (Double.TryParse(_MenuText.Text, out double v))
                    {
                        Set_Time(v / 100);
                        _MenuText.BackColor = Color.White;
                    }
                    break;
            }
        }
        private void FilterNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            byte chr = (byte)e.KeyChar;
            if (chr == 8 || (chr >= 45 && chr <= 46) || (chr >= 48 && chr <= 57))
            {
                ((ToolStripTextBox)sender).BackColor = Color.Honeydew;
            } else if (chr == 13)
            {
                ((ToolStripTextBox)sender).BackColor = Color.White;
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void MenuList_SpeedText_TextChanged(object sender, EventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            RangeLimit(_MenuText, 0.05, 256);
        }

        private void MenuList_PanPotText_TextChanged(object sender, EventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            RangeLimit(_MenuText, (double)-100, 100);
        }

        private void MenuList_VolumeText_TextChanged(object sender, EventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            RangeLimit(_MenuText, (double)0, 100);
        }

        private void MenuList_LoopText_TextChanged(object sender, EventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            RangeLimit(_MenuText, -1, 100);
        }

        private void MenuList_TimeText_TextChanged(object sender, EventArgs e)
        {
            var _MenuText = (ToolStripTextBox)sender;
            RangeLimit(_MenuText, (double)0, 100);
        }
    }
}
