using Eterna_Template.DAL;
using Eterna_Template.HomeViewModel;
using Eterna_Template.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Eterna_Template.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext context;

        public ServicesController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<BigCard> bigCards = context.bigCards.ToList();
            List<ProgressBar> progressBars = context.progressBars.ToList();


            HomeVM models = new HomeVM
            {
                bigCards = bigCards,
                progressBars=progressBars
            };
            return View(models);
        }
    }
}
