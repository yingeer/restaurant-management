using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrCy
{
    public partial class frmQxGl : Form
    {
        public frmQxGl()
        {
            InitializeComponent();
        }

        private void frmQxGl_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“mrCyDataSet.tb_User”中。您可以根据需要移动或删除它。
            this.tb_UserTableAdapter.Fill(this.mrCyDataSet.tb_User);

        }
    }
}
