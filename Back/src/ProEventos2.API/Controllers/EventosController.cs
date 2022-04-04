using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos2.API.Data;
using ProEventos2.API.Models;

namespace ProEventos2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {

        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Vai se foder";
        }

        [HttpPut("{id?}")]
        public string Put(int? id)
        {
            return $"Vai se foder id = {id}";
        }
    }
}
