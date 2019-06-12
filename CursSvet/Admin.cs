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
            LoadData();
            LoadData1();
            LoadData2();
            LoadData3();
            LoadData4();
            LoadData5();
        }

        private void LoadData()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM Customer ORDER BY ID_customer";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }
        private void LoadData1()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM Furniture ORDER BY ID_furniture";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
        }

        private void LoadData2()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM Order1 ORDER BY ID_order ";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView3.Rows.Add(s);
        }

        private void LoadData3()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM stock ORDER BY ID_stock";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView4.Rows.Add(s);
        }
        private void LoadData4()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM [Authorization]";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView5.Rows.Add(s);
        }
        private void LoadData5()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM Employees";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView6.Rows.Add(s);
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
                    string query = "INSERT INTO Customer (ID_customer,FIO, Address, Phone, ID_employees) VALUES ('" + textBox19.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox18.Text + "')";
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
            Application.Exit();
            con.Close();
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
                    string query = "INSERT INTO Order1 (ID_order, ID_customer, ID_furniture, Data_order, Data_runtime) VALUES ('" + textBox20.Text + "','" + textBox21.Text + "','" + textBox22.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
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
                    string query = "INSERT INTO Furniture (ID_furniture, ID_stock, Title, Price, Amount) VALUES ('" + textBox16.Text + "','" + textBox15.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
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
                    string query = "INSERT INTO Stock (ID_stock, Name_stock, Address, Phone) VALUES ('" + textBox23.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "')";
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
            ChangeCustomer cS = new ChangeCustomer();
            cS.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Customer where ID_customer =" + textBox28.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView2.Rows.Clear();
            LoadData1();
            dataGridView3.Rows.Clear();
            LoadData2();
            dataGridView4.Rows.Clear();
            LoadData3();
            dataGridView5.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView2.Rows.Clear();
            LoadData1();
            dataGridView3.Rows.Clear();
            LoadData2();
            dataGridView4.Rows.Clear();
            LoadData3();
            dataGridView5.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView2.Rows.Clear();
            LoadData1();
            dataGridView3.Rows.Clear();
            LoadData2();
            dataGridView4.Rows.Clear();
            LoadData3();
            dataGridView5.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView2.Rows.Clear();
            LoadData1();
            dataGridView3.Rows.Clear();
            LoadData2();
            dataGridView4.Rows.Clear();
            LoadData3();
            dataGridView5.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "INSERT INTO [Authorization] ([ID_employees], [Login], [Password], [Preffix]) VALUES ('" + textBox17.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')";
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

        private void Button18_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView2.Rows.Clear();
            LoadData1();
            dataGridView3.Rows.Clear();
            LoadData2();
            dataGridView4.Rows.Clear();
            LoadData3();
            dataGridView5.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "INSERT INTO Employees ([ID_employees], [Firstname], [Lastname], [Salary1]) VALUES ('" + textBox24.Text + "','" + textBox25.Text + "','" + textBox26.Text + "','" + textBox27.Text + "')";
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

        private void Button22_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
            dataGridView2.Rows.Clear();
            LoadData1();
            dataGridView3.Rows.Clear();
            LoadData2();
            dataGridView4.Rows.Clear();
            LoadData3();
            dataGridView5.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Furniture where ID_furniture =" + textBox29.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            string query = "DELETE from [Order1] where ID_order =" + textBox30.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Stock where ID_stock =" + textBox31.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            string query = "DELETE from [Authorization] where ID_employees =" + textBox32.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Employees where ID_employees =" + textBox32.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ChangeFurniture cS = new ChangeFurniture();
            cS.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ChangeOrder cS = new ChangeOrder();
            cS.ShowDialog();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            ChangeStock cS = new ChangeStock();
            cS.ShowDialog();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            ChangeEmployees cS = new ChangeEmployees();
            cS.ShowDialog();
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                if (dataGridView3[1, i].Value.ToString() != textBox34.Text)
                {
                    dataGridView3.Rows.RemoveAt(i);
                    i--;

                }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                if (dataGridView2[2, i].Value.ToString() != textBox34.Text)
                {
                    dataGridView2.Rows.RemoveAt(i);
                    i--;

                }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                if (dataGridView1[1, i].Value.ToString() != textBox34.Text)
                {
                    dataGridView1.Rows.RemoveAt(i);
                    i--;

                }
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
                if (dataGridView4[2, i].Value.ToString() != textBox34.Text)
                {
                    dataGridView4.Rows.RemoveAt(i);
                    i--;

                }
        }
        
        private void Button24_Click(object sender, EventArgs e)
        {
            Pechat cS = new Pechat();
            cS.ShowDialog();
        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
