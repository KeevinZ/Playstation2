			using System.Diagnostics;
			using Microsoft.AspNetCore.Mvc;
			using Microsoft.EntityFrameworkCore;
			using JogosPs2.Data;
			using Playstation2.Models;
			using Plyastation2.ViewModels;

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
					HomeVM home = new() {
						Genero = _context.Genero.ToList(),
						Jogo = _context.Jogo
							.Include(j => j.Genero)
							.ThenInclude(g => g.Genero)
							.Include(j => j.AnoLancamento)
							.Include(j => j.Genero)
							.ToList(),
					};
					return View(home);
				}

				public IActionResult Details(int id)
				{
					Pokemon jogo = _context.Jogo
									.Where(p => p.Numero == id)
									.Include(p => p.Tipos)
									.ThenInclude(t => t.Tipo)
									.Include(p => p.Regiao)
									.Include(p => p.Genero)
									.SingleOrDefault();
					
					DetailVM detailVM = new()
					{
						Atual = pokemon,
						Anterior = _context.Pokemons
							.OrderByDescending(p => p.Numero)
							.FirstOrDefault(p => p.Numero < id),
						Proximo = _context.Pokemons
							.OrderBy(p => p.Numero)
							.FirstOrDefault( p => p.Numero > id)
					};
					
					return View(detailVM);
				}
				

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
