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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show(); //跳转到光照采集程序
            this.Hide(); //关闭当前窗口
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3_temperature().Show(); //跳转到温度采集程序
            this.Hide(); //关闭当前窗口
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form4_steering().Show(); //跳转到脱机控制程序
            this.Hide(); //关闭当前窗口
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form5_Rfcard().Show(); //跳转到射频卡数据程序
            this.Hide(); //关闭当前窗口
        }
    }
}
