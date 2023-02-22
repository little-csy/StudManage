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
using STUManagement.子窗口;

namespace STUManagement
{
    public partial class 学生选课 : Form
    {
        public 学生选课()
        {
            InitializeComponent();

        }

        public class ClassRoom_No    /***传递教室号***/
        {
            public static string classroom_no;
        }
        public string i;
        /// <summary>
        /// 学生选课
        /// </summary>
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
        private void button1_Click(object sender, EventArgs e)  /***显示所有课程***/
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

        private void button2_Click(object sender, EventArgs e)  /***按课程号查询课程***/
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = new SqlConnection(str);
                conn.Open();
                string sql = "select * from Course where Cno= '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    try
                    {
                        conn = new SqlConnection(str);
                        conn.Open();
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
                else if (!dr.Read())
                {
                    MessageBox.Show("不存在该课程，请重新输入！");
                }
            }
        }

        private void 学生选课_Load(object sender, EventArgs e)   /***显示所有课程***/
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  /***双击课程显示教室平面图***/
        {
            string i = dataGridView1.SelectedCells[0].Value.ToString();
            ClassRoom_No.classroom_no = i;
            教室平面图2 f = new 教室平面图2();
            f.ShowDialog();

        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)    /***右键选课***/
        {          
            try
            {
                DialogResult result = MessageBox.Show("确定选择该课程么？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    string Stu_sno = UserName.User_name;
                    string Stu_cno = dataGridView1.SelectedCells[0].Value.ToString();
                    string Stu_Credit = dataGridView1.SelectedCells[2].Value.ToString();
                    string Stu_tno = dataGridView1.SelectedCells[5].Value.ToString();
                    string Stu_Ctype = dataGridView1.SelectedCells[6].Value.ToString();
                    string sql = "Insert into SC(Sno,Cno,Credit,CType,Tno) values('" + Stu_sno + " ','" + Stu_cno + "','" + Stu_Credit + "','" + Stu_Ctype + "','" + Stu_tno + "')";
                    string sql2 = "select * from SC where Sno='" + Stu_sno + "'and Cno='" + Stu_cno + "'";
                    Zon zon = new Zon();
                    zon.command(sql2);
                    IDataReader dr1 = zon.Read(sql2);
                    if (dr1.Read())
                    {
                        MessageBox.Show("该课程已选!", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        dr1.Close();
                        zon.command(sql);
                        int i = zon.Excute(sql);
                        if (i > 0)
                        {
                            MessageBox.Show("选课成功!", "提示", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("请选择课程!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)  /***右键选中行***/
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
    }
}


