using Newtonsoft.Json;
using System;
using System.Windows.Forms;


namespace test
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        //开始光照检测按键
        private void button1_Click(object sender, EventArgs e)
        {
            //Json数据的格式处理方式
            JsonSerializerSettings setting = Public_MethodClass.JsonVert();


            //模糊查询设备最新30条数据
            Public_MethodClass.Fuzzy_QuerySensorData(100059, "nl_light", "2020-07-15 19:42:08");

            //解析json数据
            String Jsondata = Public_MethodClass.SerializeToJson(Public_MethodClass.qry); //序列化
            SensorDataObject.Root datas = JsonConvert.DeserializeObject<SensorDataObject.Root>(Jsondata, setting); //反序列化

            /*
            for(int i = 0;i < 30;i++) //把数据存放进入数据库
            {
                double Value = datas.ResultObj.DataPoints[0].PointDTO[i].Value;
                String RecordTime = datas.ResultObj.DataPoints[0].PointDTO[i].RecordTime;
                mysql.Insert(Value, RecordTime);
            }
            */

            //用表格形式显示出数据库中的数据，不分页
            //list_show();
             new paging_listshow().Show();

            textBox1.Text = mysql.ReadMax().ToString();
            textBox2.Text = mysql.ReadMin().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new menu().Show(); //返回到菜单界面
            this.Hide(); //关闭当前的窗口
        }


        //点击停止光照检测则关闭表格窗口
        public static Form fm = null;
        private void button2_Click(object sender, EventArgs e)
        {
           if(fm == null)
            {
                paging_listshow p_l = new paging_listshow();
                p_l.Show();
            }
            else
            {
                fm.Hide();
                fm = null;
            }
            
        }
    }
}

