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

namespace CursSvet
{
    public partial class ChangeCustomer : Form
    {
        //static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Furniture1.mdb";
        //OleDbConnection con = new OleDbConnection(connect);
        //OleDbCommand command;
        //OleDbDataReader reader;
        //string query;
        public ChangeCustomer()
        {
            //InitializeComponent();
            //con.Open();

            //query = "SELECT ID_Customer FROM Customer";
            //command = new OleDbCommand(query, con);
            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    comboBox1.Items.Add(reader[0]);
            //}

            //query = "SELECT NameFilm FROM Films";
            //command = new OleDbCommand(query, con);
            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    comboBox2.Items.Add(reader[0]);
            //}

            //query = "SELECT HallName FROM Hall";
            //command = new OleDbCommand(query, con);
            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    comboBox3.Items.Add(reader[0]);
            //}
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin S = new Admin();
            S.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //string ID, Date, Film, Price, Hall;
            //try
            //{
            //    Film = comboBox2.SelectedItem.ToString();
            //    query = "SELECT ID_Films FROM Films WHERE NameFilm ='" + Film + "'";
            //    command = new OleDbCommand(query, con);
            //    Film = command.ExecuteScalar().ToString();

            //    Hall = comboBox3.SelectedItem.ToString();
            //    query = "SELECT ID_Hall FROM Hall WHERE HallName ='" + Hall + "'";
            //    command = new OleDbCommand(query, con);
            //    Hall = command.ExecuteScalar().ToString();

            //    ID = comboBox1.SelectedItem.ToString();
            //    Price = textBox4.Text;
            //    Date = dateTimePicker1.Value.ToString();
            //    Date = Date.Replace(".", "/");
            //    query = "UPDATE SessionFilm SET Films= '" + Film + "'," +
            //                   "Hall = '" + Hall + "'," +
            //                   "Data = #" + Date + "#," +
            //                   "Price = '" + Price + "' WHERE ID_SessionFilm = " + ID;
            //    command = new OleDbCommand(query, con);
            //    command.ExecuteNonQuery();
            //}
            //catch (Exception)
            //{
            //}
        }
    }
}
