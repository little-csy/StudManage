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

namespace STUManagement.子窗口
{
    public partial class Stu_GetCourseInfo : Form
    {
        public Stu_GetCourseInfo()
        {
            InitializeComponent();
        }

        public class ClassRoom_No
            {
            public static string classroom_no = "";

            }
        /// <summary>
        /// 按课程名模糊查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
              
                 string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";  
                 SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(str);
                    //打开数据库
                    conn.Open();
                    string sql = "select * from Course where Cname like'%{0}%'";
                    sql = string.Format(sql, textBox2.Text);
                    //创建SqlDataAdapter类的对象
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    //创建DataSet类的对象
                    DataSet ds = new DataSet();
                    //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                    sda.Fill(ds);
                    //设置表格控件的DataSource属性
                    dataGridView1.DataSource = ds.Tables[0];

                    dataGridView1.Columns[0].HeaderText = "课程号";
                    dataGridView1.Columns[1].HeaderText = "课程名";
                    dataGridView1.Columns[2].HeaderText = "学分";
                    dataGridView1.Columns[3].HeaderText = "容量";
                    dataGridView1.Columns[4].HeaderText = "上课时间";
                    dataGridView1.Columns[5].HeaderText = "授课教师工号";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现错误！" + ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        
                        conn.Close();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select * from Course ";
            SqlDataAdapter ada = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
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
        /// <summary>
        ///  按课程号查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {             
                string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";             
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(str);
                    //打开数据库
                    conn.Open();
                    string sql = "select * from Course where Cno= '" + textBox1.Text + "'";
                    sql = string.Format(sql, textBox1.Text);
                    //创建SqlDataAdapter类的对象
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    //创建DataSet类的对象
                    DataSet ds = new DataSet();
                    //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                    sda.Fill(ds);                  
                    dataGridView1.DataSource = ds.Tables[0];
                    dataGridView1.Columns[0].HeaderText = "课程号";
                    dataGridView1.Columns[1].HeaderText = "课程名";
                    dataGridView1.Columns[2].HeaderText = "学分";
                    dataGridView1.Columns[3].HeaderText = "容量";
                    dataGridView1.Columns[4].HeaderText = "上课时间";
                    dataGridView1.Columns[5].HeaderText = "授课教师工号";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现错误！" + ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        
                        conn.Close();
                    }
                }
            }
        }

        private void Stu_GetCourseInfo_Load(object sender, EventArgs e)
        {

        }

        public string  i;
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string  i = dataGridView1.SelectedCells[0].Value.ToString();
            ClassRoom_No.classroom_no = i;
            教室平面图2 f = new 教室平面图2();
            f.ShowDialog();
        }
    }
}
