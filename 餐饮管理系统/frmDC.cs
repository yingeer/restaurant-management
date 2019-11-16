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
    
    public partial class frmDC : Form
    {
        public string Rname="大厅-01";
        private string waiterName = "";
        private SqlConnection con;
        public frmDC()
        {
            InitializeComponent();
        }

        private void frmDC_Load(object sender, EventArgs e)
        {
            this.Text = this.Rname + " 点菜";
            con = BaseClass.DBConn.CyCon();
            try
            {
                con.Open();
            }
            catch(Exception)
            {
                MessageBox.Show("数据库连接失败");

            }
            // 添加左侧treeView信息
            try
            {
                string[] foodType = { "锅底", "主食", "配菜", "烟酒" };
                for (int i=0; i<foodType.Length; i++)
                {
                    TreeNode treeNode = treeView1.Nodes[i];
                    string sql = "select * from tb_Food where FoodTy=N'" + foodType[i] +"'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        treeNode.Nodes.Add(sdr["FoodName"].ToString().Trim());
                    }
                    sdr.Close();
                }
                try
                {
                    // 判断桌台状态，空闲则禁用
                    string sql = "select * from tb_Room where RoomName=N'"+this.Rname+"'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    sdr.Read();
                    this.waiterName = sdr["WaiterName"].ToString().Trim();
                    if (sdr["RoomZT"].ToString().Trim() == "空闲")
                    {
                        this.buttonSave.Enabled = false;
                        this.buttonDelete.Enabled = false;
                        MessageBox.Show("此桌台为空闲状态");
                    }
                    sdr.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex+"");
                }
                
                treeView1.ExpandAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show("加载菜品信息失败" + ex);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmDC_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {

            string foodName = "";
            // 在treeView中选择一项
            try
            {
                foodName = treeView1.SelectedNode.Text.ToString().Trim();
            }
            catch(Exception)
            {

            }
            string[] foodType = { "锅底", "主食", "配菜", "烟酒" };
            if (foodType.Contains(foodName))
            {
            }
            else
            {
                // 获得该菜品信息
                string sql = "select * from tb_Food where FoodName=N'"+foodName+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr =  cmd.ExecuteReader();
                while (sdr.Read())
                {
                    // 将信息显示到右侧表单
                    string price = sdr["FoodPrice"].ToString().Trim();
                    this.textPrice.Text = price;
                    this.textName.Text = foodName;
                    this.textWaiterName.Text = this.waiterName;
                    /*this.textAllPrice.Text = (Convert.ToInt32(price) * Convert.ToInt32(this.textNumber.Text)).ToString().Trim();*/

                }
                sdr.Close();
            }
            // 消费菜单编号
            string customID = "1";
            try
            {
                string sql = "select ID from tb_GuestFood where zhuotai=N'"+Rname+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                customID = sdr["ID"].ToString().Trim();

            }
            catch(Exception)
            {
               /* MessageBox.Show("获取消费编号失败;");*/
            }
            finally
            {
                this.textNum.Text = customID;
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dia == DialogResult.OK)
            {
                con.Close();
                this.Close();

            }
        }
    }
}
