using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using SmsPackage.Model;
using SmsPackage.Service.Helper;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmsPackage.Service
{
    public class MasSendService : IMasService
    {
        private string EcName = string.Empty;
        private string ApId = string.Empty;
        private string SecretKey = string.Empty;
        private string Sign = string.Empty;
        private string AddSerial = string.Empty;
        private string url = string.Empty;
        public MasSendService(IOptionsSnapshot<MasOptions> options)
        {
            url = options.Value.ApiUrl + options.Value.ApiPath;
            EcName = options.Value.ecName;
            ApId = options.Value.apId;
            SecretKey = options.Value.secretKey;
            Sign = options.Value.sign;
            AddSerial = options.Value.addSerial;
        }

        public async Task<MasApiResponse> Send(List<string> mobileList, string content)
        {
            string mobileStr = string.Join(",", mobileList.ToArray());
            var request = new MasRequest
            {
                ecName = EcName,
                apId = ApId,
                mobiles = mobileStr,
                content = content,
                sign = Sign,
                addSerial = AddSerial,
                mac = string.Empty,
            };

            //构造参数校验序列字符串
            StringBuilder sb = new StringBuilder();
            sb.Append(EcName);
            sb.Append(ApId);
            sb.Append(SecretKey);
            sb.Append(mobileStr);
            sb.Append(content);
            sb.Append(Sign);
            sb.Append(AddSerial);
            request.mac = MD5Helper.EncryptMD5(sb.ToString());

            //提交请求
            MasApiResponse apiResponse = new MasApiResponse();
            (bool success, string message) reuslt = await PostHelper.SendPostAsync(request, url);
            if (reuslt.success)
            {
                MasResponse mas = JsonConvert.DeserializeObject<MasResponse>(reuslt.message);
                if (mas.Success)
                {
                    apiResponse.Code = 200;
                    apiResponse.Response = mas;
                }
                apiResponse.Message = mas.Rspcod;
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
