using Microsoft.AspNetCore.Mvc;
using purelab.Data;
using purelab.Models;
using System.Diagnostics;

namespace purelab.Controllers
{
    public class HomeController : Controller
    {
        public List<Post> Posts = new List<Post>();
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext   _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger; 
        }

        public IActionResult Index()
        {
            Posts = _context.allPosts.ToList();
            return View(Posts);
        }

        public IActionResult addDb()
        {
            /*Post p1 = new Post();
            p1.ImageUrl = "img/carousel_2.jpg";
            p1.Title = "Lorem ipsum dolor sit amet, consectetur\r\n";
            p1.Subtitle = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et.\r\n\r\n";
            _context.allPosts.Add(p1);
            _context.SaveChanges();
            return View(p1);*/
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}