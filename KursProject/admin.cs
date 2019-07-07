using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace KursProject
{
    public partial class admin : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Database.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        public admin()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            string query = "SELECT * FROM Branch ORDER BY ID_branch";
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
        private void LoadData1()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT Employees.ID_employees, Branch.Title, Employees.Surname, Employees.Name, Employees.MiddleName, " +
                           " Employees.Sex, Employees.Phone FROM Branch INNER JOIN Employees ON Branch.ID_branch = Employees.ID_branch";

            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView4.Rows.Add(s);
        }

        private void LoadData2()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM TypesOfInsurance ORDER BY ID_view ";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void LoadData3()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM [Customers] ORDER BY ID_customers";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView5.Rows.Add(s);
        }
        private void LoadData4()
        {

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT Contract.ID_contract, Customers.PassportSeries, Customers.PassportNomer, Employees.Surname, TypesOfInsurance.TypeName, Branch.Title, Contract.ConclusionDate" +
                           " FROM TypesOfInsurance INNER JOIN((Branch INNER JOIN Employees ON Branch.ID_branch = Employees.ID_branch) " +
                           " INNER JOIN(Customers INNER JOIN Contract ON Customers.ID_customers = Contract.ID_customer) ON Employees.ID_employees = Contract.ID_employees) ON TypesOfInsurance.ID_view = Contract.ID_view";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);
        }
        private void LoadData5()
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
                dataGridView6.Rows.Add(s);
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void AddBranch_Click(object sender, EventArgs e)
        {
            AddBranch cS = new AddBranch();
            cS.ShowDialog();
        }
        private void EditBranch_Click(object sender, EventArgs e)
        {
            EditBranch cS = new EditBranch();
            cS.ShowDialog();
        }

        private void DelBranch_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Branch where ID_branch =" + textDel1.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void AddCust_Click(object sender, EventArgs e)
        {
            AddCust cS = new AddCust();
            cS.ShowDialog();
        }

        private void EditCust_Click(object sender, EventArgs e)
        {
            EditCust cS = new EditCust();
            cS.ShowDialog();
        }

        private void DelCust_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Employees where ID_employees =" + textDel2.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void AddInc_Click(object sender, EventArgs e)
        {
            AddInc cS = new AddInc();
            cS.ShowDialog();
        }

        private void EditInc_Click(object sender, EventArgs e)
        {
            EditInc cS = new EditInc();
            cS.ShowDialog();
        }

        private void DelInc_Click(object sender, EventArgs e)
        {
            string query = "DELETE from TypesOfInsurance where ID_view =" + textDel3.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void AddEmp_Click(object sender, EventArgs e)
        {
            AddEmp cS = new AddEmp();
            cS.ShowDialog();
        }

        private void EditEmp_Click(object sender, EventArgs e)
        {
            EditEmp cS = new EditEmp();
            cS.ShowDialog();
        }

        private void DelEmp_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Customer where ID_customer =" + textDel4.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void AddCon_Click(object sender, EventArgs e)
        {
            AddCon cS = new AddCon();
            cS.ShowDialog();
        }

        private void EditCon_Click(object sender, EventArgs e)
        {
            EditCon cS = new EditCon();
            cS.ShowDialog();
        }

        private void DelCon_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Contract where ID_contract =" + textDel5.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void CreateCust_Click(object sender, EventArgs e)
        {
            CreateCust cS = new CreateCust();
            cS.ShowDialog();
        }

        private void EditCustom_Click(object sender, EventArgs e)
        {
            EditCustom cS = new EditCustom();
            cS.ShowDialog();
        }

        private void DelCustom_Click(object sender, EventArgs e)
        {
            string query = "DELETE from Authorization where ID_employees =" + textDel6.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
        }

        private void DataGridView3_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            LoadData();
            dataGridView4.Rows.Clear();
            LoadData1();
            dataGridView1.Rows.Clear();
            LoadData2();
            dataGridView5.Rows.Clear();
            LoadData3();
            dataGridView2.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void DataGridView4_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            LoadData();
            dataGridView4.Rows.Clear();
            LoadData1();
            dataGridView1.Rows.Clear();
            LoadData2();
            dataGridView5.Rows.Clear();
            LoadData3();
            dataGridView2.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            LoadData();
            dataGridView4.Rows.Clear();
            LoadData1();
            dataGridView1.Rows.Clear();
            LoadData2();
            dataGridView5.Rows.Clear();
            LoadData3();
            dataGridView2.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void DataGridView5_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            LoadData();
            dataGridView4.Rows.Clear();
            LoadData1();
            dataGridView1.Rows.Clear();
            LoadData2();
            dataGridView5.Rows.Clear();
            LoadData3();
            dataGridView2.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void DataGridView2_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            LoadData();
            dataGridView4.Rows.Clear();
            LoadData1();
            dataGridView1.Rows.Clear();
            LoadData2();
            dataGridView5.Rows.Clear();
            LoadData3();
            dataGridView2.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }

        private void DataGridView6_Click(object sender, EventArgs e)
        {
            dataGridView3.Rows.Clear();
            LoadData();
            dataGridView4.Rows.Clear();
            LoadData1();
            dataGridView1.Rows.Clear();
            LoadData2();
            dataGridView5.Rows.Clear();
            LoadData3();
            dataGridView2.Rows.Clear();
            LoadData4();
            dataGridView6.Rows.Clear();
            LoadData5();
        }


        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {


        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        public void SearchData(string search)
        {
        }

        private void PrintPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < dataGridView3.Columns.Count; j++)
                {
                    if (dataGridView3[j, i].Value.ToString() == textBox1.Text)
                    {
                        isVisible = true;
                    }
                }
                dataGridView3.Rows[i].Visible = isVisible;
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value.ToString() == textBox1.Text)
                    {
                        isVisible = true;
                    }
                }
                dataGridView1.Rows[i].Visible = isVisible;
            }
            for (int i = 0; i < dataGridView5.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < dataGridView5.Columns.Count; j++)
                {
                    if (dataGridView5[j, i].Value.ToString() == textBox1.Text)
                    {
                        isVisible = true;
                    }
                }
                dataGridView5.Rows[i].Visible = isVisible;
            }
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    if (dataGridView2[j, i].Value.ToString() == textBox1.Text)
                    {
                        isVisible = true;
                    }
                }
                dataGridView2.Rows[i].Visible = isVisible;
            }
            for (int i = 0; i < dataGridView4.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < dataGridView4.Columns.Count; j++)
                {
                    if (dataGridView4[j, i].Value.ToString() == textBox1.Text)
                    {
                        isVisible = true;
                    }
                }
                dataGridView4.Rows[i].Visible = isVisible;
            }
            for (int i = 0; i < dataGridView6.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < dataGridView6.Columns.Count; j++)
                {
                    if (dataGridView6[j, i].Value.ToString() == textBox1.Text)
                    {
                        isVisible = true;
                    }
                }
                dataGridView6.Rows[i].Visible = isVisible;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Graf cS = new Graf();
            cS.ShowDialog();

        }



        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
