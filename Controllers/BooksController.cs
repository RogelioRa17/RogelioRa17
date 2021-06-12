using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    public class BooksController : Controller
    {
        // private readonly ApplicationDbContext _context;

        // public BooksController(ApplicationDbContext context)
        // {
        //     _context = context;
        // }

        public IActionResult Index() 
        {
            // var books = _context.Books.ToList();
            return View();
        }
        
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

    }
}