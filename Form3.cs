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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Salon
{
    public partial class Form3 : Form
    {
        public static string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Salon.accdb";
        private OleDbConnection myConnection;
        public Form3()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectionString);
            myConnection.Open();
        }

        
        public void CheckData()
        {
            string month = numericUpDown3.Value.ToString();
            switch (month)
            {
                case "2":
                    numericUpDown4.Maximum = 28; break;
                case "4":
                case "6":
                case "9":
                case "11":
                    numericUpDown4.Maximum = 30; break;
                default:
                    numericUpDown4.Maximum = 31; break;

            }
        }
        public void CheckZapic()
        {
            bool right = false;
            foreach (var item in comboBox1.Items)
            { 
             string text = comboBox1.Text;
                if (item.ToString() == text)
                {
                    right = true;
                    break;
                }
            }
            if (right == false) MessageBox.Show("можно выбрать только отведённое время");
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CheckData();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            CheckData();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            CheckZapic();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonDataSet.recordsTable". При необходимости она может быть перемещена или удалена.
            this.recordsTableTableAdapter.Fill(this.salonDataSet.recordsTable);
            string query = "SELECT data,timeP FROM recordsTable ORDER BY Код";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            listBox1.Items.Clear();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString()+" "+ reader[1].ToString());
            }
            reader.Close();

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckData();
            string mounthZero="";
            if (numericUpDown3.Value < 10)
            {
                mounthZero = "0" + numericUpDown3.Value.ToString();
            }
            else
            {
                mounthZero = numericUpDown3.Value.ToString();
            }
            string data= numericUpDown4.Value.ToString()+"."+ mounthZero;
            CheckZapic();
            string time= comboBox1.Text;
            string userName = Form1.login;
            string query = "INSERT INTO  recordsTable ([data],[timeP],[nameP]) VALUES " + "('" +data + "','" + time+ "','" + userName + "')";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            command.ExecuteNonQuery();
            this.Close();

        }
    }
}
