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
   
    public Series verSeriesAjax(int IdSerie)
    {
        return BD.ListarSeriesPorID(IdSerie);
    
    }

    public List<Actores> verActoresAjax(int IdSerie)
    {
        return BD.ListarActores(IdSerie);
       
    }

    public List<Temporadas> verTemporadasAjax(int IdSerie)
    {
          return BD.ListarTemoporadas(IdSerie);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
