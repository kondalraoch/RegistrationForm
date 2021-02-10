using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistrationForm.Models;

namespace RegistrationForm.Controllers
{
   public class RegistrationController : Controller  
    {  
        private readonly ApplicationDbContext _dbcontext;  
  
        public RegistrationController(ApplicationDbContext dbContext)  
        {  
            _dbcontext = dbContext;  
        }  
        public IActionResult Index()  
        {  
            return View();  
        }  
        public IActionResult Create()  
        {  
            return View();  
        }  
  
        [HttpPost]  
        [ValidateAntiForgeryToken]  
        public IActionResult Create(Registration userinfo)  
        {  
            if(ModelState.IsValid)
            {
            _dbcontext.Add(userinfo);  
            _dbcontext.SaveChanges();  
            ViewBag.message = "The user " + userinfo.UserName + " is saved successfully";  
            }
            return View();  
        }  
    }  
}
