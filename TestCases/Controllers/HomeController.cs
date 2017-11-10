using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestCases.Models;
using Microsoft.EntityFrameworkCore;

namespace TestCases.Controllers
{
    public class HomeController : Controller
    {
        private TestDBContext db;
        public HomeController(TestDBContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await db.TestCases.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(TestCase testCase)
        {
            db.TestCases.Add(testCase);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                TestCase testCase = await db.TestCases.FirstOrDefaultAsync(p => p.Id == id);
                if (testCase != null)
                    return View(testCase);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if(id != null)
            {
                TestCase testCase = await db.TestCases.FirstOrDefaultAsync(p => p.Id == id);
                if (testCase != null)
                    return View(testCase);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(TestCase testCase)
        {
            db.TestCases.Update(testCase);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                TestCase testCase = await db.TestCases.FirstOrDefaultAsync(p => p.Id == id);
                if (testCase != null)
                    return View(testCase);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                TestCase testCase = new TestCase { Id = id.Value };
                db.Entry(testCase).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
