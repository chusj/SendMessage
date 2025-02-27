﻿using SmsPackage.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmsPackage.Service
{
    /// <summary>
    /// 联麓服务接口
    /// </summary>
    public interface ILianluService
    {
        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="mobileList">手机号码</param>
        /// <param name="content">内容</param>
        /// <param name="suffix">签名</param>
        /// <returns></returns>
        Task<LianLuApiResponse> Send(List<string> mobileList, string content, string suffix);
    }
}
