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

        }

        private void comboNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textCustomerNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar !=8 && !char.IsDigit(e.KeyChar)) && e.KeyChar != 13)
            {
                MessageBox.Show("请输入数字");
            }
        }
    }
}
