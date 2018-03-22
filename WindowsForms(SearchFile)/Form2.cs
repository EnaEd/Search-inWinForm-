using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//DirectoryInfo

namespace WindowsForms_SearchFile_
{
    public partial class Form2 : Form
    {
        #region Версия пока не понимал что точно надо))
        //FolderBrowserDialog fbd = new FolderBrowserDialog();
        //OpenFileDialog ofd=new OpenFileDialog();

        //public Form2()
        //{
        //    InitializeComponent();
            
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (fbd.ShowDialog() == DialogResult.OK) {
        //        folder.Text = fbd.SelectedPath.ToString();
        //    }
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (textBox1 != null) {
        //        ofd.Filter = $"File(*.{textBox1.Text}*)|*.{textBox1.Text}*";
        //        label1.Text = ofd.Filter.ToString();
        //    }

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    ofd.InitialDirectory = folder.Text;
        //    ofd.DefaultExt = ofd.Filter;
        //    ofd.Multiselect = true;
        //    ofd.ShowDialog();
            
        //    foreach (var item in ofd.FileNames)
        //    {
               
        //        listBox1.Items.Add(item);
        //    }
        //}
        #endregion

        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { }

        private void button3_Click(object sender, EventArgs e) {
            //Проверка все ли поля для поиска заполнены
            if (folderPath.Text == "" || fileEx.Text == "")
            {
                MessageBox.Show("Поля расположение и расширение должны быть заполнены");
            }
            else {
                Search(folderPath.Text);
            }
        }
        //DirectoryInfo dr = new DirectoryInfo(folderPath.Text);
        //функция поиска
        public void Search(string path) {
            DirectoryInfo dr = new DirectoryInfo(folderPath.Text);
            foreach (var item in dr.GetFiles() )
            {
                if (item.Name.Contains(fileEx.Text)) {
                    listBox1.Items.Add(item.Name);
                }
            }
        }

    }
}
