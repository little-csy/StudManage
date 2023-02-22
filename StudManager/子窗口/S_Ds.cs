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
    public partial class S_Ds : Form
    {
        public S_Ds()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
              
                string str = "Data Source=DESKTOP-OS57E6J;Initial Catalog=StuInfoMG;User ID=sa;Password=hg0101ly";   SqlConnection conn = null;
                try
                {
                    conn = new SqlConnection(str);                 
                    conn.Open();
                    string sql = "select * from Department where Dno='" + textBox1.Text + "'";
                    sql = string.Format(sql, textBox1.Text);
                    //创建SqlDataAdapter类的对象
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    //创建DataSet类的对象
                    DataSet ds = new DataSet();
                    //使用SqlDataAdapter对象sda将查新结果填充到DataSet对象ds中
                    sda.Fill(ds);
                    //设置表格控件的DataSource属性
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现错误！" + ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                       
                        conn.Close();
                    }
                }
            }
        }

        private void S_Ds_Load(object sender, EventArgs e)
        {

        }
    }
}
