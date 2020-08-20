using System;


namespace test
{
    class Users //用户类
    {
        //先将Users类设为可以序列化（即在类的前面加[Serializable]）
        [Serializable]

        public class User //构造方法
        {
            //用户名
            private string userName;
            public string Username
            {
                get { return userName; }
                set { userName = value; }
            }

            private string passWord;
            public string Password
            {
                get { return passWord; }
                set { passWord = value; }
            }

        }


    }
}
