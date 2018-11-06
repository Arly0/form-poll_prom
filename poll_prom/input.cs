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
        // для записи СКЛ синтаксиса
        string sql;
     /*   SqlConnection cn;
        // строка с созданием подключение к БД
        string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NGorbunov\source\repos\poll_prom\poll_prom\Database1.mdf;Integrated Security=True";
       */ public input()
        { 
            InitializeComponent();
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
            
            // подключение к БД и его открытие

            // синтаксис T-SQL подключение ру языка
            
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

            //экземпляр
            //  cn = new SqlConnection(connect);
            //cn.Open();
            controll con = new controll();
            SqlConnection cn = con.getConnect();
            //cmd.CommandText = @"UPDATE prom SET reg_number=@reg_number, fio=@fio, [index]=@index, obl=@obl, sity=@sity, street=@street, num_house=@num_house, phone=@phone, school_name=@school_name, number_school=@number_school, sity_of_school=@sity_of_school";
            sql = "INSERT INTO prom (reg_number, fio, [index], obl, sity, street, num_house, phone, school_name, number_school, sity_of_school) VALUES ('" + reg + "','" + name + "','" + ind + "','" + obl + "','" + sit + "','" + street + "','" + house + "','" + num + "','" + schoolname + "','" + schoolnum + "','" + schoolcit + "')";
            // other tables
            
            
            try
            {
                
                SqlCommand command = new SqlCommand(sql, cn);
                command.Parameters.AddWithValue("@reg_number ", textBox1.Text);
                command.Parameters.AddWithValue("@fio ", textBox2.Text);
                command.Parameters.AddWithValue("@index ", textBox3.Text);
                command.Parameters.AddWithValue("@obl ", textBox4.Text);
                command.Parameters.AddWithValue("@sity ", textBox5.Text);
                command.Parameters.AddWithValue("@street ", textBox6.Text);
                command.Parameters.AddWithValue("@num_house ", textBox7.Text);
                command.Parameters.AddWithValue("@phone ", textBox11.Text);
                command.Parameters.AddWithValue("@school_name ", textBox8.Text);
                command.Parameters.AddWithValue("@number_school ", textBox9.Text);
                command.Parameters.AddWithValue("@sity_of_school ", textBox10.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("prom added");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Closecont();
            //cn.CLose();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
