﻿using System;
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
    public partial class EditInc : Form
    {
        static String connect = "Provider=Microsoft.JET.OLEDB.4.0;data source=DB1\\Database.mdb";
        OleDbConnection con = new OleDbConnection(connect);
        public EditInc()
        {
            InitializeComponent();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            con.Open();

            try
            {
                comboBox1.Items.Clear();
                string query = "SELECT ID_view FROM TypesOfInsurance";
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

        private void Button1_Click(object sender, EventArgs e)
        {
            { 
                try
                { 
            string query = "UPDATE TypesOfInsurance SET [TypeName]='" + textBox1.Text + "',[InsuranceInterest]='" + textBox2.Text + "',[SumInsured]='" + textBox3.Text + "',[Term]='" + textBox4.Text + "',[InsuranceObject]='" + textBox5.Text + "',[InsurancePayment]='" + textBox6.Text + "' WHERE ID_view=" + comboBox1.Text;

            OleDbCommand command = new OleDbCommand(query, con);

            command.ExecuteNonQuery();
                    MessageBox.Show("Изменение успешно выполнено");
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditInc_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT ID_view, [TypeName], [InsuranceInterest]," +
                    " [SumInsured], [Term], [InsuranceObject], [InsurancePayment] FROM TypesOfInsurance WHERE ID_view =" + comboBox1.SelectedItem;
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader[1].ToString();
                    textBox2.Text = reader[2].ToString();
                    textBox3.Text = reader[3].ToString();
                    textBox4.Text = reader[4].ToString();
                    textBox5.Text = reader[5].ToString();
                    textBox6.Text = reader[6].ToString();

                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
