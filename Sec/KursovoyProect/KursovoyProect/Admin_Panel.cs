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
using System.Threading;

namespace KursovoyProect
{
    public partial class Admin_panel : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=Jobless.mdb";
        OleDbConnection con = new OleDbConnection(connect);

        public Admin_panel()
        {
            InitializeComponent();
            ZapolnenieDTG();
            VacancyDTG();
            SpecDTG();
            Spec1DTG();
            con.Open();
        }

        private void Admin_panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            con.Close();
            Application.Exit();
        }

        private void Searchbutton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Jobless_datagrid.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < Jobless_datagrid.Columns.Count; j++)
                {
                    if (Jobless_datagrid[j, i].Value.ToString() == searchtextBox1.Text)
                    {
                        isVisible = true;
                    }
                }
                Jobless_datagrid.Rows[i].Visible = isVisible;
            }

        }

        private void ZapolnenieDTG()
        {
            Jobless_datagrid.Rows.Clear();

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * from Client";
            OleDbCommand command = new OleDbCommand(query, con);

            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0]  = reader[0].ToString();
                data[data.Count - 1][1]  = reader[1].ToString();
                data[data.Count - 1][2]  = reader[2].ToString();
                data[data.Count - 1][3]  = reader[3].ToString();
                data[data.Count - 1][4]  = reader[4].ToString();
                data[data.Count - 1][5]  = reader[5].ToString();     
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                Jobless_datagrid.Rows.Add(s);
        }


        int indexRows = 0;

        private void Jobless_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRows = e.RowIndex;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Workdatagrid.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < Workdatagrid.Columns.Count; j++)
                {
                    if (Workdatagrid[j, i].Value.ToString() == SearchtextBox2.Text)
                    {
                        isVisible = true;
                    }
                }
                Workdatagrid.Rows[i].Visible = isVisible;
            }
        }

        private void Addbutton2_Click(object sender, EventArgs e)
        {
            AddVacancy av = new AddVacancy();
            av.ShowDialog();
        }

        private void VacancyDTG()
        {
            Workdatagrid.Rows.Clear();

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * from Avtori";
            OleDbCommand command = new OleDbCommand(query, con);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            con.Close();

            foreach (string[] s in data)
                Workdatagrid.Rows.Add(s);
        }

        private void Updatebutton2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            VacancyDTG();
        }

        private void Workdatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRows = e.RowIndex;
        }

        private void Changebutton2_Click(object sender, EventArgs e)
        {
            ChangeVacancy cv = new ChangeVacancy();
            cv.ShowDialog();
        }

        private void SpecDTG()
        {
            Specialydatagrid.Rows.Clear();

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT * FROM [Zero]";
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
                Specialydatagrid.Rows.Add(s);
        }
        private void Spec1DTG()
        {
            dataGridView1.Rows.Clear();

            OleDbConnection con = new OleDbConnection(connect);
            con.Open();
            string query = "SELECT ArendaP.ArendaPID, ArendaP.TTID, Client.Title, ArendaP.DateNach, ArendaP.DateKon, " +
                "[ArendaP]![DateKon]-[ArendaP]![DateNach], [Zero]![SummaVden]*([ArendaP]![DateKon]-[ArendaP]![DateNach])" +
                " FROM Zero INNER JOIN(Client INNER JOIN ArendaP ON Client.ClientID = ArendaP.ClientID) ON Zero.TTID = ArendaP.TTID";
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

        private void Specialydatagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRows = e.RowIndex;
        }

        private void Updatebutton4_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            SpecDTG();
        }
        private void Searchbutton3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Specialydatagrid.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < Specialydatagrid.Columns.Count; j++)
                {
                    if (Specialydatagrid[j, i].Value.ToString() == SearchtextBox3.Text)
                    {
                        isVisible = true;
                    }
                }
                Specialydatagrid.Rows[i].Visible = isVisible;
            }
        }

        private void Searchlabel1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Admin_panel_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            Spec1DTG();
        }

        private void Admin_panel_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                bool isVisible = false;
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (Specialydatagrid[j, i].Value.ToString() == textBox1.Text)
                    {
                        isVisible = true;
                    }
                }
                dataGridView1.Rows[i].Visible = isVisible;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ZapolnenieDTG();
        }

        private void Button7_Click_1(object sender, EventArgs e)
        {
            VacancyDTG();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SpecDTG();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Spec1DTG();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            AddMen CJ = new AddMen();
            CJ.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ChangeMen CJ = new ChangeMen();
            CJ.ShowDialog();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить учетную запись?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Avtori WHERE [EmployeesID] = " + Workdatagrid.Rows[indexRows].Cells[0].Value;
                OleDbCommand command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Rass CJ = new Rass();
            CJ.ShowDialog();
        }
    }
}
