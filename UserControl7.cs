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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total;  //ค่าจากกล่องเท็คบล็อคที่เขาเเทนค่ามา
            total = int.Parse(textBox11.Text); //ดึงค่าโดยเเปลงจากข้อความมาเป็นตัวเลข
            Program.income = total;  //โททอมาเก็บไว้ในอินคัมเเล้วเอาอินคัมเเสดงไปยังอื่นๆได้ 
        }
    }
}
