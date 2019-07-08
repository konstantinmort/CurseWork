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
using System.Diagnostics;

namespace KursovoyProect
{
    public partial class Rass : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=Jobless.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        public Rass()
        {
            InitializeComponent();
            con.Open();
            try
            {
                comboBox1.Items.Clear();
                string query = "SELECT [TTID] FROM [Zero]";
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



        private void Rass_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            numericUpDown3.Value = numericUpDown1.Value * numericUpDown2.Value;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT TTID, [SummaVden] FROM [Zero]" +
                   "WHERE [TTID] =" + comboBox1.SelectedItem;
            OleDbCommand command = new OleDbCommand(query, con);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                numericUpDown2.Text = reader[1].ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
