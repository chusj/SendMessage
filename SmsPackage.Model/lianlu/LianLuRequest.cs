namespace SmsPackage.Model
{
    /// <summary>
    /// 联麓请求
    /// </summary>
    public class LianLuRequest : ISmsRequest
    {
        /// <summary>
        /// 短信类型，固定值1
        /// </summary>
        public string Type { get; } = "1";

        /// <summary>
        /// 手机号码
        /// </summary>
        public List<string> PhoneNumberSet { get; set; }

        /// <summary>
        /// 版本，固定值
        /// </summary>
        public string Version { get; } = "1.1.0";

        /// <summary>
        /// 企业ID
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// Appid
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 短信签名
        /// </summary>
        public string SignName { get; set; }

        /// <summary>
        /// 短信内容
        /// </summary>
        public string SessionContext { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string TimeStamp { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        public string SignType { get; } = "MD5";

        /// <summary>
        /// 签名
        /// </summary>
        public string Signature { get; set; }
    }
}
