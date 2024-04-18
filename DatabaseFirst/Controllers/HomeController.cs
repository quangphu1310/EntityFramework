using DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private QuanLySinhVienCodeFirstThayHuyContext _db;
        public HomeController(ILogger<HomeController> logger, QuanLySinhVienCodeFirstThayHuyContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var list = _db.SinhViens.Include(x=> x.Lop).ThenInclude(x=> x.Khoa)
                .Where(x => x.Lop.KhoaId == 1 && x.Age >= 18 && x.Age <=20).ToList();
            return View(list);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
