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
    public partial class Add_Teacher_UserInfo : Form
    {
        public Add_Teacher_UserInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Tea_tno = textBox1.Text;
            string Tea_password = textBox2.Text;
            if (string.IsNullOrEmpty(Tea_tno) || string.IsNullOrEmpty(Tea_password))
            {
                MessageBox.Show("请输入用户名和密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    string sql = "Insert INTO User_Tea(Username,Password)Values('" + Tea_tno + "','" + Tea_password + "')";
                    string sql1 = "select * from User_Tea where Username='" + Tea_tno + "'";
                    string sql2 = "select * from Teacher Where Tno='" + Tea_tno + "'";
                    Zon zon = new Zon();
                    IDataReader dr = zon.Read(sql1);
                    IDataReader dr2 = zon.Read(sql2);
                    if (dr.Read())
                    {
                        MessageBox.Show("该教师用户已存在！", "提示");
                        dr.Close();
                    }

                    else if (!dr2.Read())
                    {
                        MessageBox.Show("该教师不存在！", "提示");
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
