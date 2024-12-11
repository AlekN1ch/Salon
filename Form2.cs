using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "salonDataSet.recordsTable". При необходимости она может быть перемещена или удалена.
            this.recordsTableTableAdapter.Fill(this.salonDataSet.recordsTable);
            // TODO: данная строка кода позволяет загрузить данные в this.recordsTableAdapter.Fill(this.fLOWERDataSet.records);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 cat = new Form3();
            cat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.recordsTableTableAdapter.Fill(this.salonDataSet.recordsTable);
        }
    }
}
