using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class DeviceDatas
    {
        public class Datas
        {
            /// <summary>
            /// 
            /// </summary>
            public string ApiTag { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public float Value { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string RecordTime { get; set; }
        }

        public class ResultObj
        {
            /// <summary>
            /// 
            /// </summary>
            public int DeviceID { get; set; }
            /// <summary>
            /// 温度传感模块
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<Datas> Datas { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public List<ResultObj> ResultObj { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string ErrorObj { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int Status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int StatusCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string Msg { get; set; }
        }

    }
}
