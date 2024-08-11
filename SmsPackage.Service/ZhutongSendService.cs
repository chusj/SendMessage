using Newtonsoft.Json;
using SmsPackage.Model;
using SmsPackage.Service.Helper;
using Microsoft.Extensions.Options;

namespace SmsPackage.Service
{
    public class ZhutongSendService : IZhutongService
    {
        private string username = string.Empty;
        private string password = string.Empty;
        private string key = string.Empty;
        private string url = string.Empty;

        public ZhutongSendService(IOptionsSnapshot<ZhutongOptions> options)
        {
            url = options.Value.ApiUrl + options.Value.ApiPath;
            username = options.Value.UserName;
            password = options.Value.Password;
            //原始密码二次处理
            key = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
            string newPassword = MD5Helper.EncryptMD5(password);
            password = MD5Helper.EncryptMD5(newPassword + key);
        }

        public async Task<ZhuTongApiResponse> Send(List<string> mobileList, string content)
        {
            ZhuTongRequest request = new ZhuTongRequest();
            request.username = username;
            request.password = password;
            request.tKey = key;
            request.content = content.Replace("\n", "").Replace("\t", "").Replace("\r", "").Replace('"', '“');
            request.mobile = string.Join(",", mobileList);

            (bool success, string message) reuslt = await PostHelper.SendPostAsync(request, url);

            ZhuTongApiResponse apiResponse = new ZhuTongApiResponse();
            if (reuslt.success)
            {
                ZhuTongResponse zhutongResponse = JsonConvert.DeserializeObject<ZhuTongResponse>(reuslt.message);
                if (zhutongResponse.Code == "200")
                {
                    apiResponse.Code = 200;
                    apiResponse.Response = zhutongResponse;
                }
                apiResponse.Message = zhutongResponse.Msg;
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
