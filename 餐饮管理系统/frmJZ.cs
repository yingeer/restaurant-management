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
    public partial class frmJZ : Form
    {
        public string Rname;
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

        }
    }
}
