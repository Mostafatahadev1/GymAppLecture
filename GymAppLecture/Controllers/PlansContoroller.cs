using GymAppLecture.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymAppLecture.Controllers
{
    public class PlansCentroller : Controller
    {

        private readonly GymDbContext dbContext;

        public PlansCentroller()
        {
            dbContext = new GymDbContext();
        }

        // Index Action
        // GET BaseUrl/PlansContoroller/Index => List of Plans


        public async Task <IActionResult> Index()
        {
            var plans = dbContext.Plans.ToListAsync();
            return View(plans);
        }

        //Details Action

        //Get BaseUrl/PlansContoroller/Details/{id} => Details of a Plan
    }
}
