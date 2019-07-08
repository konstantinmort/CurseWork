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
    public partial class AddArenda : Form
    {
        static String connect = "Provider=Microsoft.Jet.OLEDB.4.0;data source=Jobless.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        OleDbCommand command;
        OleDbDataReader reader;
        string query;
        public AddArenda()
        {
            InitializeComponent();
            con.Open();
            try
            {
                comboBox1.Items.Clear();
                string query = "SELECT [ArendaPID] FROM ArendaP ORDER BY [ArendaPID]";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0]);
                }

                comboBox2.Items.Clear();
                query = "SELECT [ClientID] FROM Client ORDER BY [ClientID]";
                command = new OleDbCommand(query, con);
                reader = command.ExecuteReader();
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

        private void Addbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO [ArendaP] ([TTID], [ClientID]," +
                    "[DateNach], [DateKon]) VALUES ('" + comboBox1.Text + "'," +
                    "'" + comboBox2.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "')";
                command = new OleDbCommand(query, con);
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
    }
}
