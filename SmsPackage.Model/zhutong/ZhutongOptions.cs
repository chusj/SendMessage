namespace SmsPackage.Model
{
    /// <summary>
    /// 助通配置项
    /// </summary>
    public class ZhutongOptions : ISmsOptions
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// key
        /// </summary>
        public string Password { get; set; }

        //以下属性来自接口
        public string ApiUrl { get; set; }
        public string ApiPath { get; set; }
    }
}
