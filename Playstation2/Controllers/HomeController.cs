using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Playstation2.Data;
using Playstation2.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Playstation2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        // Action para listar os jogos na página inicial
        public async Task<IActionResult> Index()
        {
            var jogos = await _context.Jogo
                .Include(j => j.JogoGeneros)
                    .ThenInclude(jg => jg.Genero)
                .Include(j => j.JogoDesenvolvedores)
                    .ThenInclude(jd => jd.Desenvolvedor)
                .ToListAsync();

            return View(jogos);
        }

        // Action para exibir detalhes de um jogo
        public async Task<IActionResult> Details(int id)
        {
            var jogo = await _context.Jogo
                .Include(j => j.JogoGeneros)
                    .ThenInclude(jg => jg.Genero)
                .Include(j => j.JogoDesenvolvedores)
                    .ThenInclude(jd => jd.Desenvolvedor)
                .FirstOrDefaultAsync(j => j.JogoID == id);

            if (jogo == null)
            {
                return NotFound();
            }

            return View(jogo);
        }
    }
}
