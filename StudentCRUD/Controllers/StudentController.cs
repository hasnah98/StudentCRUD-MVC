using Microsoft.AspNetCore.Mvc;
using StudentCRUD.Data;
using StudentCRUD.Models;
using System.Linq;

namespace StudentCRUD.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (student == null) return BadRequest();
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                TempData["Success"] = "Student added successfully!";
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null) return NotFound();
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (student == null) return BadRequest();
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                TempData["Success"] = "Student updated successfully!";
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                TempData["Success"] = "Student deleted successfully!";
            }
            return RedirectToAction("Index");
        }
    }
}
