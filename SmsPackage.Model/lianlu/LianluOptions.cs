namespace SmsPackage.Model
{
    public class LianluOptions : ISmsOptions
    {
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
