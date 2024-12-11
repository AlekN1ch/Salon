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

namespace Salon
{
    public partial class Form1 : Form
    {
        //нужны для подключения базы данных
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Salon.accdb";
        private OleDbConnection myConnection;
        public static string login;

        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonDataSet.userTable". При необходимости она может быть перемещена или удалена.
            this.userTableTableAdapter.Fill(this.salonDataSet.userTable);
            
         
            //Заполняем листбокс логинами из базы данных
            string query = "SELECT login FROM userTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
            //Заполняем листбокс паролями из базы данных
            string query1 = "SELECT password FROM userTable ORDER BY Код";
            OleDbCommand command1 = new OleDbCommand(query1, myConnection);
            OleDbDataReader reader1 = command1.ExecuteReader();
            listBox2.Items.Clear();
            while (reader1.Read())
            {
                listBox2.Items.Add(reader1[0].ToString());
            }
            reader1.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login = textBox1.Text;
            string password = textBox2.Text;
            bool access= false;
           
            //Проверяем каждый элемент листбокса
            foreach(var item in listBox1.Items)
            {
                //Проверяем каждый эелемент листбокса на соответствие с введенным логином
                if (item.ToString() == login)
                {
                   
                    foreach(var item1 in listBox2.Items)
                    {
                        if (item1.ToString() == password) access = true;
                            }
                }
                
            }
            if(access)
            {
                MessageBox.Show("Вход совершён успешно");
                Form2 cat = new Form2();
                cat.ShowDialog();
            }
            else
            {
                MessageBox.Show("неверный логин или пароль");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
