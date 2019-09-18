using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TXT文件去换行
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string path = textBox1.Text.Trim();
            string savepath = textBox2.Text.Trim();
            IEnumerable<string> strlist = File.ReadAllLines(path, Encoding.Default);
            foreach (string item in strlist)
            {
               //string items= item.Replace(@"\r\n", "");
                File.AppendAllText(savepath, item+",", Encoding.Default);
            }

            MessageBox.Show("修改完成");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "*.txt|*.txt";
            openFileDialog.ShowDialog();
            textBox1.Text = openFileDialog.FileName;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "text(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            
            textBox2.Text = saveFileDialog.FileName;
        }
    }
}
