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
    public partial class F2_Teacher : Form
    {
        public F2_Teacher()
        {
            InitializeComponent();
        }

        private void 查询个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 查询个人信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string User_name = UserName.User_name;
            string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";
            SqlConnection conn = new SqlConnection(str); 
            conn.Open();
            string sql = "select * from Teacher where Tno='" + User_name + "'";
            sql = string.Format(sql, User_name);
            //创建SqlDataAdapter类的对象
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //创建DataSet类的对象
            DataSet ds = new DataSet();
            //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
            sda.Fill(ds);          
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "工作证号";
            dataGridView1.Columns[1].HeaderText = "姓名";
            dataGridView1.Columns[2].HeaderText = "职称";
            dataGridView1.Columns[3].HeaderText = "联系电话";
            dataGridView1.Columns[4].HeaderText = "所属院系";

            conn.Close(); 
        }

        private void 查询学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form_TeaGetStuInfo F2_GetStuInfo  = new Form_TeaGetStuInfo();
            F2_GetStuInfo.ShowDialog();

        }

        private void F2_Teacher_Load(object sender, EventArgs e)
        {

        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_成绩录入 f = new Teacher_成绩录入();
            f.ShowDialog();
        }

        private void 修改个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher_ModifyInfo f = new Teacher_ModifyInfo();
            f.ShowDialog();
        }

        private void 查询课表信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tea_GetCoursecs f = new Tea_GetCoursecs();
            f.ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
;