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

    public partial class frmDC : Form
    {
        public string Rname = "大厅-01";
        /*private string waiterName = "";*/
        private string curPrice = "";
        private string customID = "1";
        private string menuNum = "0";

        public frmDC()
        {
            InitializeComponent();
        }

        private void frmDC_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dataSet1.tb_Waiter”中。您可以根据需要移动或删除它。
            this.tb_WaiterTableAdapter.Fill(this.dataSet1.tb_Waiter);
            this.Text = this.Rname + " 点菜";
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
            // 添加左侧treeView信息
            try
            {
                string[] foodType = { "锅底", "主食", "配菜", "烟酒" };
                for (int i = 0; i < foodType.Length; i++)
                {
                    TreeNode treeNode = treeView1.Nodes[i];
                    string sql = "select * from tb_Food where FoodTy='" + foodType[i] + "'";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    SQLiteDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        treeNode.Nodes.Add(sdr["FoodName"].ToString().Trim());
                    }
                    sdr.Close();
                }
                
                treeView1.ExpandAll();
            }
            catch (Exception )
            {
                MessageBox.Show("加载菜品信息失败" );
            }
            con.Close();
            // 判断桌台状态，空闲则禁用
            jdugeTableState();
            // 设置CustomerID
            string customID = getCurCustomID();
            this.toolStripStatusLabel2.Text = customID;
            this.customID = customID;
            this.textNum.Text = "1";

        }
        private void jdugeTableState()
        {
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
            try
            {
                // 判断桌台状态，空闲则禁用
                string sql = "select * from tb_Room where RoomName='" + this.Rname + "'";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                SQLiteDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                /*this.waiterName = sdr["WaiterName"].ToString().Trim();*/

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
            finally
            {
                con.Close();
            }

        }


        private string getCurCustomID()
        {
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
            // 消费编号
            string customID = "1";

            string sql = "select max(zhangdanID) as customID from tb_GuestFood";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader sdr = cmd.ExecuteReader();
            try { 
                sdr.Read();
                customID = (int.Parse(sdr["customID"].ToString().Trim()) + 1).ToString();
                
            }
            catch (Exception)
            {
                
                /*MessageBox.Show("获取消费编号失败;");*/
            }
            finally
            {
                sdr.Close();
                con.Close();
            }

            return customID;
           
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void frmDC_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           /* //如果点击菜品后，没有这道菜，那就禁用右键查看供能
            string foodName = treeView1.SelectedNode.Text.ToString().Trim();
            if (!this.isAddToMenu(foodName))
            {
                this.contextMenuStrip1.Items[1].Enabled = false;
            }*/
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
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
                    string sql = "select * from tb_Food where FoodName='" + foodName + "'";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    SQLiteDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {

                        // 将信息显示到右侧表单
                        string price = sdr["FoodPrice"].ToString().Trim();
                        this.textPrice.Text = price; // 该food单个价格
                        this.curPrice = price; //传给this.curPrice,给计算按钮用
                        this.textName.Text = foodName;
                        /*this.textWaiterName.Text = this.textName.Text.ToString().Trim();*/
                        this.textNumber.Text = "1";
                        this.textAllPrice.Text = "0"; // 每次双击清零
                    }
                    sdr.Close();
                }
            con.Close();
            
        }

        private void addMenuNum()
        {
            this.menuNum = (int.Parse(this.menuNum) + 1).ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            
            DialogResult dia = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dia == DialogResult.OK)
            {
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
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
            int nextMenuID = getIDOfMenu() + 1;
            
            try
            {    
                string sql = "insert into tb_GuestFood (ID, foodname, foodsum, foodallprice, waitername, beizhu, zhuotai, zhangdanID) " +
                    "values (" +
                    nextMenuID + ", '" + this.textName.Text +
                "'," + int.Parse(this.textNumber.Text) + "," + float.Parse(this.textAllPrice.Text) +
                ", '" + this.comboWaiter.SelectedItem.ToString().Trim() + "', '" + this.textBZ.Text +
                "', '" + this.Rname + "', " + int.Parse(this.customID) +
               ")";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("保存成功");
            } 
            catch (Exception ex)
            {
                MessageBox.Show("请不要保存点菜号相同的菜品" + ex);
            }
            finally
            {
                con.Close();
            }

            // 菜单编号 +1
            this.addMenuNum();
            this.textNum.Text = this.menuNum;

            // 刷新dataGridView
            this.getData();

        }

        private int getIDOfMenu()
        {
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
            int IDNum = 0;
            string sql = "select count(ID) as total from tb_GuestFood";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader sdr = cmd.ExecuteReader();
            try
            {
                sdr.Read();
                IDNum = int.Parse(sdr["total"].ToString().Trim());
            }
            catch (Exception)
            {

                MessageBox.Show("获取消费编号失败;");
            }
            finally
            {
                sdr.Close();
                con.Close();
            }
            return IDNum;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string foodName = dataGridView1.SelectedCells[0].Value.ToString();
                string sql = "delete from tb_GuestFood where foodname='"+foodName+"' and zhangdanID="+int.Parse(this.customID) ;
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                int rows = cmd.ExecuteNonQuery();
                if (rows <= 0)
                {
                    MessageBox.Show("删除数据失败");
                }
            }
            else
            {
                MessageBox.Show("请选择消费的菜品");
            }
            con.Close();
            getData();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            
        }

        private SQLiteDataReader queryFoodInThisCustom(string foodName, SQLiteConnection con)
        {
            string sql = "select * from tb_GuestFood where foodname='" + foodName + "' and " + "zhangdanID=" + int.Parse(this.customID);
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                SQLiteDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                return sdr;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Nodes.Count == 0)
                {
                    this.treeView1_DoubleClick(sender, e);
                }
                else
                {
                    MessageBox.Show("请选择菜品");
                }
            }
            catch
            {

            }
        }
     /*   private bool isAddToMenu(string foodname)
        {
            try
            {
                SQLiteDataReader sdr = queryFoodInThisCustom(foodname);
                string jduge = sdr["foodname"].ToString();
                return true;
            }
            catch (System.InvalidOperationException)
            {
                return false;
            }
        

        }*/
        private void 查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
            string foodName = "";
           
            if (treeView1.SelectedNode.Nodes.Count == 0)
            {
                foodName = treeView1.SelectedNode.Text.ToString().Trim();
                try
                {
                    
                    SQLiteDataReader sdr = queryFoodInThisCustom(foodName, con);
                    
                    // 展现数据
                    this.textAllPrice.Text = sdr["foodallprice"].ToString().Trim();
                    this.textBZ.Text = sdr["beizhu"].ToString().Trim();
                    this.textNumber.Text = sdr["foodsum"].ToString().Trim();
                    this.textName.Text = sdr["foodname"].ToString().Trim();
                    this.textAllPrice.Text = sdr["foodallprice"].ToString().Trim();

                    sdr.Close();
                }
                catch(Exception)
                {

                    MessageBox.Show("该菜品没有下单");

                }

            }
            else
            {
                    MessageBox.Show("请选择菜品");
            }
            con.Close();


        }

        private void getData()
        {
            SQLiteConnection con = BaseClass.DBConn.CyCon();
            con.Open();
            string sql = "select foodname, foodsum, foodallprice, beizhu, zhuotai, zhangdanID from tb_GuestFood where zhangdanID=" + int.Parse(this.customID);
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}

