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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Karsuks = int.Parse(textBox5.Text); //การศึกษา
            int rathbal = int.Parse(textBox6.Text); //รัฐบาล
            int kila = int.Parse(textBox7.Text); //กีฬา
            int satha = int.Parse(textBox8.Text); //สาธา
            int payu = int.Parse(textBox9.Text); //พายุ
            int bricakh = int.Parse(textBox10.Text); //บริจาคทั่วไป
            int karmueng = int.Parse(numericUpDown1.Text); //การเมือง
            int to = int.Parse(textBox4.Text);//รายได้พึงประะเมิน
            int a1; //ช้อปช่วยชาติ
            int a2; //สินค้าการศึกษา กีฬา
            int a3; //หนังสือ
            int a4; //Otop
            int a5; //เมืองหลัก
            int a6; //เมืองรอง
            int a7; //ซ่อมบ้าน
            int x = 0;
            int tot;//บริจาค
            int total;//รายได้สุทธิ
            int taxtotal;//สามารถลดหย่อนได้

            a1 = (Karsuks * 2); //ลดหย่อนการศึกษา
            textBox11.Text = a1.ToString();
            a2 = (rathbal * 2);
            textBox12.Text = a2.ToString();
            a3 = (kila * 2);
            textBox13.Text = a3.ToString();
            a4 = (satha * 2);
            textBox14.Text = a4.ToString();
            a5 = payu;
            textBox15.Text = a5.ToString();
            a6 = bricakh;
            textBox16.Text = a6.ToString();
            a7 = karmueng;
            textBox17.Text = a7.ToString();

            taxtotal = (to * 10) / 100;//สามารถลดหย่อนได้ = รายได้รวมที่หักค่าลดหย่อนอื่นๆแล้ว

            tot = (a1 + a2 + a3 + a4 + a5 + a6 + a7);//ค่ารวมบริจาค
            Program.grop4 = tot;
            if (tot > taxtotal) //ถ้ามันเกิน10% ของเงินได้ x=taxtotal
            {
                x = taxtotal;
            }
            else if (tot < taxtotal)
            {
                x = tot;
            }
            textBox18.Text = x.ToString();

            total = to - x;//รายได้สุทธิ = รายได้พึงประเมิน-ภาษีที่ลดหย่อนได้
            textBox19.Text = total.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int total;
            total = Program.income;

            textBox4.Text = total.ToString();
        }
    }
}
