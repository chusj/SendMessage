namespace SmsPackage.Api.XiHeSms
{
    /// <summary>
    /// 机构请求
    /// </summary>
    public class OrganRequest : IBaseRequest
    {
        /// <summary>
        /// MAC地址
        /// </summary>
        public string MacAddress { get; set; }

        /// <summary>
        /// 本地时间，格式yyyy-MM-dd
        /// </summary>
        public string LocalTime { get; set; }

        //以下来自接口的公共属性
        public string OrgId { get; set; }

        public string Token { get; set; }

        public string TimeStamp { get; set; }
    }
}
