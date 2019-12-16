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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
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
                        string sql1 = "select * from tb_User where userName='" + textName.Text.Trim() + "' and userPwd='" + textPwd.Text.Trim() + "'";
                        SQLiteCommand cmd = new SQLiteCommand(sql1, con);
                        SQLiteDataReader sdr = cmd.ExecuteReader();
                        string userName = "";
                        string userPwd = "";
                        while (sdr.Read())
                        {
                            userName = sdr["userName"].ToString().Trim();
                            userPwd = sdr["userPwd"].ToString().Trim();
                                // 判断是否存在该用户
                            if (userName == this.textName.Text.Trim() && userPwd == this.textPwd.Text.Trim())
                            {
                                    this.userName = userName;
                                    this.power = sdr["power"].ToString().Trim();
                                    this.now = DateTime.Now.ToString();
                                    break;
                            }
                        }
                        sdr.Close();
                        con.Close();
                        /*  MessageBox.Show("con关闭");*/
                        // 进入Main窗口
                        if (userName == this.textName.Text.Trim() && userPwd == this.textPwd.Text.Trim())
                        {
                            this.getInMain();

                        }else
                        {
                            throw new Exception();
                        }

                    }
                    catch (Exception )
                    {
                        MessageBox.Show("登录失败，请检查用户名或密码!" , "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            main.ShowDialog();
            
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
