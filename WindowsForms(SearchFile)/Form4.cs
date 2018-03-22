using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_SearchFile_
{
    public partial class Form4 : Form
    {
        //создаем делегат 
        myDelegate md;
        //меняем конструктор формы для работы с делегатом
        public Form4(myDelegate sender)
        {
            InitializeComponent();
            md = sender;
            //md1 = sender1;
        }

        private void addInfo_Click(object sender, EventArgs e)
        {
            //проверка на заполнение полей
            if (richTextBox1.Text == "" || richTextBox2.Text == ""|| richTextBox3.Text == ""|| richTextBox4.Text == "") {
                throw new Exception("Нужно заполнить все поля");
            }
            listBox1.Items.Add(String.Format($"{richTextBox1.Text}->{richTextBox2.Text}-> {richTextBox4.Text} "));
        }
      


        //Запрос на редактирование или добавления в начальную форму
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Добавить товар в список доступных для продаж", "###", MessageBoxButtons.OKCancel);
            //передаем новый товар в изначальную форму
            if (res == DialogResult.OK)
            {
                //передаем в делегат данные
                md(richTextBox1.Text,richTextBox3.Text);
                //чистим форму после 
                listBox1.Items.Clear();
                //Закрываем форму
                this.Close();
            }
            else
            {
               // редактируем форму
                res = MessageBox.Show("Редактировать товар", "###", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                }
            }
        }
    }
}
