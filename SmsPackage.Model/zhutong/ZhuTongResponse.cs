namespace SmsPackage.Model
{
    /// <summary>
    /// 助通响应内容
    /// </summary>
    public class ZhuTongResponse:ISmsResponse
    {
        /// <summary>
        /// 状态码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 信息id
        /// </summary>
        public string MsgId { get; set; }

        /// <summary>
        /// 计费数
        /// </summary>
        public string ContNum { get; set; }
    }
}
