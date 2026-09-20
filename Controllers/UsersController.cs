using Frist_app.Data;
using Frist_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Frist_app.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _db;

        public UsersController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var userList = _db.User.ToList();
            return View(userList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _db.User.Add(user);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(user);
        }
        [HttpGet]
        public IActionResult Edit(int? SSN)
        {
            if (SSN == null || SSN == 0)
            {
                return NotFound();
            }
            var user = _db.User.Find(SSN);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _db.User.Find(user.SSN);

                if (existingUser == null)
                {
                    return NotFound();
                }

                existingUser.fname = user.fname;
                existingUser.lname = user.lname;

                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(user);

        }
        public IActionResult Delete(int SSN)
        {
            var user = _db.User.Find(SSN);
            if (user == null)
            {
                return NotFound();
            }
            _db.Remove(user);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
//IEnumerable<> userList = _db.User.ToList();