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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox5.Enabled = false;
                textBox8.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox5.Enabled = false;
                textBox8.Enabled = false;
            }
            else
            {
                checkBox5.Enabled = true;
                textBox8.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
                
                int p;
                int aa = int.Parse(textBox4.Text); //ประกาศตัวแปลประกันสังคม //ไปจะดึงค่าลดหย่อนแล้ว
                int ab = int.Parse(textBox5.Text); //ชีวิต
                int ac = int.Parse(textBox6.Text); //สุขภาพ
                int ad = int.Parse(textBox7.Text); //บิดามารดา
                int ae = int.Parse(textBox8.Text); //สมรถ
                int af = int.Parse(textBox9.Text); //สำรองเลี้ยงชีพ
                int ag = int.Parse(textBox10.Text); //กองทุน
            if ((ab+ac)>100000)
            {
                ac = 0;
            }
            p = aa + ab + ac + ad + ae + af + ag ; //ภาษีที่ลดหย่อนทั้งหมด
                Program.grop2 = p;
                textBox11.Text = p.ToString();

                int b1 = int.Parse(total.Text);
                int b2 = int.Parse(textBox11.Text);
                int outcome;
                outcome = b1 - b2;
                tot.Text = outcome.ToString();
            
               
               
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void g_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            total.Text = Program.income.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {

        }
    }
}