using Eterna_Template.DAL;
using Eterna_Template.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eterna_Template.Areas.EternaAdmin.Controllers
{
    [Area("EternaAdmin")]
    public class SliderController : Controller
    {
        private readonly AppDbContext context;

        
        public SliderController(AppDbContext context)
        {
            this.context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await context.Sliders.ToListAsync();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
           await context.Sliders.AddAsync(slider);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Slider slider = await context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        
        public async Task<IActionResult> Edit(int id)
        {
            Slider slider = await context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        
        public async Task<IActionResult> Edit(int id,Slider slider)
        {
            Slider exsisterSlid = await context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (exsisterSlid == null) return NotFound();
            if (id != slider.Id) return BadRequest();
            exsisterSlid.Title = slider.Title;
            exsisterSlid.SubTitle = slider.SubTitle;
            exsisterSlid.Image = slider.Image;

            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            Slider slider = await context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound(); 
            return View(slider);
        }
        [HttpPost]
        
        public async Task<IActionResult> DeleteSlid(int id)
        {
            Slider slider = await context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            if (slider == null) return NotFound();
            context.Sliders.Remove(slider);
            await context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
