using System;
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
    public partial class frmMain : Form
    {
        public SqlDataReader sdr;
        public string power = "1"; // 登录用户权限
        public string Names;
        public string Times;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 判断用户登录的权限,分配不同的功能
            switch (this.power)
            {
                case "0": toolStripStatusLabel5.Text = "超级管理员"; break;
                case "1": toolStripStatusLabel5.Text = "经理"; break;
                case "2": toolStripStatusLabel5.Text = "一般用户"; break;
            }
            toolStripStatusLabel2.Text = this.Names;
            toolStripStatusLabel8.Text = this.Times;
            if (this.power == "2")
            {
                系统维护ToolStripMenuItem.Enabled = false;
                基础信息ToolStripMenuItem.Enabled = false;

            } else if (this.power == "1")
            {
                系统维护ToolStripMenuItem.Enabled = false;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("确定退出系统吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dia == DialogResult.OK)
            {
                Application.Exit(); // 退出应用
                
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            // 链接数据库
            SqlConnection con = BaseClass.DBConn.CyCon();
            try
            {
                con.Open();
                
                string sql = "select * from tb_Room";
                SqlCommand cmd = new SqlCommand(sql, con);
                this.sdr = cmd.ExecuteReader();
                while(sdr.Read())
                {
                    string zt = sdr["RoomZT"].ToString().Trim();
                    // AddItems方法为ListView1控件添加项目
                    this.AddItems(zt);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败" + ex);
            } 
            finally
            {
                con.Close();
            }

        }

        private void AddItems(string rzt)
        {
            // AddItem方法为ListView1控件添加项目
            if (rzt == "使用")
            {
                // 使用状态的话添加索引为1的图片
                listView1.Items.Add(this.sdr["RoomName"].ToString(), 1);
            } else
            {
                // 添加索引为0的图片
                listView1.Items.Add(this.sdr["RoomName"].ToString(), 0);
            }
        }
    }
}
