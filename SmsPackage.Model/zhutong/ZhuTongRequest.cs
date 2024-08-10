namespace SmsPackage.Model
{
    internal class ZhuTongRequest: ISmsRequest
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string username { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// key
        /// </summary>
        public string tKey { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 发送时间 =>为空立即发送
        /// </summary>
        public string time { get; } = string.Empty;

        public string Ext { get; } = "2024";
    }
}
