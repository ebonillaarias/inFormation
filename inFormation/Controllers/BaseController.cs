using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using inFormation.Utility;
using InFormation.DAL;
using InFormation.ENT;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace inFormation.Controllers
{
    public class BaseController : Controller
    {
        public static IOptions<ReadConfig> config;

        public BaseController(IOptions<ReadConfig> _config)
        {
            config = _config;
        }

        public void getMenu()
        {
            string urlWS = config.Value.WebService + "Menu";

            List<Menu> lista = new List<Menu>();
            lista = HelperWebService<Menu>.GetInvoke(urlWS);
            ViewBag.ListaMenu = lista;
        }

    }
}