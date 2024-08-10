namespace SmsPackage.Model
{
    /// <summary>
    /// 短信响应
    /// </summary>
    public class SmsResponse
    {
        public int Code { get; set; } = 400;

        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }
    }
}
