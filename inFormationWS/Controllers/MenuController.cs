using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IInFormation.BLL;
using InFormation.ENT;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace inFormationWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private IMenu_BLL _menu;
        public MenuController(IMenu_BLL menu)
        {
            this._menu = menu;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Menu>>> Get()
        {
            var listado = await _menu.getMenu();
            if (listado == null)
            {
                return NotFound();
            }
            return listado.ToList();
        }
    }
}