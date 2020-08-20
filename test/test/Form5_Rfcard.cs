using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form5_Rfcard : Form
    {
        public Form5_Rfcard()
        {
            InitializeComponent();
        }

        //Json数据的格式处理方式
        JsonSerializerSettings setting = Public_MethodClass.JsonVert();


        //1.初始化
        private void button1_Click(object sender, EventArgs e)
        {
            int cmd = 1;
            //给云平台发送改变的控制信息
            var qry = Class1.SDK.Cmds(107494, "LFInit", cmd, Class1.Token);
        }

        //2.读取卡号
        private void button2_Click(object sender, EventArgs e)
        {
            //执行模糊查询传感器数据
            Public_MethodClass.Fuzzy_QuerySensorData(107494, "IDRead", "2020-07-13 17:39:00");

            //解析json数据
            String Jsondata = Public_MethodClass.SerializeToJson(Public_MethodClass.qry); //序列化
            SensorDataObject.Root datas = JsonConvert.DeserializeObject<SensorDataObject.Root>(Jsondata, setting); //反序列化

            textBox2.Text = datas.ResultObj.DataPoints[0].PointDTO[0].Value.ToString();
        }

        //3.读取数据
        private void button3_Click(object sender, EventArgs e)
        {
            Public_MethodClass.Fuzzy_QuerySensorData(107494, "IDInforRead", "2020-07-13 17:39:00");

            //解析json数据
            String Jsondata = Public_MethodClass.SerializeToJson(Public_MethodClass.qry); //序列化
            SensorDataObject.Root datas = JsonConvert.DeserializeObject<SensorDataObject.Root>(Jsondata, setting); //反序列化

            textBox3.Text = datas.ResultObj.DataPoints[0].PointDTO[0].Value.ToString();
        }

        //4.写入数据
        private void button4_Click(object sender, EventArgs e)
        {          
            string data  = textBox4.Text.Trim();
            //给云平台发送改变的控制信息
            var qry = Class1.SDK.Cmds(107494, "IDInforWrite", data, Class1.Token);
        }

        //返回到菜单
        private void button5_Click(object sender, EventArgs e)
        {
            new menu().Show(); //返回到菜单界面
            this.Hide(); //关闭当前的窗口
        }
    }
}
