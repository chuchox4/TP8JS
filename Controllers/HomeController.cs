using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP8JS.Models;

namespace TP8JS.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.listaSeries = BD.ListarSeries();
        return View();
    }
   
    public Series verSeriesAjax()
    {
        ViewBag.listaSeries = BD.ListarSeries();
        return ViewBag.listaSeries;
    }

    public Actores verActoresAjax(int IdSerie)
    {
        ViewBag.listaActores = BD.ListarActores(IdSerie);
        return ViewBag.listaActores;
    }

    public Temporadas verTemporadasAjax(int IdSerie)
    {
        ViewBag.listaTemporadas = BD.ListarTemoporadas(IdSerie);
        return ViewBag.listaTemporadas;
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
