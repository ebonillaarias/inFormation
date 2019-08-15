using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using inFormation.Models;
using InFormation.ENT;
using inFormation.Utility;
using Microsoft.Extensions.Options;
using InFormation.DAL;

namespace inFormation.Controllers
{
    public class HomeController : BaseController
    {
        public static IOptions<ReadConfig> config;

        public HomeController(IOptions<ReadConfig> _config)
        {
            config = _config;
        }

        public IActionResult Index()
        {
            //HelperWebConfig helper = new HelperWebConfig();
            string urlWS = config.Value.WebService + "Menu";

            List<Menu> lista = new List<Menu>();
            lista = HelperWebService<Menu>.GetInvoke(urlWS);
            ViewBag.ListaMenu = lista;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
