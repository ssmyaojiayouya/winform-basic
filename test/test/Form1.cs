using NLECloudSDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static test.Users;

namespace test
{

    public partial class Form1 : Form
    {
        private static String account;      //云平台登录帐号
        private static String password;          //云平台登录密码

        //就是创建了一个空集合，这个集合中的元素的键是string类型的，值是User类型的
        //User类型里面是存储用户的账号和密码的
        private Dictionary<string, User> users = new Dictionary<string, User>();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*1. 实例化一个SDK*/
            Class1.SDK = new NLECloudAPI(Class1.API_HOST);

            //获取用户输入的文本框中的账号密码以及是否记住密码 
            account = zhanghao_comboBox1.Text.Trim();
            password = mima.Text.Trim();

            /*2. 创建一个userdata文件存放用户账号密码数据，FileMode.OpenOrCreate创建文件*/
            User user = new User();

            // FileStream操作字节的，可以操作任何的文件,
            //而StreamReader类和StreamWriter类:操作字符的，只能操作文本文件。
            FileStream fs = new FileStream("userdata.bin", FileMode.Create);

            //（有时候需要将C#中某一个结构很复杂的类的对象存储起来，
            //或者通过网路传输到远程的客户端程序中去， 这时候用文件方式或者数据库方式存储或者传送就比较麻烦了，
            //这个时候，最好的办法就是使用串行和解串（Serialization & Deserialization).）其中BinaryFormattter最简单
            BinaryFormatter bf = new BinaryFormatter();

            /*3. 判断用户是否选择了记住密码，并且把相应的记录放入users集合中，
             *        并通过BinaryFormatter串行 放入文件中*/
            user.Username = account;
            if (this.jizhumima_checkBox1.Checked) //如果单击了记住密码的功能
            {  //在文件中保存密码
                user.Password = password;
            }
            else
            {  //不在文件中保存密码
                user.Password = "";
            }

            //判断在集合中是否存在用户名
            if (users.ContainsKey(user.Username))
            { //集合中存在该用户名,则先把它移除
                users.Remove(user.Username);
            }
            users.Add(user.Username, user); //添加到用户集合中
            //串行放入文件中
            bf.Serialize(fs, users);
            fs.Close();

            /*4. 把文本框中获取到的内容 再给dto对象*/
            AccountLoginDTO dto = new AccountLoginDTO()
            {
                Account = account,
                Password = password,
            };

            /*5. 再把该对象传入UserLogin中*/
            dynamic qry = Class1.SDK.UserLogin(dto);

            if (this.zhanghao_comboBox1.Text != "") //账号不为空
            {
                if (this.mima.Text != "") //密码不为空
                {
                    //6.验证是否登陆成功，调用API获得访问令牌
                    if (qry.IsSuccess())
                    {
                        Class1.Token = qry.ResultObj.AccessToken; //登陆成功，获得一个访问令牌
                        new menu().Show(); //7.登陆成功，跳转到另一个界面
                        this.Hide(); //关闭当前的登陆窗口
                    }

                    else
                    {
                        MessageBox.Show("账号或密码输入错误，请重新输入!!!!");
                        zhanghao_comboBox1.Text = "";
                        mima.Text = "";
                    }
                }

                else
                {
                    MessageBox.Show("密码为空，请输入密码！");
                }
            }
            else
            {
                MessageBox.Show("账号为空，请输入账号！");
            }
        }

        private void zhuce_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { //点击了注册链接，就跳转到新大陆注册界面
            zhuce.LinkVisited = true;
            Process.Start("IExplore", "http://www.nlecloud.com/my/register");
        }

        private void mima_KeyPress(object sender, KeyPressEventArgs e)
        { //当在密码框中按下回车键时，先判断是否密码输入，再进入登陆按键函数
            if (e.KeyChar == (char)13) //回车键对应的ASC码是13。
                button1_Click(sender, e);
        }


        //窗体加载函数，也就是在用户刚开始运行此窗体时，你想呈现的一个效果
        //现在是想呈现一个 记住密码的状态或者文本框中有数据的一个现象
        private void Form1_Load(object sender, EventArgs e)
        {
            //读取配置文件寻找记住的用户名和密码
            FileStream fs = new FileStream("userdata.bin", FileMode.OpenOrCreate);

            if (fs.Length > 0) //文件中有数据
            {
                BinaryFormatter bf = new BinaryFormatter(); //把对象转换成为二进制的工具函数
                //在这里要读出userdata.bin里的用户信息
                users = bf.Deserialize(fs) as Dictionary<string, User>;

                //循环添加到zhanghao_comboBox1中，呈现一个下拉列表的效果，可以看到先前登陆过的账号
                foreach (User user in users.Values)
                {
                    this.zhanghao_comboBox1.Items.Add(user.Username);
                }

                for (int i = 0; i < users.Count; i++)
                {
                    if (this.zhanghao_comboBox1.Text != "") //账号文本框中不为空
                    {
                        if (users.ContainsKey(this.zhanghao_comboBox1.Text)) //并且存在与文件中（==users集合中）
                        {
                            this.mima.Text = users[this.zhanghao_comboBox1.Text].Password;
                            this.jizhumima_checkBox1.Checked = true;
                        }
                    }
                }
            }
            fs.Close();
            //用户名默认选中第一个
            if (this.zhanghao_comboBox1.Items.Count > 0)
            {
                this.zhanghao_comboBox1.SelectedIndex = this.zhanghao_comboBox1.Items.Count - 1;
            }
        }

        private void zhanghao_comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("userdata.bin", FileMode.OpenOrCreate);

            if (fs.Length > 0)
            {
                BinaryFormatter bf = new BinaryFormatter();

                users = bf.Deserialize(fs) as Dictionary<string, User>;

                for (int i = 0; i < users.Count; i++)
                {
                    if (this.zhanghao_comboBox1.Text != "")
                    {
                        this.mima.Text = users[this.zhanghao_comboBox1.Text].Password;
                        this.jizhumima_checkBox1.Checked = true;
                    }
                    else
                    {
                        this.mima.Text = "";
                        this.jizhumima_checkBox1.Checked = false;
                    }
                }
            }

            fs.Close();
        }
    }
}

