using BigSchool2.Models;
using BigSchool2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool2.Controllers
{
    public class CoursesController : Controller
    {
        readonly ApplicationDbContext _dbContext;
        // GET: Courses
        public ActionResult Index()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}