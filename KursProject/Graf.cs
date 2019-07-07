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
using System.Diagnostics;

namespace KursProject
{
    public partial class Graf : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Database.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        public Graf()
        {
            InitializeComponent();
            con.Open();
        }



        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            OpenMicrosoftWord(@"C:\Users\david\Source\Repos\KursProject\bin\Debug\DB1\Doc2.doc");
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            OpenMicrosoftWord(@"C:\Users\david\Source\Repos\KursProject\bin\Debug\DB1\Doc1.doc");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OpenMicrosoftWord(@"C:\Users\david\Source\Repos\KursProject\bin\Debug\DB1\Doc3.doc");
        }
        private void OpenMicrosoftWord(string f)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "WINWORD.EXE";
            startInfo.Arguments = f;
            Process.Start(startInfo);
        }
    }
}
