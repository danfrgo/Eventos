using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento =  new Evento[] {
                new Evento(){
                EventoId = 1,
                TemaDoEvento = "Angular Donet 5.0",
                Local = "PT",
                Lote = "1º Lote",
                QtdMaxPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png" 
            },
             new Evento(){
                EventoId = 2,
                TemaDoEvento = "React",
                Local = "EUA",
                Lote = "2º Lote",
                QtdMaxPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.png"
             }
            };

        public EventoController()
        { 
        }

        [HttpGet]
        // retorna um evento
        // INumerable retorna um array e nao um evento
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

         [HttpGet("{id}")]
        // retorna um evento
        // INumerable retorna um array e nao um evento
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }




        
    }
}
