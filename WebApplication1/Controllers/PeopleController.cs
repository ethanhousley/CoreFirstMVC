using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult Index()
        {
            var Ethan = new Person();
            

            return View(Ethan);

        }
        
        
        public IActionResult AddPerson()
        {
            
           
            return View();

        }
        
        [HttpPost]
        public IActionResult NewUser(Person person)
        {

            var newUser = person;
            
            
            return View(newUser);

        }
    }
}
