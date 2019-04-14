using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amazon.Models;

namespace Amazon.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        //para mostar vista
        [HttpGet]
        public ViewResult RegBookForm()
        {
            // TODO: store reponse from visitor 
            return View();
        }

        //post cualquier acción que incluya datos
        [HttpPost]
        public ViewResult RegBookForm(Book book)
        {
            if (ModelState.IsValid)
            {
                // TODO: store reponse from visitor
                BookRepository.AddResponse(book);
                return View("Thanks", book);
            }
            else
            {
                //Hay un error en las validaciones
                return View();
            }
        }

        //mostrar un vista de lista de libros
        [HttpGet]
        public ViewResult ListResponse()
        {
            return View(BookRepository.Books);
        }



        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
