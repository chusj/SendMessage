using SmsPackage.Model;
using SmsPackage.Service;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddZhutongSendMessageApi(this IServiceCollection services, Action<ZhutongOptions> configure)
        {
            services.AddOptions<ZhutongOptions>().Configure(configure);
            services.AddTransient<IZhutongService, ZhutongSendService>();
            return services;
        }
    }
}
