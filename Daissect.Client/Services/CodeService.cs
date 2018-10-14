using Daissect.Shared;
using Microsoft.AspNetCore.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace Daissect.Client.Services
{
    public class CodeService
    {
        private readonly HttpClient _http;

        public CodeService(HttpClient http)
        {
            _http = http;
        }

        public async Task<string> GetCode()
        {
            //return "this is some code";

            return await _http.GetJsonAsync<string>($"/api/Code/GetCode");
        }
    }
}
