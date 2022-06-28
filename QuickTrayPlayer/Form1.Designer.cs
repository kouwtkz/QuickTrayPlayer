namespace QuickTrayPlayer
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHotKey = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDuplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAutoExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuList_Speed = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuList_SpeedText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem52 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPanPot = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuList_PanPot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuList_PanPotText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVolume = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuList_Volume = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuList_VolumeText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem43 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem44 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem45 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem46 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem47 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLoop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuList_Loop = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuList_LoopText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTime = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuList_Jump = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuList_TimeText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TrayMenu.SuspendLayout();
            this.MenuList_Speed.SuspendLayout();
            this.MenuList_PanPot.SuspendLayout();
            this.MenuList_Volume.SuspendLayout();
            this.MenuList_Loop.SuspendLayout();
            this.MenuList_Jump.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.TrayMenu;
            this.notifyIcon1.Text = "QuickTrayPlayer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskMouseDown);
            // 
            // TrayMenu
            // 
            this.TrayMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuHotKey,
            this.MenuDuplication,
            this.MenuAutoExit,
            this.MenuSpeed,
            this.MenuPanPot,
            this.MenuVolume,
            this.MenuLoop,
            this.MenuTime,
            this.MenuExit});
            this.TrayMenu.Name = "contextMenuStrip1";
            this.TrayMenu.ShowCheckMargin = true;
            this.TrayMenu.ShowImageMargin = false;
            this.TrayMenu.Size = new System.Drawing.Size(156, 244);
            // 
            // MenuOpen
            // 
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.Size = new System.Drawing.Size(155, 24);
            this.MenuOpen.Text = "Open";
            this.MenuOpen.Click += new System.EventHandler(this.Open_Click);
            // 
            // MenuHotKey
            // 
            this.MenuHotKey.Name = "MenuHotKey";
            this.MenuHotKey.Size = new System.Drawing.Size(155, 24);
            this.MenuHotKey.Text = "HotKey";
            this.MenuHotKey.Click += new System.EventHandler(this.HotKey_Click);
            // 
            // MenuDuplication
            // 
            this.MenuDuplication.Name = "MenuDuplication";
            this.MenuDuplication.Size = new System.Drawing.Size(155, 24);
            this.MenuDuplication.Text = "Duplication";
            this.MenuDuplication.Click += new System.EventHandler(this.Duplication_Click);
            // 
            // MenuAutoExit
            // 
            this.MenuAutoExit.Name = "MenuAutoExit";
            this.MenuAutoExit.Size = new System.Drawing.Size(155, 24);
            this.MenuAutoExit.Text = "AutoExit";
            this.MenuAutoExit.Click += new System.EventHandler(this.AutoExit_Click);
            // 
            // MenuSpeed
            // 
            this.MenuSpeed.DropDown = this.MenuList_Speed;
            this.MenuSpeed.Name = "MenuSpeed";
            this.MenuSpeed.Size = new System.Drawing.Size(155, 24);
            this.MenuSpeed.Text = "Speed";
            this.MenuSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Speed_Parent_Click);
            // 
            // MenuList_Speed
            // 
            this.MenuList_Speed.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuList_Speed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuList_SpeedText,
            this.toolStripMenuItem49,
            this.toolStripMenuItem50,
            this.toolStripMenuItem51,
            this.toolStripMenuItem52,
            this.toolStripMenuItem53,
            this.toolStripMenuItem54});
            this.MenuList_Speed.Name = "MenuList_Speed";
            this.MenuList_Speed.ShowCheckMargin = true;
            this.MenuList_Speed.ShowImageMargin = false;
            this.MenuList_Speed.Size = new System.Drawing.Size(111, 177);
            // 
            // MenuList_SpeedText
            // 
            this.MenuList_SpeedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuList_SpeedText.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.MenuList_SpeedText.Name = "MenuList_SpeedText";
            this.MenuList_SpeedText.Size = new System.Drawing.Size(50, 27);
            this.MenuList_SpeedText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuList_SpeedText_KeyDown);
            this.MenuList_SpeedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterNumber_KeyPress);
            this.MenuList_SpeedText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MenuList_SpeedText_KeyUp);
            this.MenuList_SpeedText.TextChanged += new System.EventHandler(this.MenuList_SpeedText_TextChanged);
            // 
            // toolStripMenuItem49
            // 
            this.toolStripMenuItem49.Name = "toolStripMenuItem49";
            this.toolStripMenuItem49.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem49.Tag = "0.5";
            this.toolStripMenuItem49.Text = "0.5";
            this.toolStripMenuItem49.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem50
            // 
            this.toolStripMenuItem50.Name = "toolStripMenuItem50";
            this.toolStripMenuItem50.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem50.Tag = "0.75";
            this.toolStripMenuItem50.Text = "0.75";
            this.toolStripMenuItem50.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem51.Tag = "1";
            this.toolStripMenuItem51.Text = "1";
            this.toolStripMenuItem51.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem52
            // 
            this.toolStripMenuItem52.Name = "toolStripMenuItem52";
            this.toolStripMenuItem52.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem52.Tag = "1.25";
            this.toolStripMenuItem52.Text = "1.25";
            this.toolStripMenuItem52.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem53
            // 
            this.toolStripMenuItem53.Name = "toolStripMenuItem53";
            this.toolStripMenuItem53.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem53.Tag = "1.5";
            this.toolStripMenuItem53.Text = "1.5";
            this.toolStripMenuItem53.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem54
            // 
            this.toolStripMenuItem54.Name = "toolStripMenuItem54";
            this.toolStripMenuItem54.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem54.Tag = "2";
            this.toolStripMenuItem54.Text = "2";
            this.toolStripMenuItem54.Click += new System.EventHandler(this.Speed_Click);
            // 
            // MenuPanPot
            // 
            this.MenuPanPot.DropDown = this.MenuList_PanPot;
            this.MenuPanPot.Name = "MenuPanPot";
            this.MenuPanPot.Size = new System.Drawing.Size(155, 24);
            this.MenuPanPot.Tag = "1";
            this.MenuPanPot.Text = "PanPot";
            this.MenuPanPot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanPot_Parent_Click);
            // 
            // MenuList_PanPot
            // 
            this.MenuList_PanPot.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuList_PanPot.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuList_PanPotText,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6,
            this.toolStripMenuItem5});
            this.MenuList_PanPot.Name = "MenuList_Speed";
            this.MenuList_PanPot.ShowCheckMargin = true;
            this.MenuList_PanPot.ShowImageMargin = false;
            this.MenuList_PanPot.Size = new System.Drawing.Size(130, 153);
            // 
            // MenuList_PanPotText
            // 
            this.MenuList_PanPotText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuList_PanPotText.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.MenuList_PanPotText.Name = "MenuList_PanPotText";
            this.MenuList_PanPotText.Size = new System.Drawing.Size(50, 27);
            this.MenuList_PanPotText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuList_PanPotText_KeyDown);
            this.MenuList_PanPotText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterNumber_KeyPress);
            this.MenuList_PanPotText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MenuList_PanPotText_KeyUp);
            this.MenuList_PanPotText.TextChanged += new System.EventHandler(this.MenuList_PanPotText_TextChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 24);
            this.toolStripMenuItem2.Tag = "-1";
            this.toolStripMenuItem2.Text = "-100 (L)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.PanPot_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(129, 24);
            this.toolStripMenuItem3.Tag = "-0.5";
            this.toolStripMenuItem3.Text = "-50 (L)";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.PanPot_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(129, 24);
            this.toolStripMenuItem4.Tag = "0";
            this.toolStripMenuItem4.Text = "0";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.PanPot_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(129, 24);
            this.toolStripMenuItem6.Tag = "0.5";
            this.toolStripMenuItem6.Text = "50 (R)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(129, 24);
            this.toolStripMenuItem5.Tag = "1";
            this.toolStripMenuItem5.Text = "100 (R)";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.PanPot_Click);
            // 
            // MenuVolume
            // 
            this.MenuVolume.DropDown = this.MenuList_Volume;
            this.MenuVolume.Name = "MenuVolume";
            this.MenuVolume.Size = new System.Drawing.Size(155, 24);
            this.MenuVolume.Text = "Volume";
            this.MenuVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Volume_Parent_Click);
            // 
            // MenuList_Volume
            // 
            this.MenuList_Volume.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuList_Volume.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuList_VolumeText,
            this.toolStripMenuItem38,
            this.toolStripMenuItem39,
            this.toolStripMenuItem40,
            this.toolStripMenuItem41,
            this.toolStripMenuItem42,
            this.toolStripMenuItem43,
            this.toolStripMenuItem44,
            this.toolStripMenuItem45,
            this.toolStripMenuItem46,
            this.toolStripMenuItem47,
            this.toolStripMenuItem48});
            this.MenuList_Volume.Name = "MenuList_Speed";
            this.MenuList_Volume.ShowCheckMargin = true;
            this.MenuList_Volume.ShowImageMargin = false;
            this.MenuList_Volume.Size = new System.Drawing.Size(111, 297);
            // 
            // MenuList_VolumeText
            // 
            this.MenuList_VolumeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuList_VolumeText.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.MenuList_VolumeText.Name = "MenuList_VolumeText";
            this.MenuList_VolumeText.Size = new System.Drawing.Size(50, 27);
            this.MenuList_VolumeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuList_VolumeText_KeyDown);
            this.MenuList_VolumeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterNumber_KeyPress);
            this.MenuList_VolumeText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MenuList_VolumeText_KeyUp);
            this.MenuList_VolumeText.TextChanged += new System.EventHandler(this.MenuList_VolumeText_TextChanged);
            // 
            // toolStripMenuItem38
            // 
            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
            this.toolStripMenuItem38.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem38.Tag = "0";
            this.toolStripMenuItem38.Text = "0";
            this.toolStripMenuItem38.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem39.Tag = "0.1";
            this.toolStripMenuItem39.Text = "10";
            this.toolStripMenuItem39.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem40.Tag = "0.2";
            this.toolStripMenuItem40.Text = "20";
            this.toolStripMenuItem40.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem41
            // 
            this.toolStripMenuItem41.Name = "toolStripMenuItem41";
            this.toolStripMenuItem41.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem41.Tag = "0.3";
            this.toolStripMenuItem41.Text = "30";
            this.toolStripMenuItem41.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem42
            // 
            this.toolStripMenuItem42.Name = "toolStripMenuItem42";
            this.toolStripMenuItem42.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem42.Tag = "0.4";
            this.toolStripMenuItem42.Text = "40";
            this.toolStripMenuItem42.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem43
            // 
            this.toolStripMenuItem43.Name = "toolStripMenuItem43";
            this.toolStripMenuItem43.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem43.Tag = "0.5";
            this.toolStripMenuItem43.Text = "50";
            this.toolStripMenuItem43.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem44
            // 
            this.toolStripMenuItem44.Name = "toolStripMenuItem44";
            this.toolStripMenuItem44.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem44.Tag = "0.6";
            this.toolStripMenuItem44.Text = "60";
            this.toolStripMenuItem44.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem45
            // 
            this.toolStripMenuItem45.Name = "toolStripMenuItem45";
            this.toolStripMenuItem45.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem45.Tag = "0.7";
            this.toolStripMenuItem45.Text = "70";
            this.toolStripMenuItem45.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem46
            // 
            this.toolStripMenuItem46.Name = "toolStripMenuItem46";
            this.toolStripMenuItem46.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem46.Tag = "0.8";
            this.toolStripMenuItem46.Text = "80";
            this.toolStripMenuItem46.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem47
            // 
            this.toolStripMenuItem47.Name = "toolStripMenuItem47";
            this.toolStripMenuItem47.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem47.Tag = "0.9";
            this.toolStripMenuItem47.Text = "90";
            this.toolStripMenuItem47.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem48
            // 
            this.toolStripMenuItem48.Name = "toolStripMenuItem48";
            this.toolStripMenuItem48.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem48.Tag = "1";
            this.toolStripMenuItem48.Text = "100";
            this.toolStripMenuItem48.Click += new System.EventHandler(this.Volume_Click);
            // 
            // MenuLoop
            // 
            this.MenuLoop.DropDown = this.MenuList_Loop;
            this.MenuLoop.Name = "MenuLoop";
            this.MenuLoop.Size = new System.Drawing.Size(155, 24);
            this.MenuLoop.Text = "Loop";
            this.MenuLoop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loop_Parent_Click);
            // 
            // MenuList_Loop
            // 
            this.MenuList_Loop.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuList_Loop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuList_LoopText,
            this.toolStripMenuItem32,
            this.toolStripMenuItem33,
            this.toolStripMenuItem34,
            this.toolStripMenuItem35,
            this.toolStripMenuItem36,
            this.toolStripMenuItem37});
            this.MenuList_Loop.Name = "MenuList_Speed";
            this.MenuList_Loop.ShowCheckMargin = true;
            this.MenuList_Loop.ShowImageMargin = false;
            this.MenuList_Loop.Size = new System.Drawing.Size(113, 177);
            // 
            // MenuList_LoopText
            // 
            this.MenuList_LoopText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuList_LoopText.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.MenuList_LoopText.Name = "MenuList_LoopText";
            this.MenuList_LoopText.Size = new System.Drawing.Size(50, 27);
            this.MenuList_LoopText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuList_LoopText_KeyDown);
            this.MenuList_LoopText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterNumber_KeyPress);
            this.MenuList_LoopText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MenuList_LoopText_KeyUp);
            this.MenuList_LoopText.TextChanged += new System.EventHandler(this.MenuList_LoopText_TextChanged);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem32.Tag = "-1";
            this.toolStripMenuItem32.Text = "∞";
            this.toolStripMenuItem32.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem33.Tag = "0";
            this.toolStripMenuItem33.Text = "Once";
            this.toolStripMenuItem33.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem34.Tag = "1";
            this.toolStripMenuItem34.Text = "2";
            this.toolStripMenuItem34.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem35.Tag = "2";
            this.toolStripMenuItem35.Text = "3";
            this.toolStripMenuItem35.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem36.Tag = "3";
            this.toolStripMenuItem36.Text = "4";
            this.toolStripMenuItem36.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem37
            // 
            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
            this.toolStripMenuItem37.Size = new System.Drawing.Size(112, 24);
            this.toolStripMenuItem37.Tag = "4";
            this.toolStripMenuItem37.Text = "5";
            this.toolStripMenuItem37.Click += new System.EventHandler(this.Loop_Click);
            // 
            // MenuTime
            // 
            this.MenuTime.DropDown = this.MenuList_Jump;
            this.MenuTime.Name = "MenuTime";
            this.MenuTime.Size = new System.Drawing.Size(155, 24);
            this.MenuTime.Text = "Jump";
            this.MenuTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuTime_MouseDown);
            // 
            // MenuList_Jump
            // 
            this.MenuList_Jump.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuList_Jump.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuList_TimeText,
            this.toolStripMenuItem1,
            this.toolStripMenuItem29,
            this.toolStripMenuItem30,
            this.toolStripMenuItem31});
            this.MenuList_Jump.Name = "MenuList_Time";
            this.MenuList_Jump.OwnerItem = this.MenuTime;
            this.MenuList_Jump.ShowCheckMargin = true;
            this.MenuList_Jump.ShowImageMargin = false;
            this.MenuList_Jump.Size = new System.Drawing.Size(211, 157);
            // 
            // MenuList_TimeText
            // 
            this.MenuList_TimeText.BackColor = System.Drawing.Color.White;
            this.MenuList_TimeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuList_TimeText.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.MenuList_TimeText.Name = "MenuList_TimeText";
            this.MenuList_TimeText.Size = new System.Drawing.Size(50, 27);
            this.MenuList_TimeText.ToolTipText = "0~100";
            this.MenuList_TimeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MenuList_TimeText_KeyDown);
            this.MenuList_TimeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterNumber_KeyPress);
            this.MenuList_TimeText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MenuList_TimeText_KeyUp);
            this.MenuList_TimeText.TextChanged += new System.EventHandler(this.MenuList_TimeText_TextChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem1.Tag = "0";
            this.toolStripMenuItem1.Text = "0%";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem29.Tag = "0.25";
            this.toolStripMenuItem29.Text = "25%";
            this.toolStripMenuItem29.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem30.Tag = "0.5";
            this.toolStripMenuItem30.Text = "50%";
            this.toolStripMenuItem30.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(110, 24);
            this.toolStripMenuItem31.Tag = "0.75";
            this.toolStripMenuItem31.Text = "75%";
            this.toolStripMenuItem31.Click += new System.EventHandler(this.Time_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(155, 24);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 505);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "QuickTrayPlay";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TrayMenu.ResumeLayout(false);
            this.MenuList_Speed.ResumeLayout(false);
            this.MenuList_Speed.PerformLayout();
            this.MenuList_PanPot.ResumeLayout(false);
            this.MenuList_PanPot.PerformLayout();
            this.MenuList_Volume.ResumeLayout(false);
            this.MenuList_Volume.PerformLayout();
            this.MenuList_Loop.ResumeLayout(false);
            this.MenuList_Loop.PerformLayout();
            this.MenuList_Jump.ResumeLayout(false);
            this.MenuList_Jump.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip TrayMenu;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuHotKey;
        private System.Windows.Forms.ToolStripMenuItem MenuDuplication;
        private System.Windows.Forms.ToolStripMenuItem MenuAutoExit;
        private System.Windows.Forms.ToolStripMenuItem MenuSpeed;
        private System.Windows.Forms.ToolStripMenuItem MenuVolume;
        private System.Windows.Forms.ToolStripMenuItem MenuLoop;
        private System.Windows.Forms.ToolStripMenuItem MenuTime;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ContextMenuStrip MenuList_Jump;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip MenuList_Loop;
        private System.Windows.Forms.ContextMenuStrip MenuList_Speed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem29;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem30;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem31;
        private System.Windows.Forms.ContextMenuStrip MenuList_PanPot;
        private System.Windows.Forms.ToolStripTextBox MenuList_TimeText;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem32;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem33;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem34;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem35;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem36;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem37;
        private System.Windows.Forms.ToolStripTextBox MenuList_LoopText;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem49;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem50;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem51;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem52;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem53;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem54;
        private System.Windows.Forms.ToolStripTextBox MenuList_SpeedText;
        private System.Windows.Forms.ContextMenuStrip MenuList_Volume;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem38;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem39;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem40;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem41;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem42;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem43;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem44;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem45;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem46;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem47;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem48;
        private System.Windows.Forms.ToolStripTextBox MenuList_PanPotText;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuPanPot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripTextBox MenuList_VolumeText;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}

