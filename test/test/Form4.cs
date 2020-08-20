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
    public partial class Form4_steering : Form
    {
        public Form4_steering()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new menu().Show(); //返回到菜单界面
            this.Hide(); //关闭当前的窗口
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int a;
            a = trackBar1.Value;

            //给云平台发送改变的控制信息（a就是拖动的数据）
            var qry = Class1.SDK.Cmds(100059,"duoji",a,Class1.Token);
            textBox1.Text = a.ToString(); //显示出当前数据

        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            int  b; 
            b = trackBar2.Value;

            //给云平台发送改变的控制信息（b就是拖动的数据）
            var qry = Class1.SDK.Cmds(100059, "duoji", b, Class1.Token);
            textBox2.Text = b.ToString(); //显示出当前数据
        }
    }

}
