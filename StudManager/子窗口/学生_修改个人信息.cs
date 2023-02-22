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
    public partial class 修改个人信息 : Form
    {
        public 修改个人信息()
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
            SqlConnection conn = new SqlConnection(str);
            string Stu_sno = UserName.User_name;
            string Old_key = textBox1.Text.Trim();
            conn.Open();
            string sql = "select * from User_Stu Where Username='" + Stu_sno + "'and Password='" + Old_key + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;  //存储过程
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                sdr.Close();
                if (textBox2.Text.Trim() != null && textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    string sql2 = "UPDATE User_Stu Set Password='" + textBox2.Text.Trim() + "' where Username='" + Stu_sno + "'";
                    SqlCommand cmd1 = new SqlCommand(sql2, conn);
                    cmd1.ExecuteReader();
                    MessageBox.Show("密码修改成功！");
                    this.Close();
                }
                else if (textBox2.Text.Trim() != null && textBox2.Text.Trim() != textBox3.Text.Trim())
                {
                    MessageBox.Show("两次输入的密码不正确,请重新输入！");
                }
            }
        }

        private void 修改个人信息_Load(object sender, EventArgs e)
        {

        }
    }
}

