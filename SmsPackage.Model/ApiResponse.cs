namespace SmsPackage.Model
{
    /// <summary>
    /// Api响应
    /// </summary>
    public class ApiResponse
    {
        public ApiResponse(ISmsResponse response)
        {
            smsResponse = response;
        }
        public int Code { get; set; } = 400;

        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }

        public ISmsResponse smsResponse { get; set; }
    }
}
