using GymAppLecture.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymAppLecture.Controllers
{
    public class PlansController : Controller
    {

        private readonly GymDbContext dbContext;

        public PlansController()
        {
            dbContext = new GymDbContext();
        }

        // Index Action
        // GET BaseUrl/PlansContoroller/Index => List of Plans


        public async Task<IActionResult> Index()
        {
            var plans = await dbContext.Plans.ToListAsync();
            return View(plans);
        }

        //Details Action

        //Get BaseUrl/PlansContoroller/Details/{id} => Details of a Plan

        public async Task<IActionResult> Details(int id)
        {
            var plan = await dbContext.Plans.FindAsync(id);

            if (plan is null)
                return RedirectToAction(nameof(Index));

            return View(plan);
        }

    }
}
