using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp05_SalaEscape2.Models;

namespace Tp05_SalaEscape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Tutorial()
    {
        return View();
    }

    public IActionResult Creditos()
    {
        return View();
    }

    public IActionResult Comenzar()
    {
        return View("Habitacion" + Escape.GetEstadoJuego());
    }
    public IActionResult Habitacion(int Sala, string Clave)
    {
        ViewBag.E = Escape.IncognitasSalas[Escape.estadoJuego];
        ViewBag.A = "A";
        bool tof = Escape.ResolverSala(Sala, Clave);
        if (tof == false)
        {
            ViewBag.Error = Escape.mensajeError;
        }
        if (Escape.GetEstadoJuego() != 5)
        {

            return View($"Habitacion{Escape.GetEstadoJuego()}");
        }
        return View("Victoria");


    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
