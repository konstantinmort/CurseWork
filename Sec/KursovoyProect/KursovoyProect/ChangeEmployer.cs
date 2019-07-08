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
    public partial class ChangeEmployer : Form
    {
        private static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=Jobless.mdb";
        private OleDbConnection con = new OleDbConnection(connect);
        public ChangeEmployer()
        {
            InitializeComponent();
            con.Open();
            try
            {
                IDChangecomboBox4.Items.Clear();
                string query = "SELECT [ClientID] FROM Client ORDER BY [ClientID]";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IDChangecomboBox4.Items.Add(reader[0]);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
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

        private void SaveChangebutton4_Click(object sender, EventArgs e)
        {
            string enterprice, spec, adres, number, password;
            try
            {
                enterprice = enterpricetextBox4.Text;
                spec = spectextBox4.Text;
                number = numbertextBox4.Text;
                adres = adrestextBox4.Text;
                password = textBox1.Text;

                string query = "UPDATE Client SET [Title] ='" + enterprice + "'," +
                               "[Recvi] ='" + spec + "'," +
                               "[Address] ='" + adres + "'," +
                               "[Numder] ='" + number + "'," +
                               "[KonFace] ='" + password + "'" +
                               "WHERE [ClientID] =" + IDChangecomboBox4.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение успешно выполнено");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            Close();
        }

        private void IDChangecomboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Client WHERE [ClientID] =" + IDChangecomboBox4.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    enterpricetextBox4.Text = reader[1].ToString();
                    spectextBox4.Text = reader[2].ToString();
                    numbertextBox4.Text = reader[3].ToString();
                    adrestextBox4.Text = reader[4].ToString();
                    textBox1.Text = reader[5].ToString();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NumbertextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void IDChangecomboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
