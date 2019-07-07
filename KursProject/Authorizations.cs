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
    public partial class Authorizations : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Database.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        public Authorizations()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            con.Open();
        }
            private void Button1_Click(object sender, EventArgs e)
            {
                //Считываю введенный логин и пароль пользователем.
                string Login, Password;
                Login = textBox1.Text;
                Password = textBox2.Text;
                if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text)
                    && !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    //Запрос к БД с получением пароля, логина и тип доступа.
                    string autori = "SELECT Login, Password, Preffix FROM [Authorization] ORDER BY ID_employees";
                    OleDbCommand command = new OleDbCommand(autori, con);
                    OleDbDataReader reader = command.ExecuteReader();

                    //Проверяю есть ли такой пользователь.
                    while (reader.Read())
                    {

                        //Если есть, то заходит под менеджера.
                        if (Login == reader[0].ToString() && Password == reader[1].ToString() && reader[2].ToString() == "1")
                        {
                            admin a = new admin();
                            a.Show();
                            this.Hide();
                            con.Close();
                            break;

                        }
                        //Если тип доступа другой то под администратором.
                        else if (Login == reader[0].ToString() && Password == reader[1].ToString() && reader[2].ToString() == "2")
                        {
                            agent b = new agent();
                            b.Show();
                            this.Hide();
                            con.Close();
                            break;
                        }
                        else
                        {
                            //Если введен неверный логин или пароль выдасть ошибку
                            label4.Text = "Неправильный логин или пароль!";
                            label4.Visible = true;
                        }
                    }
                }
                else
                {
                    label4.Text = "Все поля должны быть заполнены!";
                    label4.Visible = true;
                }
            }

            private void Button2_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }

            private void TextBox2_TextChanged(object sender, EventArgs e)
            {
                textBox2.PasswordChar = '*';
            }

            private void TextBox1_Click(object sender, EventArgs e)
            {
                label4.Visible = false;
            }

            private void TextBox2_Click(object sender, EventArgs e)
            {
                label4.Visible = false;
            }

        private void TextBox1_TextChanged(object sender, EventArgs e)
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

        private void Authorizations_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
   
    }
}
