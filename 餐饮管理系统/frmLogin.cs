using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using System.Data.SqlClient;*/
using System.Data.SQLite;

namespace MrCy
{
    public partial class frmLogin : Form
    {
        // 传给Main
        public string now = ""; 
        public string userName = "";
        public string power = "";
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
                    SQLiteConnection con = BaseClass.DBConn.CyCon();
                    con.Open();
                    try
                    {
                        string sql1 = "select * from tb_User where userName='" + textName.Text.Trim() + "' and userPwd='" + textPwd.Text.Trim() + "'";
                        SQLiteCommand cmd = new SQLiteCommand(sql1, con);
                        SQLiteDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            string userName = sdr["userName"].ToString().Trim();
                            string userPwd = sdr["userPwd"].ToString().Trim();
                                // 判断是否存在该用户
                            if (userName == this.textName.Text.Trim() && userPwd == this.textPwd.Text.Trim())
                            {
                                    this.userName = userName;
                                    this.power = sdr["power"].ToString().Trim();
                                    this.now = DateTime.Now.ToString();
                                    // 进入Main窗口
                                    this.getInMain();
                            }
                        }
                        sdr.Close();
                       
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("登录失败，请检查用户名或密码!" + ex, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

        }

        private void getInMain()
        {
            // 进入Main窗口
            frmMain main = new frmMain();
            main.Times = this.now;
            main.Names = this.userName;
            main.power = this.power;
            MessageBox.Show("欢迎 " + this.userName);
            this.Hide();
            main.ShowDialog();
            
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
