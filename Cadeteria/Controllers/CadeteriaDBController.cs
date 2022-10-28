using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cadeteria.Models;

namespace Cadeteria.Controllers;

public class CadeteriaDBController : Controller
{
    private CadeteriaDB cadeteria = new CadeteriaDB("Cadeteria",3814546789);
    public IActionResult Form()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Alta(IFormCollection cadete)
    {
        Cadeteria.Models.Cadete nuevoCadete = new Cadeteria.Models.Cadete(cadete["nombre"],cadete["direccion"],Convert.ToUInt32(cadete["telefono"]));
        cadeteria.AgregarCadete(nuevoCadete);
        return View(cadeteria.Cadetes1);
    }
}