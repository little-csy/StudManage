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
using static STUManagement.Form1;

namespace STUManagement.子窗口
{
    public partial class Tea_GetCoursecs : Form
    {
        public Tea_GetCoursecs()
        {
            InitializeComponent();
        }
        public class ClassRoom_NO    //静态类，用以传递教室号的值
        {
            public static string classroom_no;
        }
        public string i;
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
        string Tea_tno = UserName.User_name;
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select SC.Sno,Student.Sname,Student.Ssex, Student.ClassNo,SC.Cno,SC.Tno from SC,Student where SC.Sno=Student.Sno and SC.Tno='" + Tea_tno + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "班级";
            dataGridView1.Columns[4].HeaderText = "课程号";            
            dataGridView1.Columns[5].HeaderText = "教师工号";

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();  
            string sql = "select SC.Sno,Student.Sname,Student.Ssex, Student.ClassNo,SC.Cno,SC.Tno from SC,Student where SC.Sno = Student.Sno and SC.Tno = '" + Tea_tno + "' and Cno='"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入课程号！");
            }
            else if(dr.Read())
            {
                dr.Close();
               // sql = string.Format(sql, textBox1.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  
                DataSet ds = new DataSet();//创建DataSet类的对象
                sda.Fill(ds);//使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                dataGridView1.DataSource = ds.Tables[0];//设置表格控件的DataSource属性
                dataGridView1.Columns[0].HeaderText = "学号";
                dataGridView1.Columns[1].HeaderText = "学生姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "班级";
                dataGridView1.Columns[4].HeaderText = "课程号";
                dataGridView1.Columns[5].HeaderText = "教师工号";
            }
            else if (!dr.Read())
            {
                MessageBox.Show("您输入的课程号不存在，请重新输入！", "Tips", MessageBoxButtons.OK);
            }
                conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {           
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select * from Course ";
            SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];       
            dataGridView1.Columns[0].HeaderText = "课程号";
            dataGridView1.Columns[1].HeaderText = "课程名";
            dataGridView1.Columns[2].HeaderText = "学分";
            dataGridView1.Columns[3].HeaderText = "容量";
            dataGridView1.Columns[4].HeaderText = "上课时间";
            dataGridView1.Columns[5].HeaderText = "授课教师工号";
            dataGridView1.Columns[6].HeaderText = "课程类型";
            dataGridView1.Columns[7].HeaderText = "上课教室";

            conn.Close();
        }

        private void Tea_GetCoursecs_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string i = dataGridView1.SelectedCells[0].Value.ToString();
            ClassRoom_NO.classroom_no = i;
            教室平面图2 f = new 教室平面图2();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select * from Course where Tno='" + Tea_tno + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet set = new DataSet();
            da.Fill(set);
            dataGridView1 .DataSource = set.Tables[0];
            dataGridView1 .Columns[0].HeaderText = "课程号";
            dataGridView1 .Columns[1].HeaderText = "课程名";
            dataGridView1 .Columns[2].HeaderText = "学分";
            dataGridView1 .Columns[3].HeaderText = "容量";
            dataGridView1 .Columns[4].HeaderText = "上课时间";
            dataGridView1.Columns[5].HeaderText = "教师工号";
            dataGridView1.Columns[6].HeaderText = "课程类型";
            dataGridView1.Columns[7].HeaderText = "上课教室";

            conn.Close();

        }
    }
}
