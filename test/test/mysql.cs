using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace test
{
  
    class mysql
    {

        public static void Insert(double Value, string RecordTime)//插入
        {
            //Ip+端口+数据库名+用户名+密码
            string connectStr = "server=127.0.0.1;port=3306;database=test01;user=root;password=root;";
            MySqlConnection conn = new MySqlConnection(connectStr); ;
            try
            {
                conn.Open();//跟数据库建立连接，并打开连接
                string sql = "insert into test01_tb_light(id,light,datetime) value(null, '" + Value + "', '" + RecordTime + "')";//DateTime.Now调用时间
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();//插入 删除 修改
                
                int result = cmd.ExecuteNonQuery();//插入 删除 返回值是数据库中受影响的数据的行数
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Clone();
            }
        }


        public static double ReadMax()
        {
            //Ip+端口+数据库名+用户名+密码
            string connectStr = "server=127.0.0.1;port=3306;database=test01;user=root;password=root;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connectStr); ;
            
            try//使用try关键字
            {
                conn.Open();//跟数据库建立连接，并打开连接
                string sql = "select max(light) from test01_tb_light";//MySql语句，查询列表内容
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                
                Object result1 = cmd.ExecuteScalar();//执行查询
                Console.WriteLine("光照最大值为： " + result1);
                Class1.light_max = double.Parse(result1.ToString());  //读取中光照最小值

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Clone();
            }
            return Class1.light_max;
        }

        
        public static double ReadMin()
        {
            //Ip+端口+数据库名+用户名+密码
            string connectStr = "server=127.0.0.1;port=3306;database=test01;user=root;password=root;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connectStr); ;

            try//使用try关键字
            {
                conn.Open();//跟数据库建立连接，并打开连接
                string sql = "select min(light) from test01_tb_light";//MySql语句，查询列表内容
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                Object result2 = cmd.ExecuteScalar();//执行查询
                Console.WriteLine("光照最小值为： " + result2);
                Class1.light_min = double.Parse(result2.ToString());  //读取中光照最小值

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                conn.Clone();
            }
            return Class1.light_min;
        }




    }
}
