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
    public partial class Form_TeaGetStuInfo : Form
    {
        public Form_TeaGetStuInfo()
        {
            InitializeComponent();
        }
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
        /// <summary>
        /// 查询所有学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str); //创建SqlConnection的实例//打开数据库
            conn.Open();
            string sql = "select * from Student";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  //创建SqlDataAdapter类的对象
            DataSet ds = new DataSet();//创建DataSet类的对象
            sda.Fill(ds);//使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
            dataGridView1.DataSource = ds.Tables[0];//设置表格控件的DataSource属性
            dataGridView1.Columns[0].HeaderText = "学号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "性别";
            dataGridView1.Columns[3].HeaderText = "出生年月";
            dataGridView1.Columns[4].HeaderText = "班级";
            conn.Close();
        }

        
        /// <summary>
        /// 按模糊姓名查询学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str); 
            conn.Open();
            string sql = "select * from Student where Sname like'%" + textBox2.Text + "%'";
            sql = string.Format(sql, textBox2.Text);
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入姓名！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

            else if (dr.Read())
            {
                dr.Close();               
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  //创建SqlDataAdapter类的对象
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "学号";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "出生年月";
                dataGridView1.Columns[4].HeaderText = "班级";
            }
            else if (!dr.Read())
            {
                MessageBox.Show("您输入的学生姓名不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            conn.Close();
        }  

        /// <summary>
        /// 按班级查询学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str); //创建SqlConnection的实例
            conn.Open();
            string sql = "select * from Student where ClassNo ='" + textBox3.Text + "'";         
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr= cmd.ExecuteReader();
            if (textBox3.Text == "")
            {
                MessageBox.Show("请输入班级号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               
            }
            else if (!dr.Read())
            {
                MessageBox.Show("不存在该班级！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (dr.Read())
            {
                dr.Close();
                sql = string.Format(sql, textBox3.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  //创建SqlDataAdapter类的对象
                DataSet ds = new DataSet();//创建DataSet类的对象
                sda.Fill(ds);//使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "学号";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "出生年月";
                dataGridView1.Columns[4].HeaderText = "班级";
                
            }
            conn.Close();

        }

        private void Form_TeaGetStuInfo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {        
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "select * from Student where Sno='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入学号！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            else if (dr.Read())
            {
                dr.Close();
                sql = string.Format(sql, textBox1.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);  //创建SqlDataAdapter类的对象
                DataSet ds = new DataSet();//创建DataSet类的对象
                sda.Fill(ds);//使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "学号";
                dataGridView1.Columns[1].HeaderText = "姓名";
                dataGridView1.Columns[2].HeaderText = "性别";
                dataGridView1.Columns[3].HeaderText = "出生年月";
                dataGridView1.Columns[4].HeaderText = "班级";
             

            }
            else if (!dr.Read())
            {
                MessageBox.Show("您输入的学号有误或该学生不存在！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox2.Text = null;
        }
    }
}
          
          
        
    


