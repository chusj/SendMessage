using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SmsPackage.Api.XiHeSms
{
    /// <summary>
    /// 希和短信接口
    /// </summary>
    public class XiHeSmsApi
    {
        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="request">短信请求参数</param>
        /// <returns></returns>
        public async Task<(bool success, string message)> SendMsg(string url, SmsRequest request)
        {
            return await SendPostAsync(request, url);
        }

        /// <summary>
        /// 机构验证
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="request">机构请求参数</param>
        /// <returns></returns>
        public async Task<(bool success, string message)> ValidOrgan(string url, OrganRequest request)
        {
            return await SendPostAsync(request, url);
        }

        /// <summary>
        /// 短链
        /// </summary>
        /// <param name="url">接口地址</param>
        /// <param name="request">短链请求参数</param>
        /// <returns></returns>
        public async Task<(bool success, string message)> ShortLink(string url, ShortURLRequest request)
        {
            return await SendPostAsync(request, url);
        }

        /// <summary>
        /// 发送Post请求
        /// </summary>
        /// <param name="request">请求对象</param>
        /// <param name="url"></param>
        /// <returns></returns>
        public async Task<(bool success, string message)> SendPostAsync(IBaseRequest request, string url)
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
                resultTurple.message = $"XiHeSms.dll => Exception:{e.Message}";
                return resultTurple;
            }
        }
    }
}
