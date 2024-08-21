using Microsoft.AspNetCore.Mvc;
using SmsPackage.Model;
using SmsPackage.Service;

namespace SmsPackage.Test.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MasController : ControllerBase
    {
        private readonly IMasService _masService;

        public MasController(IConfiguration config)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddMasSendMessageApi(option =>
            {
                option.ApiUrl = config.GetValue<string>("Mas:ApiUrl");
                option.ApiPath = config.GetValue<string>("Mas:ApiPath");
                option.apId = config.GetValue<string>("Mas:ApId");
                option.ecName = config.GetValue<string>("Mas:EcName");
                option.secretKey = config.GetValue<string>("Mas:SecretKey");
                option.sign = config.GetValue<string>("Mas:Sign");
                option.addSerial = config.GetValue<string>("Mas:AddSerial");
            });
            IServiceProvider serviceProvider = services.BuildServiceProvider();
            _masService = serviceProvider.GetService<IMasService>();
        }
        [HttpPost]
        public async Task<MasApiResponse> Test(string mobile)
        {
            var mobiles = new List<string>() { mobile };
            return await _masService.Send(mobiles, "您好，今天您的生日，祝您生日快乐。 温馨提醒：为了您的健康请定期进行健康体检。");
        }
    }
}
