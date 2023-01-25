using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    public class DefaultController : ControllerBase
    {
        protected readonly DataContext _DbContext;

        public DefaultController(DataContext dataContext)
        {
            _DbContext = dataContext;
        }
        protected void SaveChanges()
        {
            _DbContext.SaveChanges();
        }
        

    }
}