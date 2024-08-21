using Newtonsoft.Json;
using SmsPackage.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmsPackage.Service.Helper
{
    public class PostHelper
    {
        /// <summary>
        /// 发送Post请求
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<(bool success, string message)> SendPostAsync(ISmsRequest request, string url)
        {
            (bool success, string message) resultTurple = (false, string.Empty);
            try
            {
                var jsonContent = JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpClient _httpClient = new HttpClient();
                var response = await _httpClient.PostAsync(url, content);

                //返回
                resultTurple.message = await response.Content.ReadAsStringAsync();
                resultTurple.success = true;

                return resultTurple;
            }
            catch (HttpRequestException e)
            {
                resultTurple.message = $"SendPostAsync => Exception:{e.Message}";
                return resultTurple;
            }
        }

        /// <summary>
        /// 发送Post请求(会对requestData进行Base64编码)
        /// </summary>
        /// <param name="requestData">json字符串</param>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<(bool success, string message)> SendPostAsync(string requestData, string url)
        {
            (bool success, string message) resultTurple = (false, string.Empty);
            try
            {
                var jsonContent = EncodeJsonToBase64(requestData);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                HttpClient _httpClient = new HttpClient();
                var response = await _httpClient.PostAsync(url, content);

                //返回
                resultTurple.message = await response.Content.ReadAsStringAsync();
                resultTurple.success = true;

                return resultTurple;
            }
            catch (HttpRequestException e)
            {
                resultTurple.message = $"SendPostAsync => Exception:{e.Message}";
                return resultTurple;
            }
        }

        /// <summary>
        /// 将给定的JSON字符串进行Base64编码
        /// </summary>
        /// <param name="json">JSON字符串</param>
        /// <returns>Base64编码后的字符串</returns>
        public static string EncodeJsonToBase64(string json)
        {
            // 将JSON字符串转换为字节数组
            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);

            // 使用Convert类将字节数组转换为Base64编码的字符串
            string base64EncodedJson = Convert.ToBase64String(jsonBytes);

            return base64EncodedJson;
        }
    }
}
