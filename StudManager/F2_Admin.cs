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
using STUManagement.子窗口;

namespace STUManagement
{

    public partial class F2_Admin : Form
    {
        
        public F2_Admin()
        {
            InitializeComponent();
        }
       

        

        private void 信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void 修改学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        

        private void F2_Admin_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }  
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }                                     
        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

       

        private void 修改个人密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_ModifyInfo f = new Admin_ModifyInfo();
            f.ShowDialog();
        }
      
        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Admin_GetClassInfo s = new Admin_GetClassInfo();
            s.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form_GetTeacherInfo f = new Form_GetTeacherInfo();
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            F2_GetStuInfo f = new F2_GetStuInfo();
            f.ShowDialog();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            S_Sc f = new S_Sc();
            f.ShowDialog();
        }

        private void 添加学生用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Stu_UserInfo f = new Add_Stu_UserInfo();
            f.ShowDialog();
        }

        private void 添加教师用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Teacher_UserInfo f = new Add_Teacher_UserInfo();
            f.ShowDialog();
        }
    }

}

