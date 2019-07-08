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
    public partial class ChangeMen : Form
    {
        private static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=Jobless.mdb";
        private OleDbConnection con = new OleDbConnection(connect);
        public ChangeMen()
        {
            InitializeComponent();
            con.Open();
            try
            {
                comboBox1.Items.Clear();
                string query = "SELECT [EmployeesID] FROM [Avtori] ORDER BY [EmployeesID]";
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
        }

        private void Addbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE [Avtori] SET [FIO] ='" + enterpricetextBox4.Text + "'," +
                               "[Birth] ='" + dateTimePicker1.Value + "'," +
                               "[Login] ='" + spectextBox4.Text + "'," +
                               "[Password] ='" + textBox1.Text + "'," +
                               "[GrantUser] ='" + adrestextBox4.Text + "' WHERE [TTID] = " + comboBox1.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение успешно выполнено");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [Avtori] WHERE [EmployeesID] =" + comboBox1.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    enterpricetextBox4.Text = reader[1].ToString();
                    spectextBox4.Text = reader[3].ToString();
                    textBox1.Text = reader[4].ToString();
                    adrestextBox4.Text = reader[5].ToString();
                }
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
    }
    
}
