using SmsPackage.Model;
using SmsPackage.Service;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加助通发送短信api服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
        public static IServiceCollection AddZhutongSendMessageApi(this IServiceCollection services, Action<ZhutongOptions> configure)
        {
            services.AddOptions<ZhutongOptions>().Configure(configure);
            services.AddTransient<IZhutongService, ZhutongSendService>();
            return services;
        }
    }
}
