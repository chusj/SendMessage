using Microsoft.AspNetCore.Mvc;
using SmsPackage.Model;
using SmsPackage.Service;

namespace SmsPackage.Test.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ZhutongController : ControllerBase
    {
        private readonly IZhutongService _zhutongService;
        public ZhutongController(IConfiguration config)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddZhutongSendMessageApi(option =>
            {
                option.ApiUrl = config.GetValue<string>("ZhuTong:ApiUrl");
                option.ApiPath = config.GetValue<string>("ZhuTong:ApiPath");
                option.UserName = config.GetValue<string>("ZhuTong:UserName");
                option.Password = config.GetValue<string>("ZhuTong:Password");
            });
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            _zhutongService = serviceProvider.GetService<IZhutongService>();
        }

        [HttpPost]
        public async Task<ZhuTongApiResponse> Test(string mobile)
        {
            var mobiles = new List<string>() { mobile };
            return await _zhutongService.Send(mobiles, "您好，今天您的生日，祝您生日快乐。 温馨提醒：为了您的健康请定期进行健康体检。【公司名称】");
        }
    }
}
