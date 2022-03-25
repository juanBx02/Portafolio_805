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

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Empleado empleados)
        {
            if (ModelState.IsValid)
            {
                _contexto.empleados.Add(empleados);
                await _contexto.SaveChangesAsync();
                return RedirectToAction("ListaEmpleados");
            }

            return View();
        }


        public IActionResult Editar(int id)
        {
            return View();
        }

        public IActionResult Eliminar(int id)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}