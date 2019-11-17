namespace MrCy
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基础信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.桌台信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.辅助工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统备份ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统恢复ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.口令设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统锁定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消开台ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点加菜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消费查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结账ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础信息ToolStripMenuItem,
            this.辅助工具ToolStripMenuItem,
            this.系统维护ToolStripMenuItem,
            this.系统设置ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 32);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 基础信息ToolStripMenuItem
            // 
            this.基础信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.桌台信息ToolStripMenuItem,
            this.职员信息ToolStripMenuItem});
            this.基础信息ToolStripMenuItem.Name = "基础信息ToolStripMenuItem";
            this.基础信息ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.基础信息ToolStripMenuItem.Text = "基础信息";
            this.基础信息ToolStripMenuItem.Click += new System.EventHandler(this.基础信息ToolStripMenuItem_Click);
            // 
            // 桌台信息ToolStripMenuItem
            // 
            this.桌台信息ToolStripMenuItem.Name = "桌台信息ToolStripMenuItem";
            this.桌台信息ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.桌台信息ToolStripMenuItem.Text = "桌台信息";
            this.桌台信息ToolStripMenuItem.Click += new System.EventHandler(this.桌台信息ToolStripMenuItem_Click);
            // 
            // 职员信息ToolStripMenuItem
            // 
            this.职员信息ToolStripMenuItem.Name = "职员信息ToolStripMenuItem";
            this.职员信息ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.职员信息ToolStripMenuItem.Text = "职员信息";
            this.职员信息ToolStripMenuItem.Click += new System.EventHandler(this.职员信息ToolStripMenuItem_Click);
            // 
            // 辅助工具ToolStripMenuItem
            // 
            this.辅助工具ToolStripMenuItem.Name = "辅助工具ToolStripMenuItem";
            this.辅助工具ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.辅助工具ToolStripMenuItem.Text = "辅助工具";
            // 
            // 系统维护ToolStripMenuItem
            // 
            this.系统维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.权限管理ToolStripMenuItem,
            this.系统备份ToolStripMenuItem,
            this.系统恢复ToolStripMenuItem});
            this.系统维护ToolStripMenuItem.Name = "系统维护ToolStripMenuItem";
            this.系统维护ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.系统维护ToolStripMenuItem.Text = "系统维护";
            // 
            // 权限管理ToolStripMenuItem
            // 
            this.权限管理ToolStripMenuItem.Name = "权限管理ToolStripMenuItem";
            this.权限管理ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.权限管理ToolStripMenuItem.Text = "权限管理";
            this.权限管理ToolStripMenuItem.Click += new System.EventHandler(this.权限管理ToolStripMenuItem_Click);
            // 
            // 系统备份ToolStripMenuItem
            // 
            this.系统备份ToolStripMenuItem.Name = "系统备份ToolStripMenuItem";
            this.系统备份ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.系统备份ToolStripMenuItem.Text = "系统备份";
            this.系统备份ToolStripMenuItem.Click += new System.EventHandler(this.系统备份ToolStripMenuItem_Click);
            // 
            // 系统恢复ToolStripMenuItem
            // 
            this.系统恢复ToolStripMenuItem.Name = "系统恢复ToolStripMenuItem";
            this.系统恢复ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.系统恢复ToolStripMenuItem.Text = "系统恢复";
            this.系统恢复ToolStripMenuItem.Click += new System.EventHandler(this.系统恢复ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.口令设置ToolStripMenuItem,
            this.系统锁定ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 口令设置ToolStripMenuItem
            // 
            this.口令设置ToolStripMenuItem.Name = "口令设置ToolStripMenuItem";
            this.口令设置ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.口令设置ToolStripMenuItem.Text = "口令设置";
            this.口令设置ToolStripMenuItem.Click += new System.EventHandler(this.口令设置ToolStripMenuItem_Click);
            // 
            // 系统锁定ToolStripMenuItem
            // 
            this.系统锁定ToolStripMenuItem.Name = "系统锁定ToolStripMenuItem";
            this.系统锁定ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.系统锁定ToolStripMenuItem.Text = "系统锁定";
            this.系统锁定ToolStripMenuItem.Click += new System.EventHandler(this.系统锁定ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(918, 31);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 24);
            this.toolStripStatusLabel1.Text = "登录用户名：";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(71, 24);
            this.toolStripStatusLabel2.Text = "default";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(15, 24);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(100, 24);
            this.toolStripStatusLabel4.Text = "用户权限：";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(71, 24);
            this.toolStripStatusLabel5.Text = "default";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(15, 24);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(100, 24);
            this.toolStripStatusLabel7.Text = "登陆时间：";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(71, 24);
            this.toolStripStatusLabel8.Text = "default";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "桌子.png");
            this.imageList1.Images.SetKeyName(1, "空闲餐桌.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开台ToolStripMenuItem,
            this.取消开台ToolStripMenuItem,
            this.点加菜ToolStripMenuItem,
            this.消费查询ToolStripMenuItem,
            this.结账ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 187);
            // 
            // 开台ToolStripMenuItem
            // 
            this.开台ToolStripMenuItem.Name = "开台ToolStripMenuItem";
            this.开台ToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.开台ToolStripMenuItem.Text = "开台";
            this.开台ToolStripMenuItem.Click += new System.EventHandler(this.开台ToolStripMenuItem_Click);
            // 
            // 取消开台ToolStripMenuItem
            // 
            this.取消开台ToolStripMenuItem.Name = "取消开台ToolStripMenuItem";
            this.取消开台ToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.取消开台ToolStripMenuItem.Text = "取消开台";
            this.取消开台ToolStripMenuItem.Click += new System.EventHandler(this.取消开台ToolStripMenuItem_Click);
            // 
            // 点加菜ToolStripMenuItem
            // 
            this.点加菜ToolStripMenuItem.Name = "点加菜ToolStripMenuItem";
            this.点加菜ToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.点加菜ToolStripMenuItem.Text = "点|加菜";
            this.点加菜ToolStripMenuItem.Click += new System.EventHandler(this.点加菜ToolStripMenuItem_Click);
            // 
            // 消费查询ToolStripMenuItem
            // 
            this.消费查询ToolStripMenuItem.Name = "消费查询ToolStripMenuItem";
            this.消费查询ToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.消费查询ToolStripMenuItem.Text = "消费查询";
            this.消费查询ToolStripMenuItem.Click += new System.EventHandler(this.消费查询ToolStripMenuItem_Click);
            // 
            // 结账ToolStripMenuItem
            // 
            this.结账ToolStripMenuItem.Name = "结账ToolStripMenuItem";
            this.结账ToolStripMenuItem.Size = new System.Drawing.Size(240, 30);
            this.结账ToolStripMenuItem.Text = "结账";
            this.结账ToolStripMenuItem.Click += new System.EventHandler(this.结账ToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = global::MrCy.Properties.Resources.图片2;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(156, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(616, 440);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 580);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "餐饮管理系统主页";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基础信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 辅助工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消开台ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点加菜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 消费查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结账ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem 桌台信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统备份ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统恢复ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 口令设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统锁定ToolStripMenuItem;
    }
}