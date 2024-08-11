namespace SmsPackage.Model
{
    public class ZhuTongApiResponse : IResponse
    {
        /// <summary>
        /// 助通响应
        /// </summary>
        public ZhuTongResponse Response { get; set; }

        //下面是来自接口的属性
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
