using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using STUManagement.子窗口;
using static STUManagement.Form1;

namespace STUManagement
{
    public partial class F2_Student : Form
    {
        

        public F2_Student()
        {
            InitializeComponent();
        }

        private void F2_Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

       
        private void F2_Student_Load(object sender, EventArgs e)
        {
            

        }
        private void 课程信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stu_GetCourseInfo SC = new Stu_GetCourseInfo ();
            SC.ShowDialog();
            

        }

        private void 个人信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           

    }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 院系信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {   
           
            S_Ds s_Ds = new S_Ds();
            s_Ds.ShowDialog();
           
        }

        /// <summary>
        /// 个人信息查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void 个人信息查询ToolStripMenuItem_Click_1(object sender, EventArgs e)   
        {
            string User_name = UserName.User_name;
            string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";         
            SqlConnection conn = new SqlConnection(str); 
            conn.Open();
            string sql = "select * from Student where Sno='"+User_name+"'";
            sql = string.Format(sql, User_name);
            //创建SqlDataAdapter类的对象
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //创建DataSet类的对象
            DataSet ds = new DataSet();
            //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
            sda.Fill(ds);          
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "出生年月";
            dataGridView1.Columns[4].HeaderText = "班级号";

            conn.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)   //学生选课
        {
            学生选课 f = new 学生选课();
            f.ShowDialog();
           

        }

        private void 个人课表查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stu_个人查询课表 f = new Stu_个人查询课表();
            f.ShowDialog();
        }

        private void 个人成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stu_个人成绩查询 s = new Stu_个人成绩查询();
            s.ShowDialog();
        }

        private void 修改个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改个人信息 f = new 修改个人信息();
            f.ShowDialog();
        }
    }
}

