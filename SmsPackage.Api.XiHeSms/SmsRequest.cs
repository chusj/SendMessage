using System.Collections.Generic;

namespace SmsPackage.Api.XiHeSms
{
    /// <summary>
    /// 短信请求
    /// </summary>
    public class SmsRequest : IBaseRequest
    {
        /// <summary>
		/// 手机号码
		/// </summary>
		public List<string> Mobiles { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        public string Contents { get; set; }

        /// <summary>
        /// 手机验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 短信签名
        /// </summary>
        public string Signature { get; set; }

        //以下来自接口的公共属性
        public string OrgId { get; set; }

        public string Token { get; set; }

        public string TimeStamp { get; set; }
    }
}
