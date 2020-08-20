using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using NLECloudSDK;
using NLECloudSDK.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Public_MethodClass
    {
        public static dynamic qry;

        //把获取到的数据转换成json序列化
        public static String SerializeToJson(Object data)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);
        }

        //Json数据的格式处理方式
        public static JsonSerializerSettings JsonVert()
        {
            //json数据转换函数
            JsonSerializerSettings setting = new JsonSerializerSettings();
            JsonConvert.DefaultSettings = new Func<JsonSerializerSettings>(() =>
            {
                //日期类型默认格式化处理
                setting.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
                setting.DateFormatString = "yyyy-MM-dd HH:mm:ss";

                //空值处理
                setting.NullValueHandling = NullValueHandling.Ignore;

                //高级用法九中的Bool类型转换 设置
                //    setting.Converters.Add(new BoolConvert("是,否"));

                return setting;
            });
            return setting;
        }


        /*表格单纯显示出所有的数据库数据，不分页（只需要窗体中有一个dataGridView1就行了）
        public void list_show()
        {
            //Ip+端口+数据库名+用户名+密码
            string connectStr = "server=127.0.0.1;port=3306;database=test01;user=root;password=root;SslMode=none;";
            MySqlConnection conn = new MySqlConnection(connectStr); ;
            conn.Open();//跟数据库建立连接，并打开连接

            string sql = "select * from test01_tb_light";//MySql语句，查询列表内容
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd); //数据适配器
            DataSet ds = new DataSet();  //DataSet表示数据在内存中的缓存
            sda.Fill(ds, "光照表格");//适配器匹配数据
           

            dataGridView1.DataSource = ds;  //dataGridView1的数据来源设为ds
            dataGridView1.DataMember = "光照表格";  //绑定ds的表名
            dataGridView1.Columns[1].HeaderText = "光照强度"; //改列名称
            dataGridView1.Columns[2].HeaderText = "记录时间"; //改列名称
            int count = dataGridView1.RowCount; //总行数
            for(int i = 0;i < count - 1;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1; //id列显示成序列号，从1开始
            }

            conn.Close(); //关闭数据库连接
            conn.Dispose(); //释放资源
        }
        */

        //模糊查询传感数据
        public static void Fuzzy_QuerySensorData(Int32 deviceId, String apiTag, String startDate)
        {
            //模糊查询传感数据。===================请修改为自己的设备ID,传感标识名ApiTag
            var query2 = new SensorDataFuzzyQryPagingParas()
            {
                DeviceID = deviceId,
                Method = 6,
                //TimeAgo = 30,
                //ApiTags = "m_waterPH,m_waterNTU,m_waterConduct",
                ApiTags = apiTag,
                StartDate = startDate,
                Sort = "DESC", //时间排序方式--倒序
                PageSize = 30,
                PageIndex = 1
            };
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            qry = Class1.SDK.GetSensorDatas(query2, Class1.Token);
            sw.Stop();
            //var tmp = ((ResultMsg<SensorDataInfoDTO>)qry);
            //if (tmp.IsSuccess() && tmp.ResultObj != null)
            //{
            //    Console.WriteLine("查询传感数据返回JSON:" + Environment.NewLine);
            //    Console.WriteLine(SerializeToJson(qry) + Environment.NewLine);
            //}

        }

        //获取设备最新数据
        public static void GetDevice_NewData(Int32 deviceId)
        {
            String devIds = deviceId.ToString();
            qry = Class1.SDK.GetDevicesDatas(devIds, Class1.Token);
        }
    }
}
