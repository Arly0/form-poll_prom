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
    public partial class input : Form
    {

        public input()
        { 
            InitializeComponent();
        }

        //функция очистки полей
        private void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // *********************************************************************
        private void input_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            poll_prom.Form1 form = new poll_prom.Form1();
            form.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //занесение данных из текстбоксов в переменные с дальнейшим занесением в БД
            //чтоб длина строки была как можно короче
            int reg     = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            int ind     = int.Parse(textBox3.Text);
            string obl  = textBox4.Text;
            string sit  = textBox5.Text;
            string street     = textBox6.Text;
            int house   = int.Parse(textBox7.Text);
            int num     = int.Parse(textBox11.Text);
            string schoolname = textBox8.Text;
            int schoolnum     = int.Parse(textBox9.Text);
            string schoolcit  = textBox10.Text;

            // подключение к БД
            controll con = new controll();
            SqlConnection cn = con.getConnect();
            string sql = "INSERT INTO prom (reg_number, fio, [index], obl, sity, street, num_house, phone, school_name, number_school, sity_of_school, date_birth, date_end_school) VALUES ('" + reg + "','" + name + "','" + ind + "','" + obl + "','" + sit + "','" + street + "','" + house + "','" + num + "','" + schoolname + "','" + schoolnum + "','" + schoolcit + "', @date_birth, @date_end_school)";
            // other tables
            
            //пробуем добавить данные в БД
            try
            {
                // добавляем введенные значения в БД
                SqlCommand command = new SqlCommand(sql, cn);
                command.Parameters.Add("@date_birth", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                command.Parameters.Add("@date_end_school", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                /*command.Parameters.AddWithValue("@reg_number ", textBox1.Text);
                command.Parameters.AddWithValue("@fio ", textBox2.Text);
                command.Parameters.AddWithValue("@index ", textBox3.Text);
                command.Parameters.AddWithValue("@obl ", textBox4.Text);
                command.Parameters.AddWithValue("@sity ", textBox5.Text);
                command.Parameters.AddWithValue("@street ", textBox6.Text);
                command.Parameters.AddWithValue("@num_house ", textBox7.Text);
                command.Parameters.AddWithValue("@phone ", textBox11.Text);
                command.Parameters.AddWithValue("@school_name ", textBox8.Text);
                command.Parameters.AddWithValue("@number_school ", textBox9.Text);
                command.Parameters.AddWithValue("@sity_of_school ", textBox10.Text);*/
                command.ExecuteNonQuery();
                //выведет,если все ок
                MessageBox.Show("Данные были успешно добавлены в БД.");
                
            }
            // покажет ошибку и ее суть(если есть)
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Closecont();
            clear();
            //cn.CLose();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
