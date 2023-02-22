using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUManagement.子窗口
{
    public partial class Add_Stu_UserInfo : Form
    {
        public Add_Stu_UserInfo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 添加学生用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string Stu_sno = textBox1.Text;
            string Stu_password = textBox2.Text;
            if (string.IsNullOrEmpty(Stu_sno)||string.IsNullOrEmpty(Stu_password))
            {
                MessageBox.Show("请输入用户名和密码！", "提示", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else 
            {
                try
                {
                    string sql = "Insert INTO User_Stu(Username,Password)Values('" + Stu_sno + "','" + Stu_password + "')";
                    string sql1 = "select * from User_Stu where Username='" + Stu_sno + "'";
                    string sql2 = "select * from Student Where Sno='" + Stu_sno + "'";
                    Zon zon = new Zon();
                    IDataReader dr = zon.Read(sql1);
                    IDataReader dr2 = zon.Read(sql2);
                    if (dr.Read())
                    {
                        MessageBox.Show("该学生用户已存在！", "提示");
                        dr.Close();
                    }

                    else if (!dr2.Read())
                    {
                        MessageBox.Show("该学生不存在！", "提示");
                        dr2.Close();

                    }
                    else
                    {
                        zon.command(sql);
                        int i = zon.Excute(sql);
                        if (i > 0)
                        {
                            MessageBox.Show("添加成功！", "提示");
                            textBox1.Text = null;
                            textBox2.Text = null;
                        }
                    }

                }
                catch
                {                                
                    MessageBox.Show("您输入的信息不符合约束条件，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }          
                finally
                {

                }
            }           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            this.Close();
        }
    }
}
