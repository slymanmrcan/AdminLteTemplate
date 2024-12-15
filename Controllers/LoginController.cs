using Microsoft.AspNetCore.Mvc;

namespace AdminLte.Controllers;

public class LoginController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}