using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace tutorial_mvc_net.Controllers;

public class HelloWorldController : Controller
{
    // Cada método public en un controlador puede ser invocado como un punto de conexión HTTP
    // Es una dirección URL que se puede establecer como destino en la aplicación web, por ejemplo, https://localhost:5001/HelloWorld

    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // Requires using System.Text.Encodings.Web;
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}