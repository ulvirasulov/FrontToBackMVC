using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext appDbContext;
        public HomeController(AppDbContext dbContext)
        {
            appDbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = appDbContext.Sliders.ToList();
            
            List<TeamMembers> teamMembers = appDbContext.TeamMembers.ToList();            

            HomeViewModel hvm = new HomeViewModel()
            {
                Sliders = sliders,
                TeamMembers = teamMembers
            };

            return View(hvm);
        }
    }
}
