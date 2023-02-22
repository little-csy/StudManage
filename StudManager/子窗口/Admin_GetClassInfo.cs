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
    public partial class Admin_GetClassInfo : Form
    {
        public Admin_GetClassInfo()
        {
            InitializeComponent();
        }

        private void Admin_GetClassInfo_Load(object sender, EventArgs e)
        {

        }
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
        private void button1_Click(object sender, EventArgs e)    /***查询所有班级信息***/
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();        
            string sql = "select *from ClassInfo";          
            SqlDataAdapter dr = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "班级号";
            dataGridView1.Columns[1].HeaderText = "院系代号";
            dataGridView1.Columns[2].HeaderText = "班主任工作证号";
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)   /***按班级号查询班级信息***/
        {           
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string classno = textBox1.Text.Trim();
            string sql = "select *from ClassInfo where ClassNO= '"+classno+"'";         
            SqlDataAdapter dr = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "班级号";
            dataGridView1.Columns[1].HeaderText = "院系代号";
            dataGridView1.Columns[2].HeaderText = "班主任工作证号";
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)   /***按班级号修改班级信息***/ 
        {
            SqlConnection conn = new SqlConnection(str);
            String Update_by_no =comboBox2.Text.Trim();
            String Item_name = comboBox1.SelectedItem.ToString();
            String Update_item = textBox3.Text.Trim();
            int flag1 = 0;  //该变量表示组合框是否选中项
            int flag2 = 0; //该变量表示是否修改成功
            if (comboBox2.Text == null || comboBox1.Text == null || textBox1.Text == null)
            {
                MessageBox.Show("请输入需要更改班级的完整信息！", "提示");
            }
            else if (comboBox2.Text != null || comboBox1.Text != null || textBox1.Text != null)
            {
                try
                {
                    conn.Open();
                    String Update_str = "UPDATE ClassInfo SET ";
                    switch (Item_name)
                    {
                        case "Tno":
                            {
                                Update_str += "Tno = '" + Update_item + "'";
                                break;
                            }                    
                        default:
                            {
                                flag1 = 1;
                                MessageBox.Show("请选择你要修改的项!", "Tips", MessageBoxButtons.OK);
                                break;
                            }
                    }
                    if (flag1 == 0)
                    {
                        Update_str += " Where ClassNO = '" + Update_by_no + "'";
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
                    comboBox1.Text = null;
                    comboBox2.Text = null;
                    textBox3.Text = null;
                }
            }
        }       
        private void button5_Click(object sender, EventArgs e)   /***添加班级信息***/
        {
            Admin_AddClassInfo s = new Admin_AddClassInfo();
            s.ShowDialog();
        }

        private void 删除信息ToolStripMenuItem_Click(object sender, EventArgs e)  /***删除班级信息***/
        {
            int row = this.dataGridView1.CurrentRow.Index;
            string classno = dataGridView1.SelectedCells[0].Value.ToString();
            DialogResult result = MessageBox.Show("您确定删除该班级信息？", "Tips", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.dataGridView1.Rows.Remove(this.dataGridView1.Rows[row]);
                string sql = "delete from ClassInfo where ClassNO='" + classno + "'";
                Zon zon = new Zon();               
                zon.Excute(sql);                              
                MessageBox.Show("删除成功！", "提示");
                
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
            
        }
    }
}
    
    
