//AGUSTINA - Nuevo

using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class UsuarioController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    
}