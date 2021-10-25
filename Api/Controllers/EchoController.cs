using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EchoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Scheme: {Request.Scheme}");
            sb.AppendLine($"Host: {Request.Host}");
            sb.AppendLine("Headers:");
            foreach (var header in Request.Headers)
            {
                sb.AppendLine($"{header.Key}: {header.Value}");
            };

            return sb.ToString();
        }
    }
}