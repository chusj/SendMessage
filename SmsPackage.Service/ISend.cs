namespace SmsPackage.IService
{
    public interface ISend
    {
        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="mobileList">手机号码</param>
        /// <param name="content">内容</param>
        /// <param name="suffix">签名</param>
        /// <returns></returns>
        Task<SmsResponse> Send(List<string> mobileList, string content, string suffix);
    }
}
