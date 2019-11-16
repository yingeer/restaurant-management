namespace MrCy
{
    partial class frmDC
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
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("锅底");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("配菜");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("主食");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("烟酒");
            this.textName = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textAllPrice = new System.Windows.Forms.TextBox();
            this.textBZ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textWaiterName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mrCyDataSet = new MrCy.MrCyDataSet();
            this.tbGuestFoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_GuestFoodTableAdapter = new MrCy.MrCyDataSetTableAdapters.tb_GuestFoodTableAdapter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mrCyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGuestFoodBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(638, 48);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(169, 28);
            this.textName.TabIndex = 15;
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(470, 48);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(58, 28);
            this.textNum.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "备注：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "服务员：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(510, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "数量：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "单价：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "菜品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "点菜编号：";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 82);
            this.treeView1.Name = "treeView1";
            treeNode29.Name = "guodi";
            treeNode29.Text = "锅底";
            treeNode29.ToolTipText = "菜品";
            treeNode30.Name = "peicai";
            treeNode30.Text = "配菜";
            treeNode31.Name = "zhushi";
            treeNode31.Text = "主食";
            treeNode32.Name = "yanjiu";
            treeNode32.Text = "烟酒";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32});
            this.treeView1.Size = new System.Drawing.Size(218, 430);
            this.treeView1.TabIndex = 16;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(385, 252);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 34);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Location = new System.Drawing.Point(513, 252);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 34);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(647, 252);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 34);
            this.buttonExit.TabIndex = 20;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(432, 118);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(58, 28);
            this.textPrice.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "*";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(561, 118);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(47, 28);
            this.textNumber.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(636, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "总价：";
            // 
            // textAllPrice
            // 
            this.textAllPrice.Location = new System.Drawing.Point(684, 118);
            this.textAllPrice.Name = "textAllPrice";
            this.textAllPrice.Size = new System.Drawing.Size(58, 28);
            this.textAllPrice.TabIndex = 26;
            // 
            // textBZ
            // 
            this.textBZ.Location = new System.Drawing.Point(638, 178);
            this.textBZ.Name = "textBZ";
            this.textBZ.Size = new System.Drawing.Size(169, 28);
            this.textBZ.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 18);
            this.label10.TabIndex = 29;
            this.label10.Text = "菜品";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textWaiterName
            // 
            this.textWaiterName.Location = new System.Drawing.Point(455, 180);
            this.textWaiterName.Name = "textWaiterName";
            this.textWaiterName.Size = new System.Drawing.Size(82, 28);
            this.textWaiterName.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(617, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 31;
            this.label7.Text = "=";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(748, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mrCyDataSet
            // 
            this.mrCyDataSet.DataSetName = "MrCyDataSet";
            this.mrCyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbGuestFoodBindingSource
            // 
            this.tbGuestFoodBindingSource.DataMember = "tb_GuestFood";
            this.tbGuestFoodBindingSource.DataSource = this.mrCyDataSet;
            // 
            // tb_GuestFoodTableAdapter
            // 
            this.tb_GuestFoodTableAdapter.ClearBeforeFill = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(833, 31);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 24);
            this.toolStripStatusLabel1.Text = "消费编号：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(71, 24);
            this.toolStripStatusLabel2.Text = "default";
            // 
            // frmDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::MrCy.Properties.Resources.图片2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 540);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textWaiterName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBZ);
            this.Controls.Add(this.textAllPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDC";
            this.ShowIcon = false;
            this.Text = "点菜";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDC_FormClosed);
            this.Load += new System.EventHandler(this.frmDC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mrCyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGuestFoodBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textAllPrice;
        private System.Windows.Forms.TextBox textBZ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textWaiterName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private MrCyDataSet mrCyDataSet;
        private System.Windows.Forms.BindingSource tbGuestFoodBindingSource;
        private MrCyDataSetTableAdapters.tb_GuestFoodTableAdapter tb_GuestFoodTableAdapter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}