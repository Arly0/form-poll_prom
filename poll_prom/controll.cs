﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace poll_prom
{
    class controll
    {
        //указание путя к БД
        SqlConnection cn;
        string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NGorbunov\source\repos\poll_prom\poll_prom\Database1.mdf;Integrated Security=True";
        // соединение с БД
        public controll()
        {
            cn = new SqlConnection(connect);
            cn.Open();
        }
        //закрытие БД
        public void Closecont()
        {
            cn.Close();
        }
        //проверка на подключение
        public SqlConnection getConnect()
        {
            if (cn != null)
                return cn;
            else
            {
                MessageBox.Show("Error can`t connect.");
                return null;
            }

        }
        
    }
}
