using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace STUManagement.子窗口
{
    public partial class 教室平面图2 : Form
    {
        public 教室平面图2()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void 教室平面图2_Load(object sender, EventArgs e)
        {
            string str = Stu_GetCourseInfo.ClassRoom_No.classroom_no;
            string str1 = Stu_个人查询课表.ClassRoom_No.classroom_no;
            string str2 = 学生选课.ClassRoom_No.classroom_no;
            string str3 = Tea_GetCoursecs.ClassRoom_NO.classroom_no;
            string str4 = S_Sc.ClassRoom_NO.classroom_no;
            if (button1.Text == str||button1.Text==str1||button1.Text==str2||button1.Text==str3||button1.Text == str4)
            {
                this.button1.BackColor = Color.OrangeRed;
            }
            else if (button2.Text == str||button2.Text==str1 || button2.Text == str2 || button2.Text == str3|| button2.Text == str4)
            {
                this.button2.BackColor = Color.OrangeRed;
            }
            else if (button3.Text == str||button3.Text==str1 || button3.Text == str2 || button3.Text == str3||button3.Text == str4)
            {
                this.button3.BackColor = Color.OrangeRed;
            }
            else if (button4.Text == str||button4.Text==str1 || button4.Text == str2 || button4.Text == str3||button4.Text==str4)
            {
                this.button4.BackColor = Color.OrangeRed;
            }
            else if (button5.Text == str||button5.Text==str1 || button5.Text == str2 || button5.Text == str3 || button5.Text == str4)
            {
                this.button5.BackColor = Color.OrangeRed;
            }
            else if (button6.Text == str|| button6.Text == str1 || button6.Text == str2 || button6.Text == str3 || button6.Text == str4)
            {
                this.button6.BackColor = Color.OrangeRed;
            }
            else if (button7.Text == str||button7.Text==str1 || button7.Text == str2 || button7.Text == str3 || button7.Text == str4)
            {
                this.button7.BackColor = Color.OrangeRed;
            }
            else if (button8.Text == str||button8.Text==str1 || button8.Text == str2 || button8.Text == str3 || button8.Text == str4)
            {
                this.button8.BackColor = Color.OrangeRed;

            }
            else if (button9.Text == str||button9.Text == str1 || button9.Text == str2 || button9.Text == str3 || button9.Text == str4)
            {
                this.button9.BackColor = Color.OrangeRed;
            }
            else if (button10.Text == str|| button10.Text == str1 || button10.Text == str2 || button10.Text == str3 || button10.Text == str4)
            {
                this.button10.BackColor = Color.OrangeRed;
            }
            else if (button11.Text == str|| button11.Text == str1 || button11.Text == str2 || button11.Text == str3 || button11.Text == str4)
            {
                this.button11.BackColor = Color.OrangeRed;
            }
            else if (button12.Text == str ||button12.Text==str1 || button12.Text == str2 || button12.Text == str3 || button12.Text == str4)
            {
                this.button12.BackColor = Color.OrangeRed;
            }
            else if (button13.Text == str||button13.Text==str1 || button13.Text == str2 || button13.Text == str3 || button13.Text == str4)
            {
                this.button13.BackColor = Color.OrangeRed;
            }
            else if (button14.Text == str||button14.Text==str1 || button14.Text == str2 || button14.Text == str3 || button14.Text == str4)
            {
                this.button14.BackColor = Color.OrangeRed;
            }
            else if (button15.Text == str ||button15.Text==str1 || button15.Text == str2 || button15.Text == str3 || button15.Text == str4)
            {
                this.button15.BackColor = Color.OrangeRed;
            }
            else if (button16.Text == str ||button16.Text==str1 || button16.Text == str2 || button16.Text == str3 || button16.Text == str4)
            {
                this.button16.BackColor = Color.OrangeRed;
            }
            else if (button17.Text == str||button17.Text==str1 || button17.Text == str2 || button17.Text == str3 || button17.Text == str4)
            {
                this.button17.BackColor = Color.OrangeRed;
            }
            else if (button18.Text == str||button18.Text==str1 || button18.Text == str2 || button18.Text == str3 || button18.Text == str4)
            {
                this.button18.BackColor = Color.OrangeRed;
            }
            else if (button19.Text == str||button19.Text==str1 || button19.Text == str2 || button19.Text == str3 || button19.Text == str4)
            {
                this.button19.BackColor = Color.OrangeRed;
            }
            else
            {
                MessageBox.Show("此教室不存在！");
            }
        }      
    }
}
