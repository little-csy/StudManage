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
    public partial class Stu_个人查询课表 : Form
    {
        public Stu_个人查询课表()
        {
            InitializeComponent();
        }

        public class ClassRoom_No
        {
            public static string classroom_no;

        }
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
        private void Stu_个人查询课表_Load(object sender, EventArgs e)
        {      
            string Stu_sno = UserName.User_name;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();  
            string sql = "select SC.Sno,SC.Cno,Course.Cname,Course.Credit,Course.Ctype,Course.Cnum,Course.Ctime,Course.Croom ,Course.Tno from SC,Course where SC.Cno=Course.Cno and SC.Sno='"+Stu_sno+"'";                     
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();           
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "课程号";
            dataGridView1.Columns[2].HeaderText = "课程名";
            dataGridView1.Columns[3].HeaderText = "课程学分";
            dataGridView1.Columns[4].HeaderText = "课程类型";
            dataGridView1.Columns[5].HeaderText = "容量";
            dataGridView1.Columns[6].HeaderText = "上课时间";
            dataGridView1.Columns[7].HeaderText = "上课教室";
            dataGridView1.Columns[8].HeaderText = "教师工号";
            conn.Close();
        }                 

        public string i;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {          
            string i = dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();  //获取选中行“上课教室”属性列的列值
            ClassRoom_No.classroom_no = i;   //将获取的选中行的列值赋给静态变量
            教室平面图2 f = new 教室平面图2();
            f.ShowDialog();
        }

        /// <summary>
        /// 取消选课
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cms_CancelSelected_Click(object sender, EventArgs e)    
        {
            SqlConnection conn = new SqlConnection(str);
            int row = this.dataGridView1.CurrentRow.Index;  //获取选中行的索引
            if (row.ToString() == null)
            {
                MessageBox.Show("未选中课程！","提示");
            }
            else
            {
                try
                {
                    string Stu_sno = UserName.User_name;   //获取登录用户的学号                 
                    string Stu_cno = dataGridView1.SelectedCells[1].Value.ToString();    //获取选中行的课程号
                    this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[row]);   //从datagridview1视图中移除选中行
                    string sql = "delete from SC where Sno='" + Stu_sno + "'and Cno='" + Stu_cno + "'";
                    Zon zon = new Zon();
                    zon.Excute(sql);
                }
                catch
                {
                    MessageBox.Show("未选中课程！","提示");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try 
            {

                if (e.Button == MouseButtons.Right)
                {

                    if (e.RowIndex >= 0)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                    }
                }
                         
            }
            catch
            {
                MessageBox.Show("未选中课程！", "提示");
            }
            finally
            {
                    
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
