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

namespace KursovoyProect
{
    public partial class AddMen : Form
    {
        static String connect = "Provider=Microsoft.Jet.OLEDB.4.0;data source=Jobless.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        public AddMen()
        {
            InitializeComponent();
            con.Open();
        }

        private void Addbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Avtori ([FIO], [Birth], [Login], [Password], [GrantUser]) VALUES ('" + enterpricetextBox4.Text + "','" + dateTimePicker1.Value + "','" + spectextBox4.Text + "','" + adrestextBox4.Text + "','" + textBox1.Text + "')";
                OleDbCommand command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление выполнено!");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
