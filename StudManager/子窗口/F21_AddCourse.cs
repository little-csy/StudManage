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
    public partial class F21_AddCourse : Form
    {

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
       
      
        public F21_AddCourse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)    /***添加课程信息***/
        {
            string CNO = textBox1.Text;
            string CName = textBox2.Text;
            string CRedit = textBox3.Text;
            string CNum = textBox4.Text;
            string CTime = textBox5.Text;
            string TNo= textBox6.Text;
            string CType = comboBox1.Text;
            String CRoom = textBox8.Text;          

            if (string.IsNullOrEmpty(CNO) && string.IsNullOrEmpty(CName))
            {
                MessageBox.Show("请输入课程号和课程名！", "添加提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {              
                string sql = "Insert into Course(Cno,Cname,Credit,Cnum,Ctime,Tno,Ctype,Croom)values('" + CNO + "','" + CName + "','" + CRedit + "','" + CNum + "','" + CTime + "','" + TNo + "','" + CType + "','" + CRoom + "')";
                string sql1 = "select *from Course Where Cno='" + CNO + "' and Tno='" + TNo + "'";
                Zon zon = new Zon();
                zon.command(sql1);
                IDataReader dr = zon.Read(sql1);
                if (dr.Read())
                {
                    MessageBox.Show("该课程已经存在，请勿重复添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    zon.command(sql);
                    int i = zon.Excute(sql);
                    if(i>0)
                    {
                        MessageBox.Show("添加课程成功！", "提示");
                        textBox1.Text = null;
                        textBox2.Text = null;
                        textBox3.Text = null;
                        textBox4.Text = null;
                        textBox5.Text = null;
                        textBox6.Text = null;
                        comboBox1.Text = null;
                        textBox8.Text = null;
                    }
                }                                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现错误！" + ex.Message);
            }

            finally
            {
                
            }
        }

        private void F21_AddCourse_Load(object sender, EventArgs e)
        {
            
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
        private void button16_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button16.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button8.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button13.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button12.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button14.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button15.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button17.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button18.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button19.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button20.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.textBox8.Text = this.button21.Text;
        }
    }
    }

