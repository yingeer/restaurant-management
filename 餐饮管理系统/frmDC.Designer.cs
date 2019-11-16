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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("锅底");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("配菜");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("主食");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("烟酒");
            this.textName = new System.Windows.Forms.TextBox();
            this.textNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textAllPrice = new System.Windows.Forms.TextBox();
            this.comboWaiterName = new System.Windows.Forms.ComboBox();
            this.textBZ = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.label1.Text = "菜单编号：";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(25, 82);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "guodi";
            treeNode1.Text = "锅底";
            treeNode1.ToolTipText = "菜品";
            treeNode2.Name = "peicai";
            treeNode2.Text = "配菜";
            treeNode3.Name = "zhushi";
            treeNode3.Text = "主食";
            treeNode4.Name = "yanjiu";
            treeNode4.Text = "烟酒";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(218, 430);
            this.treeView1.TabIndex = 16;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5});
            this.dataGridView1.Location = new System.Drawing.Point(289, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(518, 204);
            this.dataGridView1.TabIndex = 17;
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
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "=";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.textNumber.Location = new System.Drawing.Point(562, 118);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(58, 28);
            this.textNumber.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "总价：";
            // 
            // textAllPrice
            // 
            this.textAllPrice.Location = new System.Drawing.Point(704, 118);
            this.textAllPrice.Name = "textAllPrice";
            this.textAllPrice.Size = new System.Drawing.Size(103, 28);
            this.textAllPrice.TabIndex = 26;
            // 
            // comboWaiterName
            // 
            this.comboWaiterName.FormattingEnabled = true;
            this.comboWaiterName.Location = new System.Drawing.Point(451, 180);
            this.comboWaiterName.Name = "comboWaiterName";
            this.comboWaiterName.Size = new System.Drawing.Size(102, 26);
            this.comboWaiterName.TabIndex = 27;
            // 
            // textBZ
            // 
            this.textBZ.Location = new System.Drawing.Point(638, 178);
            this.textBZ.Name = "textBZ";
            this.textBZ.Size = new System.Drawing.Size(169, 28);
            this.textBZ.TabIndex = 28;
            // 
            // c1
            // 
            this.c1.HeaderText = "菜名";
            this.c1.MinimumWidth = 8;
            this.c1.Name = "c1";
            this.c1.Width = 150;
            // 
            // c2
            // 
            this.c2.HeaderText = "数量";
            this.c2.MinimumWidth = 8;
            this.c2.Name = "c2";
            this.c2.Width = 150;
            // 
            // c3
            // 
            this.c3.HeaderText = "总价";
            this.c3.MinimumWidth = 8;
            this.c3.Name = "c3";
            this.c3.Width = 150;
            // 
            // c4
            // 
            this.c4.HeaderText = "服务员";
            this.c4.MinimumWidth = 8;
            this.c4.Name = "c4";
            this.c4.Width = 150;
            // 
            // c5
            // 
            this.c5.HeaderText = "备注";
            this.c5.MinimumWidth = 8;
            this.c5.Name = "c5";
            this.c5.Width = 150;
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
            // frmDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MrCy.Properties.Resources.图片2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 562);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBZ);
            this.Controls.Add(this.comboWaiterName);
            this.Controls.Add(this.textAllPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textAllPrice;
        private System.Windows.Forms.ComboBox comboWaiterName;
        private System.Windows.Forms.TextBox textBZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.Label label10;
    }
}