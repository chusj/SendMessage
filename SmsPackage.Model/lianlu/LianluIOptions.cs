namespace SmsPackage.Model
{
    internal class LianluIOptions : ISmsOptions
    {
        public LianluIOptions()
        {
            ApiUrl = "https://apis.shlianlu.com";
            ApiPath = "/sms/trade/normal/send";
        }

        /// <summary>
        /// 企业id
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// appId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// key
        /// </summary>
        public string AppKey { get; set; }

        public string ApiUrl { get; set; }
        public string ApiPath { get; set; }
    }
}
