using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Playstation2.ViewModels;
using Playstation2.Models;
using JogosPS2.Data;

namespace Playstation2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        // Preenche o ViewModel com dados dos Gêneros e Jogos
        HomeVM home = new()
        {
            Generos = _context.Genero.ToList(),
            Jogos = _context.Jogo
                .Include(j => j.JogoGeneros)  
                .ThenInclude(jg => jg.Genero)
                .ToList()
        };
        return View(home);
    }

    // [HttpGet]
    // public IActionResult Details(int id)
    // {
    //     // Busca o jogo pelos relacionamentos e detalhes
    //     Jogo jogo = _context.Jogo
    //         .Where(j => j.JogoID == id)
    //         .Include(j => j.Genero)  // Inclui os gêneros
    //         .Include(j => j.Desenvolvedores)  // Inclui os desenvolvedores
    //         .ThenInclude(jd => jd.Desenvolvedor)
    //         .SingleOrDefault();

    //     DetailsVM details = new()
    //     {
    //         Atual = jogo,
    //         Anterior = _context.Jogo
    //             .OrderByDescending(j => j.JogoID)
    //             .FirstOrDefault(j => j.JogoID < id),
    //         Proximo = _context.Jogo
    //             .OrderBy(j => j.JogoID)
    //             .FirstOrDefault(j => j.JogoID > id)
    //     };
    //     return View(details);
    // }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
