using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmsPackage.Model;
using SmsPackage.Service;

namespace SmsPackage.Test.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LianluController : ControllerBase
    {
        private readonly ILianluService _lianluService;
        public LianluController(IConfiguration config)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddLianluSendMessageApi(option =>
            {
                option.ApiUrl = config.GetValue<string>("LianLu:ApiUrl");
                option.ApiPath = config.GetValue<string>("LianLu:ApiPath");
                option.MchId = config.GetValue<string>("LianLu:MchId");
                option.AppId = config.GetValue<string>("LianLu:AppId");
                option.AppKey = config.GetValue<string>("LianLu:AppKey");
            });
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            _lianluService = serviceProvider.GetService<ILianluService>();
        }

        [HttpPost]
        public async Task<LianLuApiResponse> Test()
        {
            var mobiles = new List<string>() { "18042002812" };
            return await _lianluService.Send(mobiles, "L您好，今天您的生日，祝您生日快乐。 温馨提醒：为了您的健康请定期进行健康体检。", "【杭州希和】");
        }
    }
}
