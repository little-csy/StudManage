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
using System.Configuration;
using static STUManagement.Form1;



namespace STUManagement.子窗口
{
    public partial class Tea_成绩录入_录入成绩 : Form
    {
        public Tea_成绩录入_录入成绩()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            foreach (Control ct in this.Controls)
            {
                TextBox tx = ct as TextBox;
                if (tx != null)
                {
                    tx.KeyDown += (sender, e_args) =>
                    {
                        if (e_args.KeyCode == Keys.Enter)
                        {
                            this.SelectNextControl(tx, true, true, false, true);
                        }

                    };
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
            String Stu_sno = textBox1.Text.Trim();
            String Stu_cno = textBox2.Text.Trim();
            String Stu_grade = textBox3.Text.Trim();
            String sql1 = "select * from SC where Sno = '" + Stu_sno + "'and Cno='" + Stu_cno + "'";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql1, conn);//初始化SQL命令对象
            SqlDataReader sdr = cmd.ExecuteReader(); //执行命令并取出结果
            if (sdr.HasRows) //查询结果存在
            {
                sdr.Close();
                String sql2 = "select * from SC where Sno = '" + Stu_sno + "'and  Cno='" + Stu_cno + "' and Grade is NULL";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);//初始化SQL命令对象
                SqlDataReader sdr2 = cmd2.ExecuteReader(); //执行命令并取出结果
                if (sdr2.HasRows) //查询结果存在
                {
                    sdr2.Close();
                    String sql3 = "update SC set Grade = '" + Stu_grade + "' where Sno = '" + Stu_sno + "' and Cno = '" + Stu_cno + "'";
                    SqlCommand sqlCommand3 = new SqlCommand(sql3, conn);
                    SqlDataReader sdr3 = sqlCommand3.ExecuteReader();                                                         
                    MessageBox.Show("成绩录入成功！", "Tips", MessageBoxButtons.OK);
                    textBox1.Text = null;
                    textBox2.Text = null;
                    textBox3.Text = null;
                    this.Close();
                    conn.Close();
                   
                }
                else
                {
                    MessageBox.Show("成绩已存在，不能修改！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("该选课记录不存在！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

        }

        

        private void Tea_成绩录入_录入成绩_Load(object sender, EventArgs e)
        {

        }
    }
}
    
    































