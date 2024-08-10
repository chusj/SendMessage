using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SmsPackage.Model;
using SmsPackage.Service.Helper;

namespace SmsPackage.Service
{
    public class LianluSendService : ILianluService
    {
        private string appId = string.Empty;
        private string mchId = string.Empty;
        private string appKey = string.Empty;
        private string url = string.Empty;

        public LianluSendService(IOptionsSnapshot<LianluOptions> options)
        {
            url = options.Value.ApiUrl + options.Value.ApiPath;
            appId = options.Value.AppId;
            mchId = options.Value.MchId;
            appKey = options.Value.AppKey;
        }

        public async Task<ApiResponse> Send(List<string> mobileList, string content, string suffix)
        {
            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            var request = new LianLuRequest
            {
                PhoneNumberSet = mobileList,
                AppId = appId,
                MchId = mchId,
                SignName = suffix,
                TimeStamp = timestamp,
                SessionContext = content.Replace(suffix, "") // 替换掉 SignName
            };

            // 构建签名字符串
            string signString = $"AppId={request.AppId}&MchId={request.MchId}" +
                                $"&SignName={request.SignName}&SignType={request.SignType}" +
                                $"&TimeStamp={request.TimeStamp}&Type={request.Type}" +
                                $"&Version={request.Version}&key={appKey}";

            // 计算签名
            request.Signature = MD5Helper.EncryptMD5(signString).ToUpper();

            //提交请求
            (bool success, string message) reuslt = await PostHelper.SendPostAsync(request, url);

            ApiResponse apiResponse = new ApiResponse(new ZhuTongResponse());
            if (reuslt.success)
            {
                LianLuResponse lianLuResponse = JsonConvert.DeserializeObject<LianLuResponse>(reuslt.message);
                if (lianLuResponse.Status == "00")
                {
                    apiResponse.Code = 200;
                    apiResponse.smsResponse = lianLuResponse;
                }
                apiResponse.Message = lianLuResponse.Message;
            }
            else
            {
                apiResponse.Code = 500;
                apiResponse.Message = reuslt.message;
            }
            return apiResponse;
        }
    }
}
