using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class SensorDataObject
    {
        public class PointDTOItem
        {
            /// <summary>
            /// 
            /// </summary>
            public double Value { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string RecordTime { get; set; }
        }

        public class DataPointsItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string ApiTag { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<PointDTOItem> PointDTO { get; set; }
        }

        public class ResultObj
        {
            /// <summary>
            /// 
            /// </summary>
            public int DeviceId { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<DataPointsItem> DataPoints { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public ResultObj ResultObj { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int Status { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int StatusCode { get; set; }
        }
    }
}
