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

namespace KursProject
{
    public partial class EditCon : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Database.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        public EditCon()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            con.Open();

            try
            {
                comboBox1.Items.Clear();
                string query = "SELECT ID_contract FROM Contract";
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
                comboBox2.Items.Clear();
                string query = "SELECT ID_view FROM TypesOfInsurance";
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

            try
            {
                comboBox3.Items.Clear();
                string query = "SELECT ID_customers FROM Customers";
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
                comboBox4.Items.Clear();
                string query = "SELECT ID_employees FROM Employees";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox4.Items.Add(reader[0]);
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            { 
                try
                { 
            string query = "UPDATE Contract SET [ID_view]='" + comboBox2.Text + "',[ID_customer]='" + comboBox3.Text + "',[ID_employees]='" + comboBox4.Text + "',[InsuranceType]='" + textBox4.Text + "',[ConclusionDate]='" + textBox5.Text + "',[Branch]='" + textBox6.Text + "' WHERE ID_contract=" + comboBox1.Text;

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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCon_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT ID_contract, [ID_view], [ID_customer]," +
                    " [ID_employees], [InsuranceType], [ConclusionDate], [Branch] FROM Contract WHERE ID_contract =" + comboBox1.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Text = reader[1].ToString();
                    comboBox3.Text = reader[2].ToString();
                    comboBox4.Text = reader[3].ToString();
                    textBox4.Text = reader[4].ToString();
                    textBox5.Text = reader[5].ToString();
                    textBox6.Text = reader[6].ToString();

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
