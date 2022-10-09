using Microsoft.AspNetCore.Mvc;

namespace Movie.Mvc.Controllers;

public class HelloWorldController : Controller
{
  //
  // GET: /HelloWorld/
  public string Index()
  {
    return "This is my default action ....";
  }

  //
  // GET: /HelloWorld/Welcome/
  public string Welcome()
  {
    return "This is the Welcome action method...";
  }
  
  //
  // GET: /HelloWorld/Bye/
  public string Bye()
  {
    return "See you when I see you.";
  }
}