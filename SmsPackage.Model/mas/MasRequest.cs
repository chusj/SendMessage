namespace SmsPackage.Model
{
    /// <summary>
    /// 云MAS请求
    /// </summary>
    public class MasRequest : ISmsRequest
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
        /// 手机号码,英文逗号分隔
        /// </summary>
        public string mobiles { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }

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
    }
}
