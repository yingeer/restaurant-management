﻿using System;
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
    }
}
