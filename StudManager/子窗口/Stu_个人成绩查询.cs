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
    public partial class Stu_个人成绩查询 : Form
    {
        public Stu_个人成绩查询()
        {
            InitializeComponent();
        }
        string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
        private void Stu_个人成绩查询_Load(object sender, EventArgs e)
        {    
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string Stu_sno = UserName.User_name;
            string sql = "select SC.Cno,Course.Cname,Course.Credit,SC.Grade,Course.Ctype,Course.Tno,SC.Crank,SC.CGPA,SC.CRG from SC,Course where Course.Cno=SC.Cno and SC.Sno='" + Stu_sno + "' and SC.Grade is not null";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "课程号";
            dataGridView1.Columns[1].HeaderText = "课程名";
            dataGridView1.Columns[2].HeaderText = "课程学分";
            dataGridView1.Columns[3].HeaderText = "成绩";
            dataGridView1.Columns[4].HeaderText = "课程类型";
            dataGridView1.Columns[5].HeaderText = "授课教师工作证";
            dataGridView1.Columns[6].HeaderText = "等级";
            dataGridView1.Columns[7].HeaderText = "绩点";
            dataGridView1.Columns[8].HeaderText = "学分绩点";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Stu_sno = UserName.User_name;          
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string sql = "Select AVG_GPA from SC Where Sno='" + Stu_sno + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);           
            DataSet ds = new DataSet();
            da.Fill(ds);
            textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
            conn.Close();

        }

    }

}
