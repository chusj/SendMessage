namespace SmsPackage.Model
{
    /// <summary>
    /// 联麓配置项
    /// </summary>
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

        //以下属性来自接口
        public string ApiUrl { get; set; }
        public string ApiPath { get; set; }
    }
}
