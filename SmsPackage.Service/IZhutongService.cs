using SmsPackage.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmsPackage.Service
{
    /// <summary>
    /// 助通服务接口
    /// </summary>
    public interface IZhutongService
    {
        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="mobileList">手机号码</param>
        /// <param name="content">内容</param>
        /// <returns></returns>
        Task<ZhuTongApiResponse> Send(List<string> mobileList, string content);
    }
}
