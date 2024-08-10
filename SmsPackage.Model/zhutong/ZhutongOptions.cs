namespace SmsPackage.Model
{
    public class ZhutongOptions : ISmsOptions
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// key
        /// </summary>
        public string Key { get; set; }

        public string ApiUrl { get; set; }
        public string ApiPath { get; set; }
    }
}
