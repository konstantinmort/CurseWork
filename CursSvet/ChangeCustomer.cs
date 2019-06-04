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
using System.Data.SqlClient;

namespace CursSvet
{
    public partial class ChangeCustomer : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Furniture1.mdb";
        OleDbConnection con = new OleDbConnection(connect);

        public ChangeCustomer()
        {
            InitializeComponent();
            con.Open();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "UPDATE [Customer] SET [FIO]='" + textBox1.Text + "',[Address]='" + textBox2.Text + "',[Phone]='" + textBox3.Text + "',[ID_employees]='" + textBox4.Text + "' WHERE ID_customer=" + textBox5.Text;

                    OleDbCommand command = new OleDbCommand(query, con);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Изменение успешно выполнено");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }
    }
}
