namespace QuickTrayPlayer
{
    using System.Reflection;
    using MinPlayer;
    using GHotKey;
    public partial class Form1 : Form
    {
        static private Assembly asm = Assembly.GetExecutingAssembly();
        private static Icon? loadIcon(string iconFile)
        {
            Stream? stream = asm.GetManifestResourceStream(iconFile);
            if (stream != null)
            {
                StreamReader reader = new StreamReader(stream);
                return new Icon(reader.BaseStream);
            }
            else
            {
                return null;
            }
        }
        private Icon? playIcon = loadIcon("QuickTrayPlayer.icon_QuickTrayPlayer.ico");
        private Icon? pauseIcon = loadIcon("QuickTrayPlayer.icon_QuickTrayPlayer_pause.ico");
        private MinPlayer player = new MinPlayer();
        private readonly Dictionary<double, ToolStripMenuItem> volumes = new();
        private readonly Dictionary<double, ToolStripMenuItem> speeds = new();
        private readonly Dictionary<int, ToolStripMenuItem> loops = new();
        public int LoopCount { get; private set; } = 0;
        public int LoopMax { get; private set; } = 0;
        private bool loaded = false;
        private readonly HotKey playkey = new HotKey(MOD_KEY.NONE, Keys.MediaPlayPause);
        private readonly HotKey prevkey = new HotKey(MOD_KEY.NONE, Keys.MediaPreviousTrack);
        private readonly HotKey nextkey = new HotKey(MOD_KEY.NONE, Keys.MediaNextTrack);
        public void ReadSetting()
        {
            double volume = Settings1.Default.Volume;
            Item_RadioCheck(volumes, volume, MenuVolume);
            player.Volume = volume;
            double speed = Settings1.Default.Speed;
            Item_RadioCheck(speeds, speed, MenuSpeed);
            player.SpeedRatio = speed;
            LoopCount = 0;
            LoopMax = Settings1.Default.Loop;
            Item_RadioCheck(loops, LoopMax, MenuLoop);
            MenuLoop.Checked = LoopMax != 0;
            MenuAutoExit.Checked = Settings1.Default.AutoExit;
            MenuDuplication.Checked = Settings1.Default.Duplication;
            MenuHotKey.Checked = Settings1.Default.HotKey;
        }
        public Form1()
        {
            playkey.HotKeyPush += new EventHandler(
                (object? sender, EventArgs e) =>
                {
                    if (MenuHotKey.Checked)
                    {
                        PlayPause();
                    }
                }
            );
            prevkey.HotKeyPush += new EventHandler(
                (object? sender, EventArgs e) =>
                {
                    if (MenuHotKey.Checked)
                    {
                        Replay();
                    }
                }
            );
            nextkey.HotKeyPush += new EventHandler(
                (object? sender, EventArgs e) =>
                {
                    if (MenuHotKey.Checked)
                    {
                        Stop();
                        EndSwitch();
                    }
                }
            );
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
            playkey.Dispose();
            prevkey.Dispose();
            nextkey.Dispose();
        }
        public void SetPlayer(string str)
        {
            player.Open(str);
            notifyIcon1.Text = str;
        }
        public void OpenFileDialog()
        {
            openFileDialog1.Filter =
                "audio files|*.wav;*.wma;*.mp3;*.mp4;*.m4a;*.aac;"
                + "*.ogg;*.oga;*.flac;*.aif?;*.mid?"
                + "|All files|*.*";
            openFileDialog1.ShowDialog();
        }
        public void SetArgs(string[] args)
        {
            if (args.Length > 0)
            {
                SetPlayer(args[0]);
            }
            else
            {
                OpenFileDialog();
            }
        }
        void SyncIcon()
        {
            if (player.NowPlay) { notifyIcon1.Icon = pauseIcon; }
            else { notifyIcon1.Icon = playIcon; }
        }
        public void Play()
        {
            player.Play();
            SyncIcon();
        }
        public void Replay()
        {
            LoopCount = 0;
            player.Position = TimeSpan.Zero;
            Play();
        }
        public void OpenPlayInvoke(string str)
        {
            Invoke(() => { OpenPlay(str); });
        }
        public void OpenPlay(string str)
        {
            ReadSetting();
            SetPlayer(str);
            Replay();
        }
        public void Pause()
        {
            player.Pause();
            SyncIcon();
        }
        public void Stop()
        {
            LoopCount = 0;
            player.Stop();
            SyncIcon();
        }
        public void PlayPause()
        {
            player.PlayPause();
            SyncIcon();
        }
        private void CloseEnd()
        {
            player.Close();
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
                player.Position = TimeSpan.Zero;
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
        private void EventEnd(object? sender, EventArgs e)
        {
            EndSwitch();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            loaded = true;
            if (player.Source == null)
            {
                Close();
            }
            else
            {
                player.MediaEnded += new EventHandler(EventEnd);
                Play();
            }
        }
        private void TaskClick(object sender, MouseEventArgs e)
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
        private void Item_RadioCheck(ToolStripMenuItem? item, ToolStripMenuItem parentItem)
        {
            foreach (ToolStripMenuItem _item in parentItem.DropDownItems)
            {
                _item.Checked = false;
            }
            if (item != null) item.Checked = true;
        }
        private void Item_RadioCheck<T>(Dictionary<T, ToolStripMenuItem> dic, T key, ToolStripMenuItem parentItem) where T : notnull
        {
            Item_RadioCheck(dic.ContainsKey(key) ? dic[key] : null, parentItem);
        }
        private void Save_Volume(double volume)
        {
            Item_RadioCheck(volumes, volume, MenuVolume);
            Settings1.Default.Volume = volume;
            Settings1.Default.Save();
            player.Volume = volume;
        }
        private void Volume_Click(object sender, EventArgs e)
        {
            Save_Volume(Convert.ToDouble(((ToolStripMenuItem)sender).Tag));
        }
        private void Volume_Parent_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Save_Volume(player.Volume != 0.5 ? 0.5 : 1);
            }
        }
        private void Save_Speed(double speed)
        {
            Item_RadioCheck(speeds, speed, MenuSpeed);
            Settings1.Default.Speed = speed;
            Settings1.Default.Save();
            player.SpeedRatio = speed;
        }
        private void Speed_Click(object sender, EventArgs e)
        {
            Save_Speed(Convert.ToDouble(((ToolStripMenuItem)sender).Tag));
        }
        private void Speed_Parent_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Save_Speed(player.SpeedRatio != 1 ? 1 : 2);
            }
        }
        private void Set_Time(double per)
        {
            player.SetPositionFromRadio(per);
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
            Settings1.Default.Loop = LoopMax;
            Settings1.Default.Save();
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
            Settings1.Default.AutoExit = MenuAutoExit.Checked;
            Settings1.Default.Save();
        }
        private void Duplication_Click(object sender, EventArgs e)
        {
            MenuDuplication.Checked = !MenuDuplication.Checked;
            Settings1.Default.Duplication = MenuDuplication.Checked;
            Settings1.Default.Save();
        }
        private void HotKey_Click(object sender, EventArgs e)
        {
            MenuHotKey.Checked = !MenuHotKey.Checked;
            Settings1.Default.HotKey = MenuHotKey.Checked;
            Settings1.Default.Save();
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