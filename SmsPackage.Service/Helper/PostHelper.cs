using Newtonsoft.Json;
using SmsPackage.Model;
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
                resultTurple.message = $"Post.SendPostAsync => Exception:{e.Message}";
                return resultTurple;
            }
        }

    }
}
