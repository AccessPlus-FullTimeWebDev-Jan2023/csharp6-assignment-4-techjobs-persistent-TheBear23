using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechJobs6Persistent.Data;
using TechJobs6Persistent.Models;
using TechJobs6Persistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobs6Persistent.Controllers
{
    public class EmployerController : Controller
    {
        private readonly JobDbContext _context;

        public EmployerController(JobDbContext context)
        {
            _context = context; 
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var employers = _context.Employers.ToList();
            return View(employers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var addEmployerViewModel = new AddEmployerViewModel();
            return View(addEmployerViewModel);
        }

        [HttpPost]
        public IActionResult ProcessCreateEmployerForm()
        {
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel
            {
                Name = Request.Form["Name"],
                Location = Request.Form["Location"]
            };

            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };
                _context.Employers.Add(newEmployer);
                _context.SaveChanges();
                return Redirect("Index");
            }
            return View("Create", addEmployerViewModel);
        }

        public IActionResult About(int id)
        {
            var employer = _context.Employers.Find(id);
            return View(employer);
        }

    }
}

