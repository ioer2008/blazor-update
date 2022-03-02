using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace UpdateReloadPWA.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GetVersionController : ControllerBase
    {
        IConfiguration _configuration;

        public GetVersionController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> Get()
        {
            await Task.Delay(0);
            return _configuration["AppVersion"];
        }
    }
}
