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
    public partial class S_Sc : Form
    {
        public S_Sc()
        {
            InitializeComponent();

        }
        private void S_Sc_Load(object sender, EventArgs e)
        {
    
        }
        public void Load_datagridview1()    //更新datagrideview1
        {
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
            dataGridView1.Columns[6].HeaderText = "课程类别";
            dataGridView1.Columns[7].HeaderText = "上课教室";
            conn.Close();
        }
        /// <summary>
        /// 课程信息管理
        /// </summary>
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";              
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)   //根据课程号查询课程信息
        {
            if (textBox1.Text != "")
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(str);
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
                    dataGridView1.Columns[6].HeaderText = "课程类别";
                    dataGridView1.Columns[7].HeaderText = "上课教室";

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

        private void button2_Click(object sender, EventArgs e)  //根据课程名查询
        {
            if (textBox2.Text != "")
            {
                SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(str);
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
                    dataGridView1.Columns[6].HeaderText = "课程类别";
                    dataGridView1.Columns[7].HeaderText = "上课教室";
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

        private void button3_Click(object sender, EventArgs e)   //查询所有课程
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
            dataGridView1.Columns[6].HeaderText = "课程类别";
            dataGridView1.Columns[7].HeaderText = "上课教室";
            conn.Close();
        }
    
        private void button6_Click(object sender, EventArgs e) // 修改课程信息
        {
            SqlConnection conn = new SqlConnection(str);
            String Update_by_cno = textBox3.Text.Trim();
            String Item_name = comboBox1.SelectedItem.ToString();
            String Update_item = textBox4.Text.Trim();
            int flag1 = 0;  //该变量表示组合框是否选中项
            int flag2 = 0; //该变量表示是否修改成功
            if (textBox3.Text == null||textBox4.Text==null||comboBox1.Text==null)
            {
                MessageBox.Show("请输入需要更改课程的完整信息！", "提示");
            }                  
            else if (textBox3.Text != null && textBox4.Text != null && comboBox1.Text != null)
            {
                try
                {
                    conn.Open();
                    String Update_str = "UPDATE Course SET ";
                    switch (Item_name)
                    {
                        case "Cname":
                            {
                                Update_str += "Cname = '" + Update_item + "'";
                                break;
                            }
                        case "Credit":
                            {
                                Update_str += " Credit= '" + Update_item + "'";
                                break;
                            }
                        case "Cnum":
                            {
                                Update_str += "Cnum = '" + Update_item + "'";
                                break;
                            }
                        case "Ctime":
                            {
                                Update_str += "Ctime = '" + Update_item + "'";
                                break;
                            }
                        case "Tno":
                            {
                                Update_str += "Tno = '" + Update_item + "'";
                                break;
                            }
                        case "Ctype":
                            {
                                Update_str += "Ctype= '" + Update_item + "'";
                                break;
                            }
                        case "Croom":
                            {
                                Update_str += "Croom = '" + Update_item + "'";
                                break;
                            }
                        default:
                            {
                                flag1 = 1;
                                MessageBox.Show("请选择你要修改的项!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                break;
                            }
                    }
                    if (flag1 == 0)
                    {
                        Update_str += " Where Cno = '" + Update_by_cno + "'";
                        SqlCommand cmd = new SqlCommand(Update_str, conn); //实例化数据库命令对象
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                catch
                {
                    flag2 = 1;
                    MessageBox.Show("输入数据有误，请输入有效数据！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close(); //释放
                }
                if (flag2 == 0)
                {
                    MessageBox.Show("修改成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox3.Text = null;
                    textBox4.Text = null;
                    comboBox1.Text = null;
                    Load_datagridview1();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            F21_AddCourse f = new F21_AddCourse();
            f.ShowDialog();
        }

        public class ClassRoom_NO   //传递教室编号
        {
            public static string classroom_no; 
        }
        public string i;
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) /***双击课程信息行任意位置显示教室位置信息***/
        {
            string i = dataGridView1.Rows[this.dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();  //获取当前行"上课教室"属性列的列值
            ClassRoom_NO.classroom_no = i;
            教室平面图2 f = new 教室平面图2();
            f.ShowDialog();
        }

        private void 删除课程ToolStripMenuItem_Click(object sender, EventArgs e)  /***右击删除课程***/
        {
            string cno;
            int row = this.dataGridView1.CurrentRow.Index;
            cno = dataGridView1.SelectedCells[0].Value.ToString();
            DialogResult result = MessageBox.Show("您确定删除该课程信息？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[row]);
                string sql = "delete from Course where Cno='" + cno + "'";
                Zon zon = new Zon();
                zon.Excute(sql);
                MessageBox.Show("删除成功！", "提示");
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)  /***右击行任意位置选中行***/
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
                        Cms_DeleteCourse.Show(MousePosition.X, MousePosition.Y);
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
    

