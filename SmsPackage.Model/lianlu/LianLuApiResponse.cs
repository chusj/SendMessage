namespace SmsPackage.Model
{
    public class LianLuApiResponse : IResponse
    {
        /// <summary>
        /// 联麓响应
        /// </summary>
        public LianLuResponse Response { get; set; }

        //下面是来自接口的属性
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
