using Microsoft.AspNetCore.Mvc;

namespace PizzaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly MenuBL _menuBL;

        public MenuController()
        {
            _menuBL = new MenuBL();
        }
        [HttpGet]
        public ActionResult GetFullMenu()
        {
            return Ok(_menuBL.GetMenu());
        }
    }
}
