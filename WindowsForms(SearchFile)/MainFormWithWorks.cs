﻿using System;
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
    public partial class MainFormWithWorks : Form
    {
        public MainFormWithWorks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //по клику загружаем форму из дз1
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //по клику загружаем форму из дз2
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //по клику загружаем форму из дз1
            Form5 f5 = new Form5();
            f5.ShowDialog();

        }
    }
}
