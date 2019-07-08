using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovoyProect
{
    public partial class ChangeJobless : Form
    {
        private static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=Jobless.mdb";
        private OleDbConnection con = new OleDbConnection(connect);

        public ChangeJobless()
        {
            InitializeComponent();
            con.Open();

            try
            {
                comboBox1.Items.Clear();
                string query = "SELECT [ArendaPID] FROM ArendaP";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0]);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            try
            {
                comboBox3.Items.Clear();
                string query = "SELECT [TTID] FROM [Zero]";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox3.Items.Add(reader[0]);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            try
            {
                comboBox2.Items.Clear();
                string query = "SELECT [ClientID] FROM Client";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add(reader[0]);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void SaveChangebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE ArendaP SET [TTID] ='" + comboBox2.SelectedItem + "'," +
                               "[ClientID] ='" + comboBox3.SelectedItem + "'," +
                               "[DateNach] ='" + dateTimePicker1.Value + "'," +
                               "[DateKon] ='" + dateTimePicker2.Value + "'," +
                               "WHERE [ArendaPID] = " + comboBox1.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение успешно выполнено");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        
        private void CancelButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PasporttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void NumberChangetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void IDChangecomboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT ArendaPID, [TTID], [ClientID], [DateNach], [DateKon], FROM [ArendaP]" +
                    "WHERE [ArendaPID] =" + comboBox1.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.SelectedItem = reader[1].ToString();
                    comboBox3.SelectedItem = reader[2].ToString();
                    dateTimePicker1.Text = reader[3].ToString();
                    dateTimePicker2.Text = reader[4].ToString();

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

        private void IDChangecomboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
