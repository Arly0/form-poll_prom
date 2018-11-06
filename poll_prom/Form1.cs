using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * СУБД: регистрационный номер(int),ФИО(char),дата рождения(int),среднее образование(название(char),номер(int),город(char),дата окончания(int)),
 * диплом с отличием / золотая медаль / серебрянная медаль(radioButton), прописка(индекс(int),територия(?char?),населенный пункт(char),
 * улица(char_int),номер дома(int),телефон(int)),выбранная специальность(radiobutton).
 * 
 * Добавить меню(выпадающий список) с пунктом "Помощь".
 * */
namespace poll_prom
{
    public partial class Form1 : Form
    {
//для открытия 2 формы
        Form2 f = new Form2();
        input f3 = new input();
        public Form1()
        {
            
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Приложение завершается и возвращает ОС указанное параметром значение
            System.Environment.Exit(0);
        }
    }
}
