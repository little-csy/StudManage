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
    public partial class Form_GetTeacherInfo : Form
    {
        public Form_GetTeacherInfo()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// 查询教师信息
        /// </summary>
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
        private void button1_Click(object sender, EventArgs e)    /***查询所有教师信息***/
        {        
            SqlConnection conn = new SqlConnection(str); 
            conn.Open();
            string sql = "select * from Teacher";                     
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //创建DataSet类的对象
            DataSet ds = new DataSet();
            //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
            sda.Fill(ds);
            //设置表格控件的DataSource属性
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "教师工号";
            dataGridView1.Columns[1].HeaderText = "教师姓名";
            dataGridView1.Columns[2].HeaderText = "职称";
            dataGridView1.Columns[3].HeaderText = "联系电话";
            dataGridView1.Columns[4].HeaderText = "所属院系";
            conn.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)   /***按工号查询教师信息***/
        {
            SqlConnection conn = new SqlConnection(str); 
            conn.Open();
            string sql = "select * from Teacher where Tno='" + textBox2.Text + "'";
            sql = string.Format(sql, textBox2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  
            DataSet ds = new DataSet();//创建DataSet类的对象
            sda.Fill(ds);//使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "教师工号";
            dataGridView1.Columns[1].HeaderText = "教师姓名";
            dataGridView1.Columns[2].HeaderText = "职称";
            dataGridView1.Columns[3].HeaderText = "联系电话";
            dataGridView1.Columns[4].HeaderText = "所属院系";
            conn.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)     /***按姓名查询教师信息***/
        {          
            SqlConnection conn = new SqlConnection(str); 
            conn.Open();  
            string sql = "select * from Teacher where Tname='%" + textBox1.Text + "'%";
            sql = string.Format(sql, textBox1.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  //创建SqlDataAdapter类的对象
            DataSet ds = new DataSet();//创建DataSet类的对象
            sda.Fill(ds);//使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
            dataGridView1.DataSource = ds.Tables[0];//设置表格控件的DataSource属性
            dataGridView1.Columns[0].HeaderText = "教师工号";
            dataGridView1.Columns[1].HeaderText = "教师姓名";
            dataGridView1.Columns[2].HeaderText = "职称";
            dataGridView1.Columns[3].HeaderText = "联系电话";
            dataGridView1.Columns[4].HeaderText = "所属院系";
            conn.Close(); 
        }
                
        private void button5_Click(object sender, EventArgs e)   /***根据教师工号修改教师信息***/
        {
            SqlConnection conn = new SqlConnection(str);
            String Update_by_tno = textBox4.Text.Trim(); 
            String Item_name = comboBox1.SelectedItem.ToString();
            String Update_item = textBox3.Text.Trim();          
            int flag1 = 0;  //该变量表示组合框是否选中项
            int flag2 = 0; //该变量表示是否修改成功
            try
            {
                conn.Open();
                String Update_str = "UPDATE Teacher SET ";
                switch (Item_name)
                {
                    case "Tname": 
                        {
                            Update_str += "Tname = '" + Update_item + "'";
                            break;
                        }
                    case "Ttit":
                        {
                            Update_str += "Ttit = '" + Update_item + "'";
                            break;
                        }
                    case "Ttel":
                        {
                            Update_str += "Ttel = '" + Update_item + "'";
                            break;
                        }
                    case "Dno":
                        {
                            Update_str += "Dno = '" + Update_item + "'";
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
                    Update_str += " Where Tno = '" + Update_by_tno + "'";
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
                textBox3.Text = null;
                textBox4.Text = null;
                comboBox1.Text = null;
            }
        }

        /// <summary>
        /// 添加教师信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)  /***添加教师信息***/
        {
            F21_TeaInfo f = new F21_TeaInfo();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)   /***重置查询条件文本框***/
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        /// <summary>
        /// 删除教师信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cms_DeleteTeacherInfo_Click(object sender, EventArgs e)   /***右键删除教师信息***/
        {
            string tno;
            int row = this.dataGridView1.CurrentRow.Index;
            tno = dataGridView1.SelectedCells[0].Value.ToString();
            DialogResult result = MessageBox.Show("您确定删除该教师信息？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[row]);
                string sql = "delete from Teacher where Tno='" + tno + "'";
                Zon zon = new Zon();
                zon.Excute(sql);
                int i = zon.Excute(sql);
                if (i > 0)
                {
                    MessageBox.Show("删除成功！", "提示");
                }
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) /***右击行中任意位置选中行***/
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
                MessageBox.Show("未选中教师！", "提示");
            }
            finally
            {

            }
        }

        private void Form_GetTeacherInfo_Load(object sender, EventArgs e)
        {

        }
    }
    }

 

           
                       
                       
          
            

        
