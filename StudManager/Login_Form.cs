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

namespace STUManagement
{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
        }                   
       
        private void Form1_Load(object sender, EventArgs e)
        {

        } 
        /// <summary>
        /// 静态类，存储用户登录的用户名
        /// </summary>
        public class UserName
        {
            public static string User_name ;

        }     
        /// <summary>
        /// 登录界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void button1_Click(object sender, EventArgs e)   //登录按钮
        {
            UserName.User_name = textBox1.Text; 
            string Username = this.textBox1.Text;
            string password = this.textBox2.Text;

            if (Username.Equals("") || password.Equals(""))//用户名或密码为空
            {
                MessageBox.Show("用户名或密码不能为空!","Tips");
            }
            else if (radioButton3.Checked == true)   //若登录用户为管理员
            {              
                string sql = "Select * from User_Admin where Username='" + Username + "' and Password='" + password + "'";               
                Zon zon = new Zon();  //数据库操作类
                zon.command(sql);
                IDataReader dr = zon.Read(sql);
                if (dr.Read())
                {                          
                    MessageBox.Show("登录成功!", "提示",MessageBoxButtons.OK);
                    F2_Admin f = new F2_Admin();
                    f.ShowDialog();
                    this.Hide();
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "提示",MessageBoxButtons.OK);
                    return;
                }

            }                              
            else if (radioButton1.Checked == true)   //若登录用户为学生
            {  
                string sql = "Select * from User_Stu where Username='" + Username + "' and Password='" + password + "'";             
                Zon zon = new Zon();
                IDataReader dr = zon.Read(sql);
                if (dr.Read())
                {                 
                    MessageBox.Show("登录成功!", "提示",MessageBoxButtons.OK);
                    F2_Student f1 = new F2_Student();
                    f1.ShowDialog();
                    this.Hide();
                    dr.Close();                  
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;
                }
            }
            else if (radioButton2.Checked == true)  //若登录用户为教师
            {                             
                string sql = "Select * from User_Tea where Username='" + Username + "' and Password='" + password + "'";
                Zon zon = new Zon();
                IDataReader dr = zon.Read(sql);                           
                if (dr.Read())
                {                  
                    MessageBox.Show("登录成功!", "提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    F2_Teacher f3 = new F2_Teacher();
                    f3.ShowDialog();
                    this.Hide();
                    dr.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误!", "提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            }
      
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
                
            if (e.KeyCode == Keys.Enter)
                {                   
                  this.SelectNextControl(this.ActiveControl, true, true, true, true); 
                }
            }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void radioButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }

        private void radioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }

        private void radioButton3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
    }  
}
    

