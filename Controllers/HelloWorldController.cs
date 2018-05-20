using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;


namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/
        // public async Task<IActionResult> Index(string searchString)
        // {
        //     var movies = from m in _context.Movie
        //                 select m;

        //     if (!String.IsNullOrEmpty(searchString))
        //     {
        //         movies = movies.Where(s => s.Title.Contains(searchString));
        //     }

        //     return View(await movies.ToListAsync());
        // }

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        // public string Welcome()
        // {
        //     return "This is the Welcome action method...";
        // }
        // public string Welcome(string name, int numTimes = 1)
        // {
        //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        // }
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}