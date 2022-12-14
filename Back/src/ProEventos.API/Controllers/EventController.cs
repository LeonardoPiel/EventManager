using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : DefaultController
    {
      public EventController(DataContext dbContext) : base (dbContext) {}

      [HttpGet]
      public IEnumerable<Event> Get()
      {
         return _DbContext.Events;
      }
      [HttpGet("{id}")]
      public Event GetById(int id)
      {
         return _DbContext.Events.FirstOrDefault(e => e.EventId == id);
      }
      [HttpPost]
      public Event Post(Event json)
      {
         _DbContext.Events.Add(json);
         SaveChanges();
         return json;
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
