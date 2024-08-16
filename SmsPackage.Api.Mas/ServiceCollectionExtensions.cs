using SmsPackage.Model;
using SmsPackage.Service;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加中国移动云MAS短信服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
        public static IServiceCollection AddMasSendMessageApi(this IServiceCollection services, Action<MasOptions> configure)
        {
            services.AddOptions<MasOptions>().Configure(configure);
            services.AddTransient<IMasService, MasSendService>();
            return services;
        }
    }
}
