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

namespace KursovoyProect
{
    public partial class Autorization : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=Jobless.mdb";
        OleDbConnection con = new OleDbConnection(connect);

        public Autorization()
        {
            InitializeComponent();
            con.Open();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //Считываю логин и пароль
            string login, password;
            login = Login.Text;
            password = Password.Text;

            //Проверяю введены ли логин и пароль
            if (!string.IsNullOrEmpty(Password.Text) && !string.IsNullOrWhiteSpace(Password.Text)
                && !string.IsNullOrEmpty(Login.Text) && !string.IsNullOrWhiteSpace(Login.Text))
            {

                //Запрос к БД с получением пароля и логина
                string query = "SELECT Login, Password, GrantUser FROM Avtori ORDER BY GrantUser";
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();

                //Проверка пользователя
                while (reader.Read())
                {
                    //Если есть то заходит под администратора
                    if (login == reader[0].ToString() && password == reader[1].ToString() && reader[2].ToString() == "1")
                    {
                        Admin_panel AP = new Admin_panel();
                        Hide();
                        AP.ShowDialog();
                        break;
                    }//Если тип доступа другой, то под пользователя
                    else if (login == reader[0].ToString() && password == reader[1].ToString() && reader[2].ToString() == "2")
                    {
                        Employeer_Panel UP = new Employeer_Panel();
                        Hide();
                        UP.ShowDialog();
                        break;
                    }//Если введен неправильный логин или пароль выдаст ошибку
                    else Error_Label.Visible = true;
                }
            }
           
        }

        private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
