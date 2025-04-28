using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variable_Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int avg_height;
            short numOfStudent = 85;
            string className = "평균 키";

            int a = 131;
            float b = 134.7f;
            decimal c = 123.8m;
            double d = 127.6;
            byte e = 129;

            double total = a + (double)b + (double)c + d + e;
            avg_height = (int)(total / 5);

            textBox_print.Text += numOfStudent.GetType() + "\r\n" + "평균 키" + avg_height;
        }

        private void result_Click(object sender, EventArgs e)
        {
            
        }
    }
}
