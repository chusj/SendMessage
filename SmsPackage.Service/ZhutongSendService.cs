﻿using Newtonsoft.Json;
using SmsPackage.Model;
using SmsPackage.Service.Helper;

namespace SmsPackage.Service
{
    public class ZhutongSendService : IZhutongService
    {
        private string username = string.Empty;
        private string password = string.Empty;
        private string key = string.Empty;
        private string url = string.Empty;

        public ZhutongSendService()
        {
            
        }

        public async Task<ApiResponse> Send(List<string> mobileList, string content)
        {
            ZhuTongRequest request = new ZhuTongRequest();
            request.username = username;
            request.password = password;
            request.tKey = key;
            request.content = content.Replace("\n", "").Replace("\t", "").Replace("\r", "").Replace('"', '“');
            request.mobile = string.Join(",", mobileList);

            (bool success, string message) reuslt = await PostHelper.SendPostAsync(request, url);

            ApiResponse apiResponse = new ApiResponse(new ZhuTongResponse());
            if (reuslt.success)
            {
                ZhuTongResponse zhutongResponse = JsonConvert.DeserializeObject<ZhuTongResponse>(reuslt.message);
                if (zhutongResponse.Code == "200")
                {
                    apiResponse.Code = 200;
                    apiResponse.smsResponse = zhutongResponse;
                }
                apiResponse.Message = zhutongResponse.Msg;
            }
            else
            {
                apiResponse.Code = 500;
                apiResponse.Message = reuslt.message;
                apiResponse.smsResponse = null;
            }
            return apiResponse;
        }
    }
}
