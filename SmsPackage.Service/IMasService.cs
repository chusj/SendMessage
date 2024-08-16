using SmsPackage.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmsPackage.Service
{
    public interface IMasService
    {
        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="mobileList">手机号码</param>
        /// <param name="content">内容</param>
        /// <returns></returns>
        Task<MasApiResponse> Send(List<string> mobileList, string content);
    }
}
