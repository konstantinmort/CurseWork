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
    public partial class AddVacancy : Form
    {
        static String connect = "Provider=Microsoft.Jet.OLEDB.4.0;data source=Jobless.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        OleDbCommand command;
        OleDbDataReader reader;
        string query;

        public AddVacancy()
        {
            InitializeComponent();
            con.Open();
           
        }

        private void Addbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO [Zero] ([Etaj], [S]," +
                    "[Kondic], [SummaVden]) VALUES ('" + vacancytextBox1.Text + "'," +
                    "'" + textBox1.Text + "','" + comboBox1.SelectedItem + "','" + zptextbox.Text + "')";
                command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Добавление выполнено!");
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Cancelbutton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Zp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Lgoti_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Zptextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
