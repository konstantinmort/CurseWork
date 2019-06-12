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

    public partial class Pechat : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Furniture1.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        public Pechat()
        {
            con.Open();
            InitializeComponent();
            string query;
            OleDbCommand command;
            OleDbDataReader reader;

            query = "SELECT [Title] FROM Furniture";
            command = new OleDbCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox4.Items.Add(reader[0]);
            }

            query = "SELECT [Price] FROM Furniture";
            command = new OleDbCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0]);
            }

            query = "SELECT Lastname FROM [Employees]";
            command = new OleDbCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }

            query = "SELECT [Name_stock] FROM [Stock]";
            command = new OleDbCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox5.Items.Add(reader[0]);
            }

            query = "SELECT [FIO] FROM [Customer]";
            command = new OleDbCommand(query, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox3.Items.Add(reader[0]);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string post = comboBox5.SelectedItem.ToString();
            string prep = comboBox4.SelectedItem.ToString();
            string prep1 = comboBox3.SelectedItem.ToString();
            string cat = comboBox1.SelectedItem.ToString();
            string col = numericUpDown1.Value.ToString();
            string sum = comboBox2.SelectedItem.ToString();

            dobav cS = new dobav();
            cS.label5.Text = prep1;
            cS.label6.Text = cat;
            cS.label9.Text = prep;
            cS.label11.Text = sum.ToString() + " р";
            cS.label18.Text = post;
            cS.label19.Text = col;
            cS.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
