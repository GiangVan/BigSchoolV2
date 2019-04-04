using BigSchool2.Models;
using BigSchool2.ViewModels;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        [HttpPost]
        public ActionResult Index(CourseViewModel ViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", ViewModel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = ViewModel.GetDateTime(),
                CategoryId = ViewModel.Category,
                Place = ViewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}