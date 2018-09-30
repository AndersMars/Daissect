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
                new Repository() { Address = "github.com/aspnet/Blazor.git"},
                new Repository() { Address = "github.com/aspnet/Home.git"},
                new Repository() { Address = "github.com/ai/marzbarz.git"}
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
