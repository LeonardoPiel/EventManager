using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
		public Event Post(Event obj)
		{
			_DbContext.Events.Add(obj);
			SaveChanges();
			return obj;
		}
		
		[HttpPut("{id}")]
		public string Put(int id, Event obj)
		{
			var eventToUpdate = new Event();
			if(id > 0)
			{
				eventToUpdate = GetById(id);
				eventToUpdate.ImageUrl = obj.ImageUrl;
				eventToUpdate.Number = obj.Number;
				eventToUpdate.EventDate = obj.EventDate;
				eventToUpdate.PeopleAmount = obj.PeopleAmount;
				eventToUpdate.Subject = obj.Subject;
				SaveChanges();
			}
			return JsonConvert.SerializeObject(eventToUpdate);
		}
		[HttpDelete("{id}")]
		public string Delete(int id)
		{
			return $"Removendo com id {id}";
		}
	 }
}
