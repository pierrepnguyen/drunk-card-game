using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dcg.Models;

namespace dcg.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
      Deck myDeck = new Deck();
      myDeck.CreateDeck();
      myDeck.Shuffle();
      myDeck.Deal();
      return View(myDeck);
    }

  }
}
