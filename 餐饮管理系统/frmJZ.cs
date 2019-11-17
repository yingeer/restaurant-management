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
    public partial class frmJZ : Form
    {
        public string Rname="大厅-01";
        public SqlConnection con;
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
            //显示左侧消费记录，计算消费总额


        }

        private void buttonJZ_Click(object sender, EventArgs e)
        {
            // 输入收银，找零
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
    }
}
