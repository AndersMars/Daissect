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
                new Repository() { Address = "github.com/AndersMars/Daissect.git", Description = "A repository exploration thing.", Color = "blue" },
                new Repository() { Address = "github.com/AndersMars/Mars.CognitiveServices.git", Description = "Platform and engine for cognitive services.", Color = "yellow"  },
                new Repository() { Address = "gitlab.com/gitlab-examples/cross-project-java/java-frontend.git", Description= "Brief description", Color = "green" },
                //new Repository() { Address = "gitlab/andersmars.com/thelab.git",  Color = "red" }
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
