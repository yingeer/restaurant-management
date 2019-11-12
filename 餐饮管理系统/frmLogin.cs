﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MrCy
{
    public partial class frmLogin : Form
    {
    
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textName.Text == "")
            {
                MessageBox.Show("请输入用户名", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                if (textPwd.Text == "")
                {
                    MessageBox.Show("请输入密码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // 数据库登录,用户信息查询
                    try
                    {
                        using(SqlConnection con = BaseClass.DBConn.CyCon())
                        {
                            con.Open();
                            string sql1 = "select * from tb_User where UserName=N'" + textName.Text + "' and UserPwd=N'" + textPwd.Text + "'";
                            SqlCommand cmd = new SqlCommand(sql1, con);
                            SqlDataReader sdr = cmd.ExecuteReader();
                            while (sdr.Read())
                            {
                                MessageBox.Show("欢迎" + sdr["UserName"]);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("登录失败，请检查用户名或密码!" + ex, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void textPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.buttonSubmit_Click(sender, e);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("确定退出系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dia == DialogResult.OK)
            {
                Application.Exit(); // 退出应用
            }
        }
    }
}
