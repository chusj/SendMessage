namespace SmsPackage.Model
{
    /// <summary>
    /// Mas平台配置项
    /// </summary>
    public class MasOptions : ISmsOptions
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        public string ecName { get; set; }

        /// <summary>
        /// 接口账号用户名
        /// </summary>
        public string apId { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        public string secretKey { get; set; }

        /// <summary>
        /// 签名编码
        /// </summary>
        public string sign { get; set; }

        /// <summary>
        /// 拓展码
        /// </summary>
        public string addSerial { get; set; }

        /// <summary>
        /// 参数校验序列
        /// </summary>
        public string mac { get; set; }

        //以下属性来自接口
        public string ApiUrl { get; set; }
        public string ApiPath { get; set; }
    }
}
