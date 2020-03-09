using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index() { return View(); }

    [Route("/vacuumForm")]
    public ActionResult VacuumForm() { return View(); }

    [Route("/vacuum-story")]
    public ActionResult VacuumStory(string noun, string verb)
    {
      MadLibsGame newMadLibs = new MadLibsGame();
      newMadLibs.Noun = noun;
      newMadLibs.Verb = verb;
      return View(newMadLibs);
    }

    [Route("/puppyForm")]
    public ActionResult PuppyForm() { return View(); }

    [Route("/puppy-story")]
    public ActionResult PuppyStory(string adjective, string noun)
    {
      MadLibsGame puppyMadLibs = new MadLibsGame();
      puppyMadLibs.Adjective = adjective;
      puppyMadLibs.Noun = noun;
      return View(puppyMadLibs);
    }
  }
}   