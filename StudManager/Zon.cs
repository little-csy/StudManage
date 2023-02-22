using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace STUManagement
{
    class Zon
    {

        public SqlConnection connection()
        {
            string str = "server=DESKTOP-OS57E6J;database=StuInfoMG;Integrated Security=true;User ID=sa;Password=hg0101ly";
            SqlConnection sc = new SqlConnection(str);
            sc.Open(); //打开数据库连接
            return sc;

        }
        public SqlCommand command(string sql)
        {

            SqlCommand cmd = new SqlCommand(sql, connection());
            return cmd;
        }

        //用于删除、添加、修改，返回数据库操作受影响的行数
        public int Excute(string sql)  //返回受影响的行数
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader Read(string sql)
        {
            return command(sql).ExecuteReader();  //储存获取到的数据

        }

        internal IDataAdapter Read()
        {
            throw new NotImplementedException();
        }
    }
}

       

