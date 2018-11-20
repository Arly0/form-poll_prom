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
    public partial class find : Form
    {
        public find()
        {
            InitializeComponent();
        }
        
        
        private void find_Load(object sender, EventArgs e)
        {
            //занесение данных из БД в форму
            controll con = new controll();
            SqlConnection cn = con.getConnect();
            SqlDataAdapter da = new SqlDataAdapter("select * from prom", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void output()
        {
            //функция выведения записи из БД в текстбокс
            controll con = new controll();
            SqlConnection cn = con.getConnect();
            SqlCommand cmd = new SqlCommand("SELECT * FROM prom WHERE reg_number = @reg_number", cn);
            cmd.Parameters.AddWithValue("@reg_number", dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value);
            //cmd.CommandText = ("SELECT * FROM prom WHERE reg_number ='"+dataGridView1.CurrentCell.RowIndex+"'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBox1.Text = dr["reg_number"].ToString();
                textBox2.Text = dr["fio"].ToString();
                textBox3.Text = dr["index"].ToString();
                textBox4.Text = dr["obl"].ToString();
                textBox5.Text = dr["sity"].ToString();
                textBox6.Text = dr["street"].ToString();
                textBox7.Text = dr["num_house"].ToString();
                textBox8.Text = dr["phone"].ToString();
                textBox9.Text = dr["school_name"].ToString();
                textBox10.Text = dr["number_school"].ToString();
                textBox11.Text = dr["sity_of_school"].ToString();
               // textBox12.Text = dr["reg_number"].ToString() + "\n";
            }

            textBox1.Enabled = false;
            dr.Close();
            cn.Close();
        }

        //Функция применения изменений из текстбоксов в БД
        private void complete()
        {
            controll con = new controll();
            SqlConnection cn = con.getConnect();
            SqlCommand cmd = new SqlCommand("UPDATE prom SET fio = @fio, [index] = @index, obl = @obl, sity = @sity, street = @street, num_house = @num_house, phone = @phone, school_name = @school_name, number_school = @number_school, sity_of_school = @sity_of_school WHERE reg_number = @reg_number",cn);
            cmd.Parameters.AddWithValue("@reg_number", textBox1.Text.ToString());
            cmd.Parameters.AddWithValue("@fio", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@index", textBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@obl", textBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@sity", textBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@street", textBox6.Text.ToString());
            cmd.Parameters.AddWithValue("@num_house", textBox7.Text.ToString());
            cmd.Parameters.AddWithValue("@phone", textBox8.Text.ToString());
            cmd.Parameters.AddWithValue("@school_name", textBox9.Text.ToString());
            cmd.Parameters.AddWithValue("@number_school", textBox10.Text.ToString());
            cmd.Parameters.AddWithValue("@sity_of_school", textBox11.Text.ToString());
            try
            {
                cmd.ExecuteNonQuery();

                MessageBox.Show("Редактирование прошло успешно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            cn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            output();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            poll_prom.Form1 form = new poll_prom.Form1();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //функция complete() редактирует данные в БД
            complete();
            //редактирует данные в datagridView
            //TextBox[] arrtext = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11 };

            DataGridViewRow row = new DataGridViewRow();
            
            // некоторые элементы ДГВ являются не теми типами данных
            row.Cells[1].Value = textBox2.Text.ToString();
            row.Cells[3].Value = int.Parse(textBox3.Text);
            row.Cells[4].Value = textBox4.Text.ToString();
            row.Cells[5].Value = textBox5.Text.ToString();
            row.Cells[6].Value = textBox6.Text.ToString();
            row.Cells[7].Value = int.Parse(textBox7.Text);
            row.Cells[8].Value = int.Parse(textBox8.Text);
            row.Cells[9].Value = textBox9.Text.ToString();
            row.Cells[10].Value = int.Parse(textBox10.Text);
            row.Cells[11].Value = textBox11.Text.ToString();
            
            /*for (int i=3;i<arrtext.Length;i++)
            {
                row.Cells[i].Value = arrtext[i].Text;
            }*/


        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
