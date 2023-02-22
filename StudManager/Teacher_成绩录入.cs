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
    public partial class Teacher_成绩录入 : Form
    {
        public Teacher_成绩录入()
        {
            InitializeComponent();
        }
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";           
        private void Teacher_成绩录入_Load(object sender, EventArgs e)  //选修登录系统教师课程的学生名单
        {          
            string Tea_tno = UserName.User_name;
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select SC.Sno,Student.Sname, SC.Cno, Course.Cname, SC.Tno, SC.Grade from SC ,Course,Student where Course.Cno=SC.Cno and SC.Tno='" + Tea_tno + "' and SC.Sno=Student.Sno";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "学生学号";
            dataGridView1.Columns[1].HeaderText = "学生姓名";
            dataGridView1.Columns[2].HeaderText = "课程号";
            dataGridView1.Columns[3].HeaderText = "课程名";
            dataGridView1.Columns[4].HeaderText = "教师工号";
            dataGridView1.Columns[5].HeaderText = "成绩";
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)  /***成绩录入***/
        {
            SqlConnection conn = new SqlConnection(str);
            string str_Grade = dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[5].Value.ToString();
            //获取当前单元格所在行第一个单元格的值--学号
            string str_sno = dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //获取当前单元格所在行第三个单元格的值--课程号
            string str_cno = dataGridView1.Rows[this.dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();
            //获取当前单元格所在行第五个单元格的值--教师工号          
            string sql1 = "select * from SC where Sno='" + str_sno + "' and Cno='" + str_cno + "'";           
            conn.Open();
            Zon zon = new Zon();
            zon.command(sql1);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);//初始化SQL命令对象
            SqlDataReader sdr = cmd1.ExecuteReader(); //执行命令并取出结果                                                         
                if (sdr.HasRows) //查询结果存在
                {
                    sdr.Close();
                    string sql2 = "select * from SC where Sno = '" + str_sno + "'and  Cno='" + str_cno + "' and Grade is NULL";             
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);               
                    SqlDataReader sdr2 = cmd2.ExecuteReader(); //执行命令并取出结果                                          
                    if (sdr2.HasRows)
                    {               
                        sdr2.Close();
                        string sql3 = "update SC set Grade = '" + str_Grade + "' where Sno = '" + str_sno + "' and Cno = '" + str_cno + "'";                       
                        zon.command(sql3); 
                        int i = zon.Excute(sql3);
                        if (i>0)
                        {
                            MessageBox.Show("成绩录入成功！", "Tips", MessageBoxButtons.OK);
                            conn.Close();
                        }                                      
                                           
                    }
             
                }
                
           }
                                    
      }
        
}
    


    


