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
            double speed = Settings.Default.Speed;
            Item_RadioCheck(speeds, speed, MenuSpeed);
            Player.SpeedRatio = speed;
            LoopCount = 0;
            LoopMax = Settings.Default.Loop;
            Item_RadioCheck(loops, LoopMax, MenuLoop);
            MenuLoop.Checked = LoopMax != 0;
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
            foreach (KeyValuePair<string, HotKey> hkp in hotkeys) {
                hkp.Value.Dispose();
            }
            hotkeys.Clear();
        }
        public Form1()
        {
            InitializeComponent();
            foreach (ToolStripMenuItem _item in MenuVolume.DropDownItems)
            {
                volumes.Add(Convert.ToDouble(_item.Tag), _item);
            }
            foreach (ToolStripMenuItem _item in MenuSpeed.DropDownItems)
            {
                speeds.Add(Convert.ToDouble(_item.Tag), _item);
            }
            foreach (ToolStripMenuItem _item in MenuLoop.DropDownItems)
            {
                loops.Add(Convert.ToInt32(_item.Tag), _item);
            }
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
            foreach (ToolStripMenuItem _item in parentItem.DropDownItems)
            {
                _item.Checked = false;
            }
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
        private void Time_Parent_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Set_Time(0);
            }
        }
        private void Save_Loop()
        {
            Item_RadioCheck(loops, LoopMax, MenuLoop);
            LoopCount = 0;
            Settings.Default.Loop = LoopMax;
            Settings.Default.Save();
            MenuLoop.Checked = LoopMax != 0;
        }
        private void Loop_Click(object sender, EventArgs e)
        {
            LoopMax = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
            Save_Loop();
        }
        private void Loop_Parent_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                LoopMax = LoopMax == 0 ? -1 : 0;
                Save_Loop();
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
    }
}
