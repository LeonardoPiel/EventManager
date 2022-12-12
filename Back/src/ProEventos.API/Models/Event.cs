using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Local { get; set; }
        public string EventDate { get; set; }
        public string Subject { get; set; }
        public int PeopleAmount { get; set; }
        public int Number { get; set; }
        public string ImageUrl {get;set;}
        

    }
}