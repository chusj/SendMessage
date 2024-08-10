using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmsPackage.Model.zhutong
{
    public class ZhutongOptions : ISmsOptions
    {
        public ZhutongOptions()
        {
            ApiUrl = "http://api.mix2.zthysms.com";
            ApiPath = "/v2/sendSms";
        }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// key
        /// </summary>
        public string Key { get; set; }

        public string ApiUrl { get; set; }
        public string ApiPath { get; set; }
    }
}
