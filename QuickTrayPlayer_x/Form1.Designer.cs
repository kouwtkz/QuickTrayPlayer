namespace QuickTrayPlayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHotKey = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDuplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAutoExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVolume = new System.Windows.Forms.ToolStripMenuItem();
            this.volume0 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume10 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume20 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume30 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume40 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume50 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume60 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume70 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume80 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume90 = new System.Windows.Forms.ToolStripMenuItem();
            this.volume100 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLoop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLoopInf = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopMenu0 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopMenu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopMenu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoopMenu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "miniPlayer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuHotKey,
            this.MenuDuplication,
            this.MenuAutoExit,
            this.MenuSpeed,
            this.MenuVolume,
            this.MenuLoop,
            this.MenuTime,
            this.MenuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 220);
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
            this.MenuSpeed.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14});
            this.MenuSpeed.Name = "MenuSpeed";
            this.MenuSpeed.Size = new System.Drawing.Size(155, 24);
            this.MenuSpeed.Text = "Speed";
            this.MenuSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Speed_Parent_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem9.Tag = "0.5";
            this.toolStripMenuItem9.Text = "0.5";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem10.Tag = "0.75";
            this.toolStripMenuItem10.Text = "0.75";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem11.Tag = "1";
            this.toolStripMenuItem11.Text = "1";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem12.Tag = "1.25";
            this.toolStripMenuItem12.Text = "1.25";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem13.Tag = "1.5";
            this.toolStripMenuItem13.Text = "1.5";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem14.Tag = "2";
            this.toolStripMenuItem14.Text = "2";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.Speed_Click);
            // 
            // MenuVolume
            // 
            this.MenuVolume.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volume0,
            this.volume10,
            this.volume20,
            this.volume30,
            this.volume40,
            this.volume50,
            this.volume60,
            this.volume70,
            this.volume80,
            this.volume90,
            this.volume100});
            this.MenuVolume.Name = "MenuVolume";
            this.MenuVolume.Size = new System.Drawing.Size(155, 24);
            this.MenuVolume.Text = "Volume";
            this.MenuVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Volume_Parent_Click);
            // 
            // volume0
            // 
            this.volume0.Name = "volume0";
            this.volume0.Size = new System.Drawing.Size(116, 26);
            this.volume0.Tag = "0";
            this.volume0.Text = "0";
            this.volume0.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume10
            // 
            this.volume10.Name = "volume10";
            this.volume10.Size = new System.Drawing.Size(116, 26);
            this.volume10.Tag = "0.1";
            this.volume10.Text = "10";
            this.volume10.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume20
            // 
            this.volume20.Name = "volume20";
            this.volume20.Size = new System.Drawing.Size(116, 26);
            this.volume20.Tag = "0.2";
            this.volume20.Text = "20";
            this.volume20.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume30
            // 
            this.volume30.Name = "volume30";
            this.volume30.Size = new System.Drawing.Size(116, 26);
            this.volume30.Tag = "0.3";
            this.volume30.Text = "30";
            this.volume30.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume40
            // 
            this.volume40.Name = "volume40";
            this.volume40.Size = new System.Drawing.Size(116, 26);
            this.volume40.Tag = "0.4";
            this.volume40.Text = "40";
            this.volume40.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume50
            // 
            this.volume50.Name = "volume50";
            this.volume50.Size = new System.Drawing.Size(116, 26);
            this.volume50.Tag = "0.5";
            this.volume50.Text = "50";
            this.volume50.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume60
            // 
            this.volume60.Name = "volume60";
            this.volume60.Size = new System.Drawing.Size(116, 26);
            this.volume60.Tag = "0.6";
            this.volume60.Text = "60";
            this.volume60.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume70
            // 
            this.volume70.Name = "volume70";
            this.volume70.Size = new System.Drawing.Size(116, 26);
            this.volume70.Tag = "0.7";
            this.volume70.Text = "70";
            this.volume70.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume80
            // 
            this.volume80.Name = "volume80";
            this.volume80.Size = new System.Drawing.Size(116, 26);
            this.volume80.Tag = "0.8";
            this.volume80.Text = "80";
            this.volume80.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume90
            // 
            this.volume90.Name = "volume90";
            this.volume90.Size = new System.Drawing.Size(116, 26);
            this.volume90.Tag = "0.9";
            this.volume90.Text = "90";
            this.volume90.Click += new System.EventHandler(this.Volume_Click);
            // 
            // volume100
            // 
            this.volume100.Name = "volume100";
            this.volume100.Size = new System.Drawing.Size(116, 26);
            this.volume100.Tag = "1";
            this.volume100.Text = "100";
            this.volume100.Click += new System.EventHandler(this.Volume_Click);
            // 
            // MenuLoop
            // 
            this.MenuLoop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLoopInf,
            this.LoopMenu0,
            this.LoopMenu1,
            this.LoopMenu2,
            this.LoopMenu3,
            this.LoopMenu4});
            this.MenuLoop.Name = "MenuLoop";
            this.MenuLoop.Size = new System.Drawing.Size(155, 24);
            this.MenuLoop.Text = "Loop";
            this.MenuLoop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loop_Parent_Click);
            // 
            // MenuLoopInf
            // 
            this.MenuLoopInf.Name = "MenuLoopInf";
            this.MenuLoopInf.Size = new System.Drawing.Size(107, 26);
            this.MenuLoopInf.Tag = "-1";
            this.MenuLoopInf.Text = "∞";
            this.MenuLoopInf.Click += new System.EventHandler(this.Loop_Click);
            // 
            // LoopMenu0
            // 
            this.LoopMenu0.Name = "LoopMenu0";
            this.LoopMenu0.Size = new System.Drawing.Size(107, 26);
            this.LoopMenu0.Tag = "0";
            this.LoopMenu0.Text = "0";
            this.LoopMenu0.Click += new System.EventHandler(this.Loop_Click);
            // 
            // LoopMenu1
            // 
            this.LoopMenu1.Name = "LoopMenu1";
            this.LoopMenu1.Size = new System.Drawing.Size(107, 26);
            this.LoopMenu1.Tag = "1";
            this.LoopMenu1.Text = "1";
            this.LoopMenu1.Click += new System.EventHandler(this.Loop_Click);
            // 
            // LoopMenu2
            // 
            this.LoopMenu2.Name = "LoopMenu2";
            this.LoopMenu2.Size = new System.Drawing.Size(107, 26);
            this.LoopMenu2.Tag = "2";
            this.LoopMenu2.Text = "2";
            this.LoopMenu2.Click += new System.EventHandler(this.Loop_Click);
            // 
            // LoopMenu3
            // 
            this.LoopMenu3.Name = "LoopMenu3";
            this.LoopMenu3.Size = new System.Drawing.Size(107, 26);
            this.LoopMenu3.Tag = "3";
            this.LoopMenu3.Text = "3";
            this.LoopMenu3.Click += new System.EventHandler(this.Loop_Click);
            // 
            // LoopMenu4
            // 
            this.LoopMenu4.Name = "LoopMenu4";
            this.LoopMenu4.Size = new System.Drawing.Size(107, 26);
            this.LoopMenu4.Tag = "4";
            this.LoopMenu4.Text = "4";
            this.LoopMenu4.Click += new System.EventHandler(this.Loop_Click);
            // 
            // MenuTime
            // 
            this.MenuTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18});
            this.MenuTime.Name = "MenuTime";
            this.MenuTime.Size = new System.Drawing.Size(155, 24);
            this.MenuTime.Text = "Time";
            this.MenuTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Time_Parent_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem15.Tag = "0";
            this.toolStripMenuItem15.Text = "0%";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem16.Tag = "0.25";
            this.toolStripMenuItem16.Text = "25%";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem17.Tag = "0.5";
            this.toolStripMenuItem17.Text = "50%";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem18.Tag = "0.75";
            this.toolStripMenuItem18.Text = "75%";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.Time_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(155, 24);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(231, 74);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem MenuExit;
        private ToolStripMenuItem MenuVolume;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem volume0;
        private ToolStripMenuItem volume50;
        private ToolStripMenuItem volume100;
        private ToolStripMenuItem volume10;
        private ToolStripMenuItem volume20;
        private ToolStripMenuItem volume30;
        private ToolStripMenuItem volume40;
        private ToolStripMenuItem volume60;
        private ToolStripMenuItem volume70;
        private ToolStripMenuItem volume80;
        private ToolStripMenuItem volume90;
        private ToolStripMenuItem MenuDuplication;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem MenuOpen;
        private ToolStripMenuItem MenuHotKey;
        private ToolStripMenuItem MenuLoop;
        private ToolStripMenuItem MenuTime;
        private ToolStripMenuItem MenuSpeed;
        private ToolStripMenuItem MenuAutoExit;
        private ToolStripMenuItem MenuLoopInf;
        private ToolStripMenuItem LoopMenu0;
        private ToolStripMenuItem LoopMenu1;
        private ToolStripMenuItem LoopMenu2;
        private ToolStripMenuItem LoopMenu3;
        private ToolStripMenuItem LoopMenu4;
        private ToolStripMenuItem toolStripMenuItem9;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem toolStripMenuItem12;
        private ToolStripMenuItem toolStripMenuItem13;
        private ToolStripMenuItem toolStripMenuItem14;
        private ToolStripMenuItem toolStripMenuItem15;
        private ToolStripMenuItem toolStripMenuItem16;
        private ToolStripMenuItem toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
    }
}