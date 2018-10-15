using Daissect.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Daissect.Server.Controllers
{
    [Route("api/[controller]")]
    public class RepositoryController : Controller
    {
        private static List<Repository> MyRepositories()
        {
            var repositories = new List<Repository>()
            {
                new Repository() { Address = "github.com/AndersMars/Daissect.git", Description = "A repository exploration thing.", Color = "blue", Code = @"using Daissect.Shared;
using Microsoft.AspNetCore.Blazor;
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
            return await _http.GetJsonAsync<List<Repository>>
                ($""/api/Repository/GetRepositories"");
        }
    }
}" },
                new Repository() { Address = "github.com/AndersMars/Mars.CognitiveServices.git", Description = "Cognitive services. AI related services.", Color = "yellow"  },
                new Repository() { Address = "gitlab.com/AndersMars/Mars.Platform", Description= "Platform repository with service contracts.", Color = "green", Code = @"namespace Daissect.Shared
{
    public class Repository
    {
        public string Address { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Code { get; set; }
    }
}" },
            };

            return repositories;
        }
         
        [HttpGet("[action]")]
        public IEnumerable<Repository> GetRepositories()
        {
            return MyRepositories();
        }
    }
}
