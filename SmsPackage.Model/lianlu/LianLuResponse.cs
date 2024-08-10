namespace SmsPackage.Model
{
    public class LianLuResponse: ISmsResponse
    {
        /// <summary>
        /// 接口请求状态码
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 自定义标签
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回
        /// </summary>
        public string TaskId { get; set; }

        /// <summary>
        /// UNIX 时间戳
        /// </summary>
        public long Timestamp { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        public string Message { get; set; }
    }
}
