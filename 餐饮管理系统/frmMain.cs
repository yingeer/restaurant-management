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
    public partial class frmMain : Form
    {
        public SQLiteDataReader sdr;
        // 从login接收
        public string power = "0"; // 登录用户权限
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
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            try
            {
                con.Open();
                
                string sql = "select * from tb_Room";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
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
                sdr.Close();
                con.Close();
            }

        }

        private void AddItems(string rzt)
        {
            // AddItem方法为ListView1控件添加项目
            if (rzt == "使用")
            {
                // 使用状态的话添加索引为1的图片
                listView1.Items.Add(this.sdr["RoomName"].ToString() + "\n" + this.sdr["RoomZT"].ToString(), 0);
            } else
            {
                // 添加索引为0的图片
                listView1.Items.Add(this.sdr["RoomName"].ToString() + "\n" + this.sdr["RoomZT"].ToString(), 1);
            }
        }

        private void 基础信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 桌台信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDesk desk = new frmDesk();
            desk.ShowDialog();
        }

        private void 职员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser users = new frmUser();
            users.ShowDialog();
        }

        private void 权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQxGl qx = new frmQxGl();
            qx.ShowDialog();
        }

        private void 系统备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBF bf = new frmBF();
            bf.ShowDialog();
        }

        private void 系统恢复ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHF hf = new frmHF();
            hf.ShowDialog();
        }

        private void 口令设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPWD pwd = new frmPWD();
            pwd.ShowDialog();

        }

        private void 系统锁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLock lockSystem = new frmLock();
            lockSystem.ShowDialog();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string roomName = listView1.SelectedItems[0].SubItems[0].Text.Substring(0, 5);
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库链接失败");
            }
            
            try
            {
                string sql = "select * from tb_Room where RoomName='" + roomName + "'";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                this.sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    // 右键 contextMenuStrip的显示控制
                    string roomZT = sdr["RoomZT"].ToString().Trim();
                    if (roomZT == "使用")
                    {
                        this.contextMenuStrip1.Items[0].Enabled = false;
                        this.contextMenuStrip1.Items[1].Enabled = true;
                        this.contextMenuStrip1.Items[2].Enabled = true;
                        this.contextMenuStrip1.Items[3].Enabled = true;
                        this.contextMenuStrip1.Items[4].Enabled = true;
                    } 
                    else
                    {
                        this.contextMenuStrip1.Items[0].Enabled = true;
                        this.contextMenuStrip1.Items[1].Enabled = false;
                        this.contextMenuStrip1.Items[2].Enabled = false;
                        this.contextMenuStrip1.Items[3].Enabled = false;
                        this.contextMenuStrip1.Items[4].Enabled = false;
                    }
                }
                sdr.Close();
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
        
        private void 开台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string name = listView1.SelectedItems[0].SubItems[0].Text.Substring(0, 5);
                frmOpen openRoom = new frmOpen();
                openRoom.Rname = name;
                openRoom.ShowDialog();
            } 
            else
            {
                MessageBox.Show("请选择桌台");
            }
        }

        private void 取消开台ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                // 取消开台，更改tb_Room的RoomZT，删除tb_GuestFood这条记录
                string name = listView1.SelectedItems[0].SubItems[0].Text.Substring(0, 5);
                SQLiteConnection con = BaseClass.DBConn.CyCon();
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("数据库链接失败");
                }
                try
                {
                    string sql = "update tb_Room  set  RoomZT='空闲', Num=0 where RoomName='" + name +"'";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("取消开台执行成功");
                    }
                    sql = "delete from tb_GuestFood where zhuotai='"+name+"'";
                    cmd = new SQLiteCommand(sql, con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("取消开台失败"+ex);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("请选择桌台");
            }
        }

        private void 点加菜ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string name = listView1.SelectedItems[0].SubItems[0].Text.Substring(0, 5);
                frmDC frmdc = new frmDC();
                frmdc.Rname = name;
                frmdc.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择桌台");
            }
        }

        private void 消费查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string name = listView1.SelectedItems[0].SubItems[0].Text.Substring(0, 5);
                frmSearch search = new frmSearch();
                search.Rname = name;
                search.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择桌台");
            }
        }

        private void 结账ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                string name = listView1.SelectedItems[0].SubItems[0].Text.Substring(0, 5);
                frmJZ jz = new frmJZ();
                jz.Rname = name;
                jz.ShowDialog();
            }
            else
            {
                MessageBox.Show("请选择桌台");
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
