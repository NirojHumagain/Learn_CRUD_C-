using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LearnCRUDOperation.Models;

namespace LearnCRUDOperation.Controllers
{
    public class PersonDetailController : Controller
    {
        //    public IActionResult Index()
        //    {
        //        return View();
        //    }
        private readonly PersonDetailContext _context;
        public PersonDetailController(PersonDetailContext context)
        {
            _context = context;
        }
        //GET: PersonDetail
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonDetails.ToListAsync());
        }
        //GET: PersonDetail/Create
        public IActionResult AddorEdit(int id = 0)
        {
            if (id == 0)
                return View(new PersonDetails());
            else
                return View(_context.PersonDetails.Find(id));
        }
        //POST:PeopleDetail/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddorEdit([Bind("Id, FirstName, MiddleName, LastName, Age, Gender, Address, PhoneNumber, Country, Email")] PersonDetails personDetail5)
        {
            if (ModelState.IsValid)
            {
                if (personDetail5.Id == 0)
                {
                    _context.Add(personDetail5);
                }
                else
                    _context.Update(personDetail5);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personDetail5);
        }
        //GET:PersonDeatail/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            var PersonDetail = await _context.PersonDetails.FindAsync(id);
            _context.PersonDetails.Remove(PersonDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}

