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

    public partial class F2_GetStuInfo : Form
    {
        public int id { get; private set; }

        public F2_GetStuInfo()
        {
            InitializeComponent();
        }
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
        /// <summary>
        /// 查询学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)    /***查询所有学生信息***/
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "select * from Student";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "出生年月";
            dataGridView1.Columns[4].HeaderText = "班级";
            conn.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)   /***按学号查询学生信息***/
        {
            SqlConnection conn = new SqlConnection(str); 
            conn.Open(); 
            string sql = "select * from Student where Sno='" + textBox1.Text + "'";
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入学号！", "提示");
            }
            else
            {
                sql = string.Format(sql, textBox1.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn); 
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "学号";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "出生年月";
                dataGridView1.Columns[4].HeaderText = "班级";
                conn.Close();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)  /***按姓名查询学生信息***/
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入姓名！", "提示");
            }
            else if (textBox2.Text != "")
            {
                string sql = "select * from Student where Sname like '%" + textBox2.Text + "%'";
                sql = string.Format(sql, textBox2.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn); 
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "出生年月";
                dataGridView1.Columns[4].HeaderText = "班级";
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)   /***按班级查询学生信息***/
        {
            SqlConnection conn = new SqlConnection(str); 
            conn.Open();
            string sql = "select * from Student where ClassNo='" + textBox3.Text + "'";
            sql = string.Format(sql, textBox3.Text);
            if (textBox3.Text == "")
            {
                MessageBox.Show("请输入班级号！", "提示");
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "学号";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "出生年月";
                dataGridView1.Columns[4].HeaderText = "班级";
                conn.Close();
            }
         
        }         
        private void QueryAllCourse()
        {
            throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)   /***根据学生学号修改学生信息***/
        {
            SqlConnection conn = new SqlConnection(str);
            String Update_by_sno = textBox4.Text.Trim();
            String Item_name = comboBox1.SelectedItem.ToString();
            String Update_item = textBox5.Text.Trim();
            int flag1 = 0; 
            int flag2 = 0; 
            if (string.IsNullOrEmpty(Update_by_sno) && string.IsNullOrEmpty(Item_name) && string.IsNullOrEmpty(Update_item))
            {
                MessageBox.Show("请输入需要修改的完整信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBox4.Text != null && textBox5.Text != null && comboBox1.Text != null)
            {
                try
                {
                   conn.Open();
                    String Update_str = "UPDATE Student SET ";
                    switch (Item_name)
                    {
                        case "Sname":
                            {
                                Update_str += "Sname = '" + Update_item + "'";
                                break;
                            }
                        case "Sbirth":
                            {
                                Update_str += "Sbirth = '" + Update_item + "'";
                                break;
                            }
                        case "ClassNo":
                            {
                                Update_str += "ClassNo = '" + Update_item + "'";
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
                        Update_str += " Where Sno = '" + Update_by_sno + "'";
                        Zon zon = new Zon();
                        zon.command(Update_str);
                        SqlCommand cmd = new SqlCommand(Update_str, conn); 
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
                    conn.Close();
                }
                if (flag2 == 0)
                {
                    MessageBox.Show("修改成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBox4.Text = null;
                    textBox5.Text = null;
                    comboBox1.Text = null;
                }
            }
            else
            {
                MessageBox.Show("请输入需要修改的完整信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void button7_Click(object sender, EventArgs e)     /***添加学生信息***/
        {
            F21_ad f = new F21_ad();
            f.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)     /***重置查询文本***/
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)   /***右击删除学生信息***/
        {
            int row = this.dataGridView1.CurrentRow.Index;
            string sno = dataGridView1.SelectedCells[0].Value.ToString();
            string sname = dataGridView1.SelectedCells[1].Value.ToString();                                
            DialogResult result = MessageBox.Show("您确定删除该学生信息？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[row]);
                    string sql = "delete from Student where Sno='" + sno + "'and Sname='" + sname + "'";
                    Zon zon = new Zon();
                    zon.Excute(sql);
                }
                else if(result==DialogResult.Cancel)
                {
                  return;
                }
                
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)  /***右击行中任意位置选中行***/
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
                        Cms_DeleteStuInfo.Show(MousePosition.X, MousePosition.Y);
                    }
                }
            }

            catch
            {
                MessageBox.Show("未选中学生！", "提示");
            }
            finally
            {

            }
        }
    }
}
    
    

        
    
    
    
    

