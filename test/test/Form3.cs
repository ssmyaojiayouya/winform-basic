using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace test
{
    public partial class Form3_temperature : Form
    {
        public Form3_temperature()
        {
            InitializeComponent();
        }

        SensorDataObject.Root datas;

        //返回到菜单
        private void button3_Click(object sender, EventArgs e)
        {
            new menu().Show(); //返回到菜单界面
            this.Hide(); //关闭当前的窗口
        }

        //1.开始温度检测
        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            MessageBox.Show("开始检测温度了！3s更新一次折线图！");
        }

        //2.停止温度检测
        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            MessageBox.Show("停止检测温度了！折线图不再更新！");
        }

        //每5s获取一次数据，即可5s更新一次折线图
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Json数据的格式处理方式
            JsonSerializerSettings setting = Public_MethodClass.JsonVert();
            //模糊查询设备最新30条数据
            Public_MethodClass.Fuzzy_QuerySensorData(100059, "temperature", "2020-07-15 19:42:08");
            //解析json数据
            String Jsondata = Public_MethodClass.SerializeToJson(Public_MethodClass.qry); //序列化
            datas = JsonConvert.DeserializeObject<SensorDataObject.Root>(Jsondata, setting); //反序列化

            this.chart1.Series[0].Points.Clear(); //先清除原先的折线图
            chart_set(); //不断更新图表
        }

        private void chart_set()
        {
            /////////////////////ChartAreal属性设置////////////////////
            //设置网格的颜色
            //chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = Color.LightGray;
            //chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = Color.LightGray;
            //设置坐标轴的名称
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "记录时间";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "温度值";
            //启用3D显示
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;

            ///////////////Series属性设置/////////////////////////
            //设置显示类型-线形
            chart1.Series["温度值"].ChartType = SeriesChartType.Line;
            //设置坐标轴Value显示类型
            chart1.Series["温度值"].XValueType = ChartValueType.Time;
            //是否显示标签的数值
            chart1.Series["温度值"].IsValueShownAsLabel = true;

            //设置标记图案
            chart1.Series["温度值"].MarkerStyle = MarkerStyle.Square;
            //设置图案颜色
            chart1.Series["温度值"].Color = Color.Green;
            //设置图案的宽度
            chart1.Series["温度值"].BorderWidth = 3;

            //设置图表的数据源
            DataTable dt = default(DataTable);
            dt = CreateDataTable();
            chart1.DataSource = dt;

            //设置图表Y轴对应项
            chart1.Series[0].YValueMembers = "温度值";

            //设置图标X轴对应项
            chart1.Series[0].XValueMember = "记录时间";


            //绑定数据
            chart1.DataBind();
        }

        private DataTable CreateDataTable()
        {
            //1.创建一个表格dt
            DataTable dt = new DataTable();
            //2.添加columns
            dt.Columns.Add("记录时间");
            dt.Columns.Add("温度值");

            /*
            //Json数据的格式处理方式
            JsonSerializerSettings setting = Public_MethodClass.JsonVert();
            //模糊查询设备最新30条数据
            Public_MethodClass.Fuzzy_QuerySensorData(100059, "temperature", "2020-07-15 19:42:08");
            //解析json数据
            String Jsondata = Public_MethodClass.SerializeToJson(Public_MethodClass.qry); //序列化
            datas = JsonConvert.DeserializeObject<SensorDataObject.Root>(Jsondata, setting); //反序列化
            */

            DataRow dr;

            //3.给表添加rows
            for(int i = 0;i < 10;i++)
            {
                dr = dt.NewRow();
                dr["记录时间"] = datas.ResultObj.DataPoints[0].PointDTO[i].RecordTime;
                dr["温度值"] = datas.ResultObj.DataPoints[0].PointDTO[i].Value;
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
