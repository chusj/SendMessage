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
        public LianluController()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddLianluSendMessageApi(option =>
            {
                option.ApiUrl = "";
                option.ApiPath = "";
                option.MchId = "";
                option.AppId = "";
                option.AppKey = "";
            });
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            _lianluService = serviceProvider.GetService<ILianluService>();

        }

        [HttpPost]
        public async Task<ApiResponse> Test()
        {
            var mobiles = new List<string>() { "18042002812" };
            return await _lianluService.Send(mobiles, "L您好，今天您的生日，祝您生日快乐。 温馨提醒：为了您的健康请定期进行健康体检。", "【杭州希和】");
        }
    }
}
