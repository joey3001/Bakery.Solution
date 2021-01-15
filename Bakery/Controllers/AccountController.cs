using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Bakery.Models;
using System.Threading.Tasks;
using Bakery.ViewModels;
using System.Linq;
using System.Security.Claims;

namespace Bakery.Controllers
{
  public class AccountController : Controller
  {
    private readonly BakeryContext _db; 
    private readonly UserManager<ApplicationUser> _userManager; 
    private readonly SignInManager<ApplicationUser> _signInManager; 

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, BakeryContext db)
    {
      _userManager = userManager;
      _signInManager = signInManager; 
      _db = db; 
    }
  }
}