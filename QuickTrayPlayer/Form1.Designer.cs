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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHotKey = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDuplication = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAutoExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSpeed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVolume = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLoop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "QuickTrayPlayer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskMouseDown);
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
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25,
            this.toolStripMenuItem26,
            this.toolStripMenuItem27,
            this.toolStripMenuItem28});
            this.MenuSpeed.Name = "MenuSpeed";
            this.MenuSpeed.Size = new System.Drawing.Size(155, 24);
            this.MenuSpeed.Text = "Speed";
            this.MenuSpeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Speed_Parent_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem23.Tag = "0.5";
            this.toolStripMenuItem23.Text = "0.5";
            this.toolStripMenuItem23.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem24.Tag = "0.75";
            this.toolStripMenuItem24.Text = "0.75";
            this.toolStripMenuItem24.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem25.Tag = "1";
            this.toolStripMenuItem25.Text = "1";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem26.Tag = "1.25";
            this.toolStripMenuItem26.Text = "1.25";
            this.toolStripMenuItem26.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem27.Tag = "1.5";
            this.toolStripMenuItem27.Text = "1.5";
            this.toolStripMenuItem27.Click += new System.EventHandler(this.Speed_Click);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(119, 26);
            this.toolStripMenuItem28.Tag = "2";
            this.toolStripMenuItem28.Text = "2";
            this.toolStripMenuItem28.Click += new System.EventHandler(this.Speed_Click);
            // 
            // MenuVolume
            // 
            this.MenuVolume.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22});
            this.MenuVolume.Name = "MenuVolume";
            this.MenuVolume.Size = new System.Drawing.Size(155, 24);
            this.MenuVolume.Text = "Volume";
            this.MenuVolume.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Volume_Parent_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem12.Tag = "0";
            this.toolStripMenuItem12.Text = "0";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem13.Tag = "0.1";
            this.toolStripMenuItem13.Text = "10";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem14.Tag = "0.2";
            this.toolStripMenuItem14.Text = "20";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem15.Tag = "0.3";
            this.toolStripMenuItem15.Text = "30";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem16.Tag = "0.4";
            this.toolStripMenuItem16.Text = "40";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem17.Tag = "0.5";
            this.toolStripMenuItem17.Text = "50";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem18.Tag = "0.6";
            this.toolStripMenuItem18.Text = "60";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem19.Tag = "0.7";
            this.toolStripMenuItem19.Text = "70";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem20.Tag = "0.8";
            this.toolStripMenuItem20.Text = "80";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem21.Tag = "0.9";
            this.toolStripMenuItem21.Text = "90";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.Volume_Click);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(116, 26);
            this.toolStripMenuItem22.Tag = "1";
            this.toolStripMenuItem22.Text = "100";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.Volume_Click);
            // 
            // MenuLoop
            // 
            this.MenuLoop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.MenuLoop.Name = "MenuLoop";
            this.MenuLoop.Size = new System.Drawing.Size(155, 24);
            this.MenuLoop.Text = "Loop";
            this.MenuLoop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loop_Parent_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem6.Tag = "-1";
            this.toolStripMenuItem6.Text = "∞";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem7.Tag = "0";
            this.toolStripMenuItem7.Text = "Once";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem8.Tag = "1";
            this.toolStripMenuItem8.Text = "2";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem9.Tag = "2";
            this.toolStripMenuItem9.Text = "3";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem10.Tag = "3";
            this.toolStripMenuItem10.Text = "4";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.Loop_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(126, 26);
            this.toolStripMenuItem11.Tag = "4";
            this.toolStripMenuItem11.Text = "5";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.Loop_Click);
            // 
            // MenuTime
            // 
            this.MenuTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.MenuTime.Name = "MenuTime";
            this.MenuTime.Size = new System.Drawing.Size(155, 24);
            this.MenuTime.Text = "Time";
            this.MenuTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Time_Parent_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem2.Tag = "0";
            this.toolStripMenuItem2.Text = "0%";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem3.Tag = "0.25";
            this.toolStripMenuItem3.Text = "25%";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem4.Tag = "0.5";
            this.toolStripMenuItem4.Text = "50%";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Time_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(120, 26);
            this.toolStripMenuItem5.Tag = "0.75";
            this.toolStripMenuItem5.Text = "75%";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.Time_Click);
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
            this.ClientSize = new System.Drawing.Size(131, 0);
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem28;
    }
}

