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
    public partial class Form3 : Form
    {
        //строка для записи цены и новой позиции
        string buf,priceStr;

        public Form3()
        {
            InitializeComponent();
        }
        //Ставим цену на товары которые есть в наличии
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Товар 1")) {
                price.Text = "1.00";
            }
            if (comboBox1.Text.Equals("Товар 2"))
            {
                price.Text = "2.00";
            }
            if (comboBox1.Text.Equals("Товар 3"))
            {
                price.Text = "3.00";
            }
            //проставляем цену для новой позиции
            if (comboBox1.Text.Equals(buf))
            {
                //ыена обновляется и прога работает с багами. 
                price.Text = priceStr;
            }
        }

        //Добавляем товар в список покупок
        private void add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            //Отображаем стоимость покупок
            total.Text = String.Format($"{decimal.Parse(total.Text) + decimal.Parse(price.Text):F}");
        }

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(new myDelegate(func));
            f4.ShowDialog();
        }
        //функция для вставки наименования и цены
        void func(string data,string data1) {
            //записываем новые данные в буфер для дальнейшего сравнения
            buf = data;
            priceStr = data1;
            //добавлем в комбо новую позицию
            comboBox1.Items.Add(data);
           
        }
        
    }
}
