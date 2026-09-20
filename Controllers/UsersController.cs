using Frist_app.Data;
using Microsoft.AspNetCore.Mvc;

namespace Frist_app.Controllers
{
    public class UsersController : Controller
    {
        

        public UsersController(AppDbContext db)
        {
            _db = db;
        }
        private readonly AppDbContext _db;
        public IActionResult Index()
        {
            var userList = _db.User.ToList();
            return View(userList);
        }
    }
}
//IEnumerable<> userList = _db.User.ToList();