using Daissect.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daissect.Server.Controllers
{
    [Route("api/[controller]")]
    public class CodeController : Controller
    {
        [HttpGet("[action]")]
        public string GetCode()
        {
            return MyCode();
        }

        private static string MyCode()
        {
            string code = @"using Daissect.Shared;
using Microsoft.AspNetCore.Blazor;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;

namespace Daissect.Client.Services
{
    public class RepositoryService
    {
        private readonly HttpClient _http;

        public RepositoryService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Repository>> GetRepositories()
        {
            return await _http.GetJsonAsync<List<Repository>>($""/api/Repository/GetRepositories"");
        }
    }
}";
            return code;
        }
    }
}
