using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovoyProect
{
    public partial class AddEmployer : Form
    {
        static String connect = "Provider=Microsoft.Jet.OLEDB.4.0;data source=Jobless.mdb";
        OleDbConnection con = new OleDbConnection(connect);

        public AddEmployer()
        {
            InitializeComponent();
            con.Open();
        }

        private void Addbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Client ([Title], [Recvi], [Address], [Number], [KontFace]) VALUES ('" + enterpricetextBox4.Text + "','" + numbertextBox4.Text + "','" + spectextBox4.Text + "','" + adrestextBox4.Text + "','" + textBox1.Text + "')";
                OleDbCommand command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление выполнено!");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            enterpricetextBox4.Clear();
            adrestextBox4.Clear();
            spectextBox4.Clear();
            numbertextBox4.Clear();
        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NumbertextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
