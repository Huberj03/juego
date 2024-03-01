using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using juego.Models;
using Microsoft.AspNetCore.Mvc;

namespace juego.Controllers
{
    public class JugadorController : Controller
    {

        private readonly JuegoContext _context;
        public JugadorController( JuegoContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            return View(_context.Jugador.ToList());

        }

        public IActionResult Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            
            var jugador = _context.Jugador.Find(id);

            if (jugador==null)
            {
                return NotFound();
            }

            return View(jugador);

        }

        [HttpPost]//Este es el edit que graba en la bd
        public IActionResult Edit(int? id, [Bind("IdJugador,Nombre")]Jugador jugador)
        {
            if(id!=jugador.IdJugador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(jugador);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(jugador);

        }
        
    }
}