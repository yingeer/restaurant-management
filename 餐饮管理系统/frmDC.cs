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
        public string Rname = "大厅-01";
        private string waiterName = "";
        private SqlConnection con;
        private string curPrice = "";
        private string customID = "1";
        public frmDC()
        {
            InitializeComponent();
        }

        private void frmDC_Load(object sender, EventArgs e)
        {

            // TODO: 这行代码将数据加载到表“mrCyDataSet.tb_GuestFood”中。您可以根据需要移动或删除它。
            this.tb_GuestFoodTableAdapter.Fill(this.mrCyDataSet.tb_GuestFood);
            this.Text = this.Rname + " 点菜";
            con = BaseClass.DBConn.CyCon();
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库连接失败");

            }
            // 添加左侧treeView信息
            try
            {
                string[] foodType = { "锅底", "主食", "配菜", "烟酒" };
                for (int i = 0; i < foodType.Length; i++)
                {
                    TreeNode treeNode = treeView1.Nodes[i];
                    string sql = "select * from tb_Food where FoodTy=N'" + foodType[i] + "'";
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
                    string sql = "select * from tb_Room where RoomName=N'" + this.Rname + "'";
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }

                treeView1.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("加载菜品信息失败" + ex);
            }

            // 消费编号
            string customID = "1";

            try
            {
                string sql = "select max(zhangdanID) as customID from tb_GuestFood";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                 
                sdr.Read();
                customID = (int.Parse(sdr["customID"].ToString().Trim())+1).ToString();
                sdr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("获取消费编号失败;");
            }
            finally
            {
                this.toolStripStatusLabel2.Text = customID;
                this.customID = customID;
             
            }
        }

        private void label4_Click(object sender, EventArgs e)
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
            // 在treeView中选择一项, 防止乱双击
            try
            {
                foodName = treeView1.SelectedNode.Text.ToString().Trim();
            }
            catch (Exception)
            {
            }

            string[] foodType = { "锅底", "主食", "配菜", "烟酒" };
            // 点到foodtype就跳过
            if (foodType.Contains(foodName))
            {
            }
            else
            {
                // 获得该菜品信息
                string sql = "select * from tb_Food where FoodName=N'" + foodName + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {

                    // 将信息显示到右侧表单
                    string price = sdr["FoodPrice"].ToString().Trim();
                    this.textPrice.Text = price; // 该food单个价格
                    this.curPrice = price; //传给this.curPrice,给计算按钮用
                    this.textName.Text = foodName;
                    this.textWaiterName.Text = this.waiterName;
                    this.textNumber.Text = "1";

                }
                sdr.Close();
            }
            // 点菜编号
            string itemNum = "1";
            try
            {
                string sql = "select count(ID) as curNum from tb_GuestFood where zhangdanID=N'"+this.customID+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                itemNum = (int.Parse(sdr["curNum"].ToString().Trim()) + 1).ToString();
                sdr.Close();
            }
            catch (Exception)
            {
                /* MessageBox.Show("获取失败;");*/
            }
            finally
            {
                this.textNum.Text = itemNum;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textNumber.Text == "")
            {
                this.textNumber.Text = "1";
                MessageBox.Show("请输入消费数量");
            }
            if (this.textPrice.Text == "")
            {
                this.textPrice.Text = this.curPrice;
            }
            // 该商品此次消费总价
            this.textAllPrice.Text = (double.Parse(this.curPrice) * int.Parse(this.textNumber.Text)).ToString();
        }
    }
}
