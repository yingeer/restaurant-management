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
using System.Collections;

namespace MrCy
{
    public partial class frmJZ : Form
    {
        public string Rname="大厅-01";
        public SQLiteConnection con;
        public float sum = 0;
        /*  功能分析
         *  根据Rname 最大zhangdanID做查询，查出消费记录
         *  左侧显示消费记录dataGridView    右侧显示总消费,收银，找零，微信，支付宝
             */
        public frmJZ()
        {
            InitializeComponent();
        }
        
        private void frmJZ_Load(object sender, EventArgs e)
        {
            // 连接数据库
            con = BaseClass.DBConn.CyCon();
            con.Open();
            //显示左侧消费记录
            string customID = "";
            string sql = "select max(zhangdanID) as customID from tb_GuestFood where zhuotai='"+Rname+"'";
            try
            {
                SQLiteDataReader sdr = getReader(sql);
                sdr.Read();
                customID = sdr["customID"].ToString().Trim();
                sdr.Close();
            }
            catch
            {
                MessageBox.Show("该桌台此次账单号查询失败");
            }
            try
            {
                sql = "select foodname, foodsum, foodallprice, waitername, zhuotai from tb_GuestFood where zhangdanID=" + int.Parse(customID);
                getDataToGridView(sql);
            }
            catch (Exception)
            {
                MessageBox.Show("未消费");
            }
            

            // 计算消费总额
            ArrayList priceList = new ArrayList();//实例化集合
            try
            {
                SQLiteDataReader sdr = getReader(sql);
                while (sdr.Read())
                {
                    float p = float.Parse(sdr["foodallprice"].ToString().Trim());
                    priceList.Add(p);
                }
                sdr.Close();
                float sum=0;
                foreach (float each in priceList)
                {
                    sum += each;
                }
                this.labelconsume.Text = sum.ToString().Trim();
                this.sum = sum;
            }
            catch(Exception ex)
            {
                MessageBox.Show("消费总额查询失败"+ ex);
            }
         
        }

        private void getDataToGridView(string sql)
        {
            SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private SQLiteDataReader getReader(string sql)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        private void buttonJZ_Click(object sender, EventArgs e)
        {
            // 输入收银，找零
            if (labelRest.Text == "")
            {
                MessageBox.Show("请输入收款金额");
            }

            /*else if (float.Parse(labelRest.Text.ToString().Trim()) - this.sum < 0)
            {
                MessageBox.Show("收款金额小于消费金额");
            }*/
            try
            {
                float money = float.Parse(textBox1.Text.Trim());
                labelRest.Text = (money - this.sum).ToString().Trim();
            }
            catch(Exception)
            {

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PayWay.WeiXinPay pay = new PayWay.WeiXinPay();
            pay.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PayWay.ZhiFuBaoPay pay = new PayWay.ZhiFuBaoPay();
            pay.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                this.textBox1.Text = "";
                MessageBox.Show("请输入数字");
            }
        }

        private void frmJZ_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }
    }
}
