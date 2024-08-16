namespace SmsPackage.Model
{
    public class MasApiResponse : IResponse
    {
        /// <summary>
        /// 云MAS响应
        /// </summary>
        public MasResponse Response { get; set; }

        //下面是来自接口的属性
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
