using Microsoft.AspNetCore.Mvc;

namespace ironbody.academias.Application.Controllers.Account;
public class Account : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }
   

    public IActionResult Login()
    {
        return View();
    }
}
