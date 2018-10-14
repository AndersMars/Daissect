using Daissect.Shared;
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
            return await _http.GetJsonAsync<List<Repository>>($"/api/Repository/GetRepositories");
        }
    }
}
