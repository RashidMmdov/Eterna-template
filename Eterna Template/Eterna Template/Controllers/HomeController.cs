using Eterna_Template.DAL;
using Eterna_Template.HomeViewModel;
using Eterna_Template.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna_Template.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = context.Sliders.ToList();
            List<MiniCard> miniCards = context.miniCards.ToList();
            List<BigCard> bigCards = context.bigCards.ToList();



            HomeVM models = new HomeVM
            {
                Sliders=sliders,
                miniCards=miniCards,
                bigCards=bigCards
            };
            return View(models);
        }
    }
}
