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
    public partial class F21_TeaInfo : Form
    {
        private static string strConn = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;Persist Security Info=True;User ID=sa;Password=hg0101ly";
        private SqlConnection conn = new SqlConnection(strConn);
        private string sqlId = "";
        private SqlCommand cmd = null;
        private SqlDataAdapter da = null;

        public F21_TeaInfo()
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
        private void F21_TeaInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TNO = textBox1.Text;
            string TName = textBox2.Text;
            string TTit = textBox3.Text;
            string TTel = textBox4.Text;
            string TDno = textBox5.Text;

            if (string.IsNullOrEmpty(TNO) && string.IsNullOrEmpty(TName))   //判断工号是否、姓名为空
            {
                MessageBox.Show("请输入教师工号和姓名！", "添加工号、学号提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {
                conn.Open();                
                sqlId = "Insert into Teacher(Tno,Tname,Ttit,Ttel,Dno)values(@Tno,@Tname,@Ttit,@Ttel,@Dno)";              
                SqlParameter[] parameters = new[]
                 {                  
                    new SqlParameter("@Tno",TNO),
                    new SqlParameter("@Tname",TName),
                    new SqlParameter("@Ttit",TTit),
                    new SqlParameter ("@Ttel",TTel),
                    new SqlParameter ("@Dno",TDno)

                 };
                cmd = conn.CreateCommand();               
                cmd.CommandText = sqlId;               
                cmd.Parameters.AddRange(parameters);
                int x = cmd.ExecuteNonQuery();
                if (x == 1)
                {                 
                    MessageBox.Show("添加成功!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
