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
    public partial class F21_ad : Form
    {
        private static string strConn = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;Persist Security Info=True;User ID=sa;Password=hg0101ly";
        private SqlConnection conn = new SqlConnection(strConn);
        private string sqlId = "";
        private SqlCommand cmd = null;
      

        public F21_ad()
        {
            InitializeComponent();
        }

        private void F21_ad_Load(object sender, EventArgs e)
        {
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
        /// <summary>
        /// 添加学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)   /***添加学生信息***/
        {
            string SNO = txtSno.Text;
            string SName = txtSname.Text;
            string SSex = txtSex.Text;
            string SBirth = textBox5.Text;
            string Classno = textBox4.Text;      
            if (string.IsNullOrEmpty(SNO)&&string.IsNullOrEmpty(SName))
            {
                MessageBox.Show("请输入学号和姓名！", "添加学号提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            try
            {
                
                string sql = "Insert into Student(Sno,Sname,Ssex,Sbirth,ClassNo)values('" + SNO + "','" + SName + "','" + SSex + "','" + SBirth + "','" + Classno + "')";
                string sql1 = "Select *from Student Where Sno='" + SNO + "'";
                Zon zon = new Zon();
                zon.command(sql1);
                IDataReader dr = zon.Read(sql1);
                if (dr.Read())
                {
                    MessageBox.Show("该学生信息已经存在！", "提示", MessageBoxButtons.OK);
                    dr.Close();
                }
                else
                {
                    zon.command(sql);
                    int i = zon.Excute(sql);
                    if (i > 0)
                    {
                        MessageBox.Show("添加成功！", "提示");
                        txtSno.Text = "";
                        txtSname.Text = "";
                        txtSex.Text = "";
                        textBox5.Text = "";
                        textBox4.Text = "";

                    }
                }
            }
            catch
            {
                MessageBox.Show("未知错误！", "提示");
            }                                                   
            finally
            {
               
            }
        }          
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                button1_Click(sender, e);
            }
        }
    }
}

            
        

        
    




            