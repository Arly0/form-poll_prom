using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poll_prom
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet2.prom". При необходимости она может быть перемещена или удалена.
            this.promTableAdapter.Fill(this.database1DataSet2.prom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.prom". При необходимости она может быть перемещена или удалена.
            //this.promTableAdapter1.Fill(this.database1DataSet1.prom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.prom". При необходимости она может быть перемещена или удалена.
            //this.promTableAdapter.Fill(this.database1DataSet.prom);
            //при  каждом посещении формы БД обновляется(динамически)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Нео уклоняется от исключений и создает экземпляр пространства имен.формы для открытия другой формы :)
            poll_prom.Form1 form = new poll_prom.Form1();
            form.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
