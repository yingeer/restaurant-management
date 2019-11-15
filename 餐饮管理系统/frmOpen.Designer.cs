namespace MrCy
{
    partial class frmOpen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.textCustomerNum = new System.Windows.Forms.TextBox();
            this.textBZ = new System.Windows.Forms.TextBox();
            this.comboNum = new System.Windows.Forms.ComboBox();
            this.comboWaiter = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mrCyDataSet = new MrCy.MrCyDataSet();
            this.tbRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_RoomTableAdapter = new MrCy.MrCyDataSetTableAdapters.tb_RoomTableAdapter();
            this.tbWaiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_WaiterTableAdapter = new MrCy.MrCyDataSetTableAdapters.tb_WaiterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mrCyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWaiterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "桌台编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "账单日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "顾客名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "用餐人数：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "服务员：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注：";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Location = new System.Drawing.Point(253, 251);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 37);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(413, 251);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 37);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(186, 115);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(186, 28);
            this.textCustomerName.TabIndex = 8;
            // 
            // textCustomerNum
            // 
            this.textCustomerNum.Location = new System.Drawing.Point(553, 115);
            this.textCustomerNum.Name = "textCustomerNum";
            this.textCustomerNum.Size = new System.Drawing.Size(186, 28);
            this.textCustomerNum.TabIndex = 9;
            this.textCustomerNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCustomerNum_KeyPress);
            // 
            // textBZ
            // 
            this.textBZ.Location = new System.Drawing.Point(553, 172);
            this.textBZ.Name = "textBZ";
            this.textBZ.Size = new System.Drawing.Size(186, 28);
            this.textBZ.TabIndex = 10;
            // 
            // comboNum
            // 
            this.comboNum.DataSource = this.tbRoomBindingSource;
            this.comboNum.DisplayMember = "RoomName";
            this.comboNum.FormattingEnabled = true;
            this.comboNum.Location = new System.Drawing.Point(185, 54);
            this.comboNum.Name = "comboNum";
            this.comboNum.Size = new System.Drawing.Size(187, 26);
            this.comboNum.TabIndex = 11;
            this.comboNum.ValueMember = "RoomName";
            this.comboNum.SelectedIndexChanged += new System.EventHandler(this.comboNum_SelectedIndexChanged);
            // 
            // comboWaiter
            // 
            this.comboWaiter.DataSource = this.tbWaiterBindingSource;
            this.comboWaiter.DisplayMember = "WaiterNmae";
            this.comboWaiter.FormattingEnabled = true;
            this.comboWaiter.Location = new System.Drawing.Point(186, 175);
            this.comboWaiter.Name = "comboWaiter";
            this.comboWaiter.Size = new System.Drawing.Size(186, 26);
            this.comboWaiter.TabIndex = 12;
            this.comboWaiter.ValueMember = "WaiterNmae";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(553, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 28);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // mrCyDataSet
            // 
            this.mrCyDataSet.DataSetName = "MrCyDataSet";
            this.mrCyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbRoomBindingSource
            // 
            this.tbRoomBindingSource.DataMember = "tb_Room";
            this.tbRoomBindingSource.DataSource = this.mrCyDataSet;
            // 
            // tb_RoomTableAdapter
            // 
            this.tb_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // tbWaiterBindingSource
            // 
            this.tbWaiterBindingSource.DataMember = "tb_Waiter";
            this.tbWaiterBindingSource.DataSource = this.mrCyDataSet;
            // 
            // tb_WaiterTableAdapter
            // 
            this.tb_WaiterTableAdapter.ClearBeforeFill = true;
            // 
            // frmOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MrCy.Properties.Resources.图片2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(803, 328);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboWaiter);
            this.Controls.Add(this.comboNum);
            this.Controls.Add(this.textBZ);
            this.Controls.Add(this.textCustomerNum);
            this.Controls.Add(this.textCustomerName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOpen";
            this.ShowIcon = false;
            this.Text = "开台单";
            this.Load += new System.EventHandler(this.frmOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mrCyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWaiterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.TextBox textCustomerNum;
        private System.Windows.Forms.TextBox textBZ;
        private System.Windows.Forms.ComboBox comboNum;
        private System.Windows.Forms.ComboBox comboWaiter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MrCyDataSet mrCyDataSet;
        private System.Windows.Forms.BindingSource tbRoomBindingSource;
        private MrCyDataSetTableAdapters.tb_RoomTableAdapter tb_RoomTableAdapter;
        private System.Windows.Forms.BindingSource tbWaiterBindingSource;
        private MrCyDataSetTableAdapters.tb_WaiterTableAdapter tb_WaiterTableAdapter;
    }
}