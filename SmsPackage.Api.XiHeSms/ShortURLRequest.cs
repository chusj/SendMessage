namespace SmsPackage.Api.XiHeSms
{
    /// <summary>
    /// 短链请求
    /// </summary>
    public class ShortURLRequest : IBaseRequest
    {
        public string URL { get; set; }

        //以下来自接口的公共属性
        public string OrgId { get; set; }

        public string Token { get; set; }

        public string TimeStamp { get; set; }
    }
}
