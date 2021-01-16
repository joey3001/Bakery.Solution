using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Controllers
{
  public class FlavorsController : Controller 
  {
    private readonly BakeryContext _db; 
    public FlavorsController(BakeryContext db) 
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }
  }
}