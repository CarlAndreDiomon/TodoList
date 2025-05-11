using Microsoft.AspNetCore.Mvc;

namespace Todo_List_App.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
