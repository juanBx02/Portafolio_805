using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portafolio_805.DTO;
using Portafolio_805.Models;
using System.Diagnostics;

namespace Portafolio_805.Controllers
{

    public class HomeController : Controller
    {
        
        private readonly ApplicationDB _contexto;


        public HomeController(ApplicationDB contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> ListaEmpleados()
        {
            return View(await _contexto.empleados.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}