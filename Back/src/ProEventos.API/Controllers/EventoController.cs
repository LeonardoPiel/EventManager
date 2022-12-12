using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public EventController()
        {
        }
        private IEnumerable<Event> _event = new Event[]
        {
          new Event() 
               {
                  EventId = 1,
                  EventDate = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                  Local = "Campo Grande MS",
                  Number = 1,
                  ImageUrl = "images/eventCG.jpeg",
                  PeopleAmount = 250,
                  Subject = "C# Programming"
               },
            new Event() 
               {
                  EventId = 2,
                  EventDate = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                  Local = "Dourados MS",
                  Number = 2,
                  ImageUrl = "images/eventDdos.jpeg",
                  PeopleAmount = 100,
                  Subject = "Angular Programming"
               }
        };


        [HttpGet]
        public IEnumerable<Event> Get()
        {
           return _event;
        }
        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
           return _event.Where(e => e.EventId == id);
        }
        [HttpPost]
        public string Post()
        {
           return "Inseriu";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Testando put com id {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
           return $"Removendo com id {id}";
        }
    }
}
