using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Butr = int.Parse(numericUpDown1.Text);//บุตรเกิดก่อน61
            int Butr2 = int.Parse(numericUpDown2.Text);//บุตรเกิดหลัง61
            int a3 = int.Parse(textBox2.Text);//ค่าฝากครรภ์
            int a4 = int.Parse(textBox3.Text);//อุปการะคนพิการ
            int a5; //ตัวแปล
            int a6;
            int m = 0;
            int p = 0;
            int q = 0;
            int r = 0;
            int s = 0;
            int t = 0;
            int u = 0;
            int v = 0;
            int w = 0;
            int total;
            if (checkBox9.Checked)
            {
                m = 0;
            }
            if (checkBox10.Checked)
            {
                m = 0;
            }
            if (checkBox11.Checked)
            {
                m = 60000;
            }
            if (checkBox1.Checked)
            {
                p = 0;
            }
            if (checkBox2.Checked)
            {
                q = 30000;
            }
            if (checkBox3.Checked)
            {
                r = 60000;
            }
            if (checkBox4.Checked)
            {
                s = 0;
            }
            if (checkBox5.Checked)
            {
                t = 30000;
            }
            if (checkBox6.Checked)
            {
                u = 30000;
            }
            if (checkBox7.Checked)
            {
                v = 30000;
            }
            if (checkBox8.Checked)
            {
                w = 30000;
            }
            a5 = Butr * q ;
            a6 = Butr2 * r;

            total = a3 + a4*60000 + a5 + +a6 + m + p + q + r + s + t + u + v + w + 60000; //การคำนวณ
            Program.grop1 = total;
            textBox4.Text = total.ToString(); //ภาษีที่ลดหย่อน

            int b1 = int.Parse(ttotal.Text);//จะไปดึงค่าที่เงินพึง
            int b2 = int.Parse(textBox4.Text);//จะไปดึงค่าที่ภาษีลดหย่อน
            int outcome;
            outcome = b1 - b2;
            balance.Text = outcome.ToString(); //จะค่าแสดงใน balance


            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ttotal.Text = Program.income.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
