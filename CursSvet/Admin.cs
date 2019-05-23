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
    public partial class Admin : Form
    { 
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Furniture1.mdb";
    OleDbConnection con = new OleDbConnection(connect);
    
        public Admin()
        {
        InitializeComponent();
        con.Open();
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {
  

        }

        private void DataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "INSERT INTO Customer (FIO, Address, Phone) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                    OleDbCommand command = new OleDbCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавление успешно выполнено");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Dispose();
        }

        private void FurnitureBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void ФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "INSERT INTO Order (Data_order, Data_runtime) VALUES ('" + textBox7.Text + "','" + textBox8.Text + "')";
                    OleDbCommand command = new OleDbCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавление успешно выполнено");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "INSERT INTO Furniture (Title, Price, Amount) VALUES ('" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                    OleDbCommand command = new OleDbCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавление успешно выполнено");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "INSERT INTO Stock (Name_stock, Address, Phone) VALUES ('" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";
                    OleDbCommand command = new OleDbCommand(query, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавление успешно выполнено");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ПечатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeCustomer cS = new ChangeCustomer();
            cS.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }
    }
}
