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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int help = int.Parse(numericUpDown1.Text); //ช้อปช่วยชาติ
            int studysport = int.Parse(numericUpDown2.Text);//สินค้าการศึกและกีฬา
            int book = int.Parse(numericUpDown3.Text);//หนังสือ
            int otop = int.Parse(numericUpDown4.Text); //otop
            int travel1 = int.Parse(numericUpDown5.Text);//หลัก
            int travel2 = int.Parse(numericUpDown6.Text);//รอง
            int home = int.Parse(numericUpDown7.Text);//บ้าน
            int car = int.Parse(numericUpDown8.Text);//รถ
            int tot = int.Parse(textBox4.Text);//รายได้พึงประเมิน
            int total;//รายได้สุทธิ
            int tax;//ภาษีที่ลดหย่อนได้
            int i = 0;
            int j = 0;

            if ((travel1 + travel2) < 20000) //หลักกับรองบวกับไม่เกิน2หมื่อน
            {
                i = (travel1 + travel2);
            }
            else if ((travel1 + travel2) > 20001) //ถ้าเกิน2เหทือนเดิม
            {
                i = 20000;
            }
            if ((home + car) < 100000)//หลักกับรองบวกับไม่เกิน1แสน
            {
                j = (home + car);
            }
            else if ((home + car) > 100001)
            {
                j = 100000;
            }

            tax = help + studysport + book + otop + i + j; //ภาษีที่ลดหย่อนได้
            Program.grop5 = tax;
            textBox5.Text = tax.ToString();

            total = tot - tax;
            textBox6.Text = total.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total;
            total = Program.income;
            textBox4.Text = total.ToString();
        }
    }
}
