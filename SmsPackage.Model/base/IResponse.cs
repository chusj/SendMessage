namespace SmsPackage.Model
{
    /// <summary>
    /// Api响应
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// 编码
        /// </summary>
        int Code { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        string Message { get; set; }
    }
}
