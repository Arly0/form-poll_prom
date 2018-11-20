using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace poll_prom
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }
        // дерьмовый метод заполнения datagridView из БД
       /* private void LoadData()
        {
            string sql = "SELECT * FROM prom ORDER BY reg_number";

            controll con = new controll();
            SqlConnection cn = con.getConnect();

            SqlCommand command = new SqlCommand(sql,cn);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[14]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();
                data[data.Count - 1][13] = reader[13].ToString();
            }
            reader.Close();
            cn.Close();
            foreach(string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }
        */
        private void Form2_Load(object sender, EventArgs e)
        {
            //загрузка данных из БД в datagridView
            controll con = new controll();
            SqlConnection cn = con.getConnect();
            SqlDataAdapter da = new SqlDataAdapter("select * from prom", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();

            
            // поиск можно осуществлять только с фамилии,может есть смысл разибть этот атрибут на кортеж
            // или как-то что искался во всех 3 словах


            



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

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            

            controll con = new controll();
            SqlConnection cn = con.getConnect();
            //string reg_row = dataGridView1.SelectedRows.ToString();
            //string reg_col = dataGridView1.CurrentCell
            SqlCommand cm = new SqlCommand("DELETE FROM prom WHERE reg_number = @reg_number" , cn);
            cm.Parameters.AddWithValue("@reg_number", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value);

            //выполнение команды и возвращение ошибки,если такова имеется
           try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Удаление прошло успешно.");
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // выбор столбца для поиска
            string col = "";
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    col = "reg_number";
                    break;
                case 1:
                    col = "fio";
                    break;
                case 2:
                    col = "date_birth";
                    break;
                case 3:
                    col = "[index]";
                    break;
                case 4:
                    col = "obl";
                    break;
                case 5:
                    col = "sity";
                    break;
                case 6:
                    col = "street";
                    break;
                case 7:
                    col = "num_house";
                    break;
                case 8:
                    col = "phone";
                    break;
                case 9:
                    col = "school_name";
                    break;
                case 10:
                    col = "number_school";
                    break;
                case 11:
                    col = "sity_of_school";
                    break;
                case 12:
                    col = "date_end_school";
                    break;
                case 13:
                    col = "prize";
                    break;

            }
            // выборка из БД введенного поля
            controll con = new controll();
            SqlConnection cn = con.getConnect();
            SqlDataAdapter da = new SqlDataAdapter("select * from prom where "+col+" like '"+textBox1.Text+"%'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // видимость и кликабельность кнопки
            //активация после выбора любой строки в datagridView 
            if(dataGridView1.SelectedRows.Count > 0)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
