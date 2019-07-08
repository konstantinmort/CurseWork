using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovoyProect
{
    public partial class ChangeVacancy : Form
    {
        private static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=Jobless.mdb";
        private OleDbConnection con = new OleDbConnection(connect);

        public ChangeVacancy()
        {
            InitializeComponent();
            con.Open();
            try
            {
                IDChangecomboBox2.Items.Clear();
                string query = "SELECT [TTID] FROM [Zero] ORDER BY [TTID]";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    IDChangecomboBox2.Items.Add(reader[0]);
                }
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void SaveChangebutton1_Click(object sender, EventArgs e)
        {            
            try
            {
                string query = "UPDATE [Zero] SET [Etaj] ='" + textBox1.Text + "'," +
                               "[S] ='" + vacancytextBox1.Text + "'," +
                               "[Kondic] ='" + comboBox1.SelectedItem + "'," +
                               "[SummaVden] ='" + exptextbox.Text + "' WHERE [TTID] = " + IDChangecomboBox2.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Изменение успешно выполнено");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Cancelbutton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IDChangecomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM [Zero] WHERE [TTID] =" + IDChangecomboBox2.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[1].ToString();
                    vacancytextBox1.Text = reader[2].ToString();
                    comboBox1.SelectedItem = reader[3].ToString();
                    exptextbox.Text = reader[4].ToString();
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
    }
}
