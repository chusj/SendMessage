namespace SmsPackage.Model
{
    /// <summary>
    /// 短信配置项接口
    /// </summary>
    public interface ISmsOptions
    {
        /// <summary>
        /// API地址
        /// </summary>
        string ApiUrl { get; set; }

        /// <summary>
        /// API路径
        /// </summary>
        string ApiPath { get; set; }
    }
}
