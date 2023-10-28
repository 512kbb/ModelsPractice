using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelsPractice.Models;

namespace ModelsPractice.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        string Text = "Aqui hay un texto que sera renderizado en la pagina principal atraves del viewmodel jaja xd saludos profe";
        return View("Index", Text);
    }

    [HttpGet("numbers")]
    public IActionResult Numbers () 
    {   
        int[] numbers = new int[6] { 1, 2, 3, 10, 43, 5 };
        return View(numbers);
    }

    [HttpGet("users")]
    public IActionResult Users ()
    {
        List<string> users = new() { "Tomas", "Nacho", "Byrons", "Benja", "Diego", "Ignacio" }; 
        return View(users);
    }

    [HttpGet("user")]
    public IActionResult User ()
    {
        Usuario user = new()
        {
            FirstName = "Ignacio",
            LastName = "Angulo",
            Age = 22,
            Location = "Puente Alto"
        };
        return View(user);
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
