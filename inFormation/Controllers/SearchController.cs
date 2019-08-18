using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InFormation.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace inFormation.Controllers
{
    public class SearchController : BaseController
    {
        public static IOptions<ReadConfig> config;

        public SearchController(IOptions<ReadConfig> _config) : base(_config)
        {
            
        }

        public IActionResult Personal()
        {
            getMenu();

            return View();
        }
    }
}