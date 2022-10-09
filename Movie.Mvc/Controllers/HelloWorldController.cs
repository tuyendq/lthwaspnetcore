using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Movie.Mvc.Controllers;

public class HelloWorldController : Controller
{
  //
  // GET: /HelloWorld/
  // public string Index()
  // {
  //   return "This is my default action ....";
  // }
  public IActionResult Index()
  {
    return View();
  }

  //
  // GET: /HelloWorld/Welcome/
  // Requires: using System.Text.Encodings.Web;
  public string Welcome(string name,int ID = 1, int numTimes = 1)
  {
    // return "This is the Welcome action method...";
    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}, ID: {ID}");
  }

  //
  // GET: /HelloWorld/Bye/
  public string Bye()
  {
    return "See you when I see you.";
  }
}