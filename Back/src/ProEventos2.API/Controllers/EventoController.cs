using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos2.API.Models;

namespace ProEventos2.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Tema = "Angula 11 e .NET 5",
                Local = "Belo Horizonete",
                Lote = "1 Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "fotopng"
            },
            new Evento() {
                EventoId = 2,
                Tema = "Angula 11 e suas novidades",
                Local = "sao paulo",
                Lote = "2 Lote",
                QtdPessoas = 150,
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                ImagemURL = "fotopng"
            },
        };
        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
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
