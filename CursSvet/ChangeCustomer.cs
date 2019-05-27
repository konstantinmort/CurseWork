using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CursSvet
{
    public partial class ChangeCustomer : Form
    {
 
        public ChangeCustomer()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin S = new Admin();
            S.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //OleDbConnection con = new OleDbConnection ("Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Furniture1.mdb");
            //con.Open();

            //OleDbDataAdapter da = new OleDbDataAdapter("select * from Customer", con);
            //OleDbCommandBuilder cb = new OleDbCommandBuilder(da);

            //DataSet ds = new DataSet();
            //da.Fill(ds, "Customer");
          
            //ds.Tables[0].Rows[textBox5]["FIO"] = textBox1;
            //ds.Tables[0].Rows[textBox5]["Address"] = textBox2;
            //ds.Tables[0].Rows[textBox5]["Phone"] = textBox3;
            //ds.Tables[0].Rows[textBox5]["ID_customer"] = textBox4;

            //da.Update(ds, "Customer");
            //con.Close();
        }
    }
}
