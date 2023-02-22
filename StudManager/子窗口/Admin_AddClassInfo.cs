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
    public partial class Admin_AddClassInfo : Form
    {
        public Admin_AddClassInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加班级信息
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {          
            string Classno = textBox1.Text ;
            string dno= textBox2.Text;
            string tno = textBox3.Text;
            if (string.IsNullOrEmpty(Classno)|| string.IsNullOrEmpty(dno) || string.IsNullOrEmpty(tno))  //判断输入信息是否为空
            {
                MessageBox.Show("请输入完整的班级信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {                 
                    string sql = "Insert into ClassInfo(ClassNO,Dno,Tno)values('" + Classno + "','" + dno + "','" + tno + "')";
                    string sql1 = "select * from ClassInfo where ClassNo='" + Classno + "'";
                    string sql2 = "select * from ClassInfo Where Tno='" + tno + "'";
                    Zon zon = new Zon();
                    IDataReader dr = zon.Read(sql1);
                    IDataReader dr1 = zon.Read(sql2);                 
                    if (dr.Read())   //判断班级信息表是否已存在待添加的班级号
                    {
                        MessageBox.Show("该班级已存在！", "提示");
                        dr.Close();
                    }

                    else if (dr1.Read())   //判断待添加的班主任工号是否已经存在
                    {
                        MessageBox.Show("您输入的教师已任职为某班班主任！", "提示");
                        dr1.Close();
                    }
                    else
                    {
                        zon.command(sql);
                        int i = zon.Excute(sql);  //返回是否已经插入成功
                        if (i > 0)
                        {
                            MessageBox.Show("添加成功!", "提示");
                            textBox1.Text = null;
                            textBox2.Text = null;
                            textBox3.Text = null;                                                  
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("您输入的班级信息不符合约束条件，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }
    }
}
