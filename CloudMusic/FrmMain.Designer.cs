namespace DKProCloudMusic
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.skinMenuStrip1 = new CCWin.SkinControl.SkinMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoStart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoMini = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoMode = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoNone = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoVpn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAutoHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUseHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMoreInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.rbtnHosts = new System.Windows.Forms.RadioButton();
            this.rbtnVpn = new System.Windows.Forms.RadioButton();
            this.btnStart = new CCWin.SkinControl.SkinButton();
            this.btnStop = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnMenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuVpn = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuHosts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.skinMenuStrip1.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinMenuStrip1.Back = System.Drawing.Color.White;
            this.skinMenuStrip1.BackRadius = 4;
            this.skinMenuStrip1.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.skinMenuStrip1.Base = System.Drawing.Color.Transparent;
            this.skinMenuStrip1.BaseFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.BaseForeAnamorphosis = false;
            this.skinMenuStrip1.BaseForeAnamorphosisBorder = 4;
            this.skinMenuStrip1.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseHoverFore = System.Drawing.Color.White;
            this.skinMenuStrip1.BaseItemAnamorphosis = true;
            this.skinMenuStrip1.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemBorderShow = true;
            this.skinMenuStrip1.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemDown")));
            this.skinMenuStrip1.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("skinMenuStrip1.BaseItemMouse")));
            this.skinMenuStrip1.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.BaseItemRadius = 4;
            this.skinMenuStrip1.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinMenuStrip1.HoverFore = System.Drawing.Color.Black;
            this.skinMenuStrip1.ItemAnamorphosis = true;
            this.skinMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemBorderShow = true;
            this.skinMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinMenuStrip1.ItemRadius = 4;
            this.skinMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btnUseHelp,
            this.btnMoreInfo});
            this.skinMenuStrip1.Location = new System.Drawing.Point(4, 32);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinMenuStrip1.Size = new System.Drawing.Size(253, 25);
            this.skinMenuStrip1.SkinAllColor = true;
            this.skinMenuStrip1.TabIndex = 0;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            this.skinMenuStrip1.TitleAnamorphosis = true;
            this.skinMenuStrip1.TitleColor = System.Drawing.Color.Transparent;
            this.skinMenuStrip1.TitleRadius = 4;
            this.skinMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAutoStart,
            this.btnAutoMini,
            this.btnAutoMode});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "开机自启";
            // 
            // btnAutoStart
            // 
            this.btnAutoStart.Name = "btnAutoStart";
            this.btnAutoStart.Size = new System.Drawing.Size(180, 22);
            this.btnAutoStart.Text = "自动启动";
            this.btnAutoStart.CheckedChanged += new System.EventHandler(this.BtnAutoStart_CheckedChanged);
            this.btnAutoStart.Click += new System.EventHandler(this.BtnAutoStart_Click);
            // 
            // btnAutoMini
            // 
            this.btnAutoMini.Checked = true;
            this.btnAutoMini.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAutoMini.Name = "btnAutoMini";
            this.btnAutoMini.Size = new System.Drawing.Size(180, 22);
            this.btnAutoMini.Text = "启动后最小化";
            this.btnAutoMini.Click += new System.EventHandler(this.BtnAutoMini_Click);
            // 
            // btnAutoMode
            // 
            this.btnAutoMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAutoNone,
            this.btnAutoVpn,
            this.btnAutoHosts});
            this.btnAutoMode.Name = "btnAutoMode";
            this.btnAutoMode.Size = new System.Drawing.Size(180, 22);
            this.btnAutoMode.Text = "脚本模式";
            // 
            // btnAutoNone
            // 
            this.btnAutoNone.Checked = true;
            this.btnAutoNone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnAutoNone.Name = "btnAutoNone";
            this.btnAutoNone.Size = new System.Drawing.Size(180, 22);
            this.btnAutoNone.Text = "关闭";
            this.btnAutoNone.Click += new System.EventHandler(this.BtnAutoNone_Click);
            // 
            // btnAutoVpn
            // 
            this.btnAutoVpn.Name = "btnAutoVpn";
            this.btnAutoVpn.Size = new System.Drawing.Size(180, 22);
            this.btnAutoVpn.Text = "代理模式";
            this.btnAutoVpn.Click += new System.EventHandler(this.BtnAutoVpn_Click);
            // 
            // btnAutoHosts
            // 
            this.btnAutoHosts.Name = "btnAutoHosts";
            this.btnAutoHosts.Size = new System.Drawing.Size(180, 22);
            this.btnAutoHosts.Text = "Hosts模式";
            this.btnAutoHosts.Click += new System.EventHandler(this.BtnAutoHosts_Click);
            // 
            // btnUseHelp
            // 
            this.btnUseHelp.Name = "btnUseHelp";
            this.btnUseHelp.Size = new System.Drawing.Size(100, 21);
            this.btnUseHelp.Text = "使用说明(必看)";
            this.btnUseHelp.Click += new System.EventHandler(this.BtnUseHelp_Click);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(68, 21);
            this.btnMoreInfo.Text = "更多信息";
            this.btnMoreInfo.Click += new System.EventHandler(this.BtnMoreInfo_Click);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Controls.Add(this.rbtnHosts);
            this.skinGroupBox1.Controls.Add(this.rbtnVpn);
            this.skinGroupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(7, 60);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(146, 118);
            this.skinGroupBox1.TabIndex = 1;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "模式选择";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Black;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // rbtnHosts
            // 
            this.rbtnHosts.AutoSize = true;
            this.rbtnHosts.Location = new System.Drawing.Point(6, 74);
            this.rbtnHosts.Name = "rbtnHosts";
            this.rbtnHosts.Size = new System.Drawing.Size(88, 18);
            this.rbtnHosts.TabIndex = 1;
            this.rbtnHosts.Text = "Hosts模式";
            this.rbtnHosts.UseVisualStyleBackColor = true;
            // 
            // rbtnVpn
            // 
            this.rbtnVpn.AutoSize = true;
            this.rbtnVpn.Checked = true;
            this.rbtnVpn.Location = new System.Drawing.Point(6, 36);
            this.rbtnVpn.Name = "rbtnVpn";
            this.rbtnVpn.Size = new System.Drawing.Size(123, 18);
            this.rbtnVpn.TabIndex = 0;
            this.rbtnVpn.TabStop = true;
            this.rbtnVpn.Text = "代理模式(推荐)";
            this.rbtnVpn.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStart.DownBack = null;
            this.btnStart.Location = new System.Drawing.Point(160, 76);
            this.btnStart.MouseBack = null;
            this.btnStart.Name = "btnStart";
            this.btnStart.NormlBack = null;
            this.btnStart.Size = new System.Drawing.Size(94, 38);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "启    动";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStop.DownBack = null;
            this.btnStop.Location = new System.Drawing.Point(160, 134);
            this.btnStop.MouseBack = null;
            this.btnStop.Name = "btnStop";
            this.btnStop.NormlBack = null;
            this.btnStop.Size = new System.Drawing.Size(94, 38);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "关    闭";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(11, 192);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(35, 17);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "端口:";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(52, 192);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            81,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(59, 21);
            this.numPort.TabIndex = 5;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPort.Value = new decimal(new int[] {
            8125,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.labStatus});
            this.statusStrip1.Location = new System.Drawing.Point(4, 215);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(253, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "服务状态：";
            // 
            // labStatus
            // 
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(44, 17);
            this.labStatus.Text = "未启动";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(160, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "检查更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "DKPro服务未启动";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuShow,
            this.btnMenuStart,
            this.btnMenuStop,
            this.btnMenuExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 92);
            this.contextMenuStrip1.Text = "显示页面";
            // 
            // btnMenuShow
            // 
            this.btnMenuShow.Name = "btnMenuShow";
            this.btnMenuShow.Size = new System.Drawing.Size(124, 22);
            this.btnMenuShow.Text = "显示页面";
            this.btnMenuShow.Click += new System.EventHandler(this.BtnMenuShow_Click);
            // 
            // btnMenuStart
            // 
            this.btnMenuStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuVpn,
            this.btnMenuHosts});
            this.btnMenuStart.Name = "btnMenuStart";
            this.btnMenuStart.Size = new System.Drawing.Size(124, 22);
            this.btnMenuStart.Text = "启动服务";
            // 
            // btnMenuVpn
            // 
            this.btnMenuVpn.Name = "btnMenuVpn";
            this.btnMenuVpn.Size = new System.Drawing.Size(133, 22);
            this.btnMenuVpn.Text = "代理模式";
            this.btnMenuVpn.Click += new System.EventHandler(this.BtnMenuVpn_Click);
            // 
            // btnMenuHosts
            // 
            this.btnMenuHosts.Name = "btnMenuHosts";
            this.btnMenuHosts.Size = new System.Drawing.Size(133, 22);
            this.btnMenuHosts.Text = "Hosts模式";
            this.btnMenuHosts.Click += new System.EventHandler(this.BtnMenuHosts_Click);
            // 
            // btnMenuStop
            // 
            this.btnMenuStop.Enabled = false;
            this.btnMenuStop.Name = "btnMenuStop";
            this.btnMenuStop.Size = new System.Drawing.Size(124, 22);
            this.btnMenuStop.Text = "关闭服务";
            this.btnMenuStop.Click += new System.EventHandler(this.BtnMenuStop_Click);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(124, 22);
            this.btnMenuExit.Text = "退出程序";
            this.btnMenuExit.Click += new System.EventHandler(this.BtnMenuExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(261, 241);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.skinMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.skinMenuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "DKPro网易云工具1.0";
            this.TitleOffset = new System.Drawing.Point(4, 5);
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMain_SizeChanged);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinMenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnAutoStart;
        private System.Windows.Forms.ToolStripMenuItem btnAutoMini;
        private System.Windows.Forms.ToolStripMenuItem btnUseHelp;
        private System.Windows.Forms.ToolStripMenuItem btnMoreInfo;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.RadioButton rbtnHosts;
        private System.Windows.Forms.RadioButton rbtnVpn;
        private CCWin.SkinControl.SkinButton btnStart;
        private CCWin.SkinControl.SkinButton btnStop;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel labStatus;
        private System.Windows.Forms.ToolStripMenuItem btnAutoMode;
        private System.Windows.Forms.ToolStripMenuItem btnAutoVpn;
        private System.Windows.Forms.ToolStripMenuItem btnAutoHosts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuShow;
        private System.Windows.Forms.ToolStripMenuItem btnMenuStart;
        private System.Windows.Forms.ToolStripMenuItem btnMenuVpn;
        private System.Windows.Forms.ToolStripMenuItem btnMenuHosts;
        private System.Windows.Forms.ToolStripMenuItem btnMenuStop;
        private System.Windows.Forms.ToolStripMenuItem btnMenuExit;
        private System.Windows.Forms.ToolStripMenuItem btnAutoNone;
    }
}

