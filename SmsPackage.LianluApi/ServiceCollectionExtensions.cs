using SmsPackage.Model;
using SmsPackage.Service;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// 添加联麓发送短信api服务
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configure"></param>
        /// <returns></returns>
        public static IServiceCollection AddLianluSendMessageApi(this IServiceCollection services, Action<LianluOptions> configure)
        {
            services.AddOptions<LianluOptions>().Configure(configure);
            services.AddTransient<ILianluService, LianluSendService>();
            return services;
        }
    }
}
