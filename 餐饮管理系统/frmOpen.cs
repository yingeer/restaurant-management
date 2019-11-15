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
    public partial class frmOpen : Form
    {
        public string Rname;
        private SqlConnection con;
        public frmOpen()
        {
            InitializeComponent();
        }

        private void frmOpen_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mrCyDataSet.tb_Waiter”中。您可以根据需要移动或删除它。
            this.tb_WaiterTableAdapter.Fill(this.mrCyDataSet.tb_Waiter);
            // TODO: 这行代码将数据加载到表“mrCyDataSet.tb_Room”中。您可以根据需要移动或删除它。
            this.tb_RoomTableAdapter.Fill(this.mrCyDataSet.tb_Room);

            // 数据库连接
            this.con = BaseClass.DBConn.CyCon();
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接失败" + ex);
            }
            // 传给表单值
            textRname.Text = this.Rname;
        }

        private void comboNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textCustomerNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar !=8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            DialogResult dia = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dia == DialogResult.OK)
            {
                this.Close();
                
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 表单数据验证
                string RoomName = this.Rname;
                string GuestName = this.textCustomerName.Text;
                string WaiterName = this.comboWaiter.SelectedItem.ToString();
                string RoomBZ = this.textBZ.Text;
                string zhangdanDate = this.dateTimePicker1.Value.ToString();
                if (this.textCustomerNum.Text == "")
                {
                    MessageBox.Show("请输入用餐人数");
                }
                
                int customerNum = Convert.ToInt32(this.textCustomerNum.Text); 
                    
                // 存入tb_Room表
                string sql = "update tb_Room set "+ 
                    "GuestName=N'"+ GuestName+"', "+"WaiterName=N'"+WaiterName+"', "+"RoomBZ=N'"+RoomBZ+"', "+
                    "zhangdanDate=N'" +zhangdanDate+ "', " + "Num="+customerNum+ " ,RoomZT=N'使用'"+
                    " where RoomName=N'"+RoomName+"'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("数据插入成功");

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作失败"+ex);
            }
           /* finally
            {
                this.con.Close();
            }*/
        }
    }
}
