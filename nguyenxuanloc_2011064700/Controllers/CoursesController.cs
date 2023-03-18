using Microsoft.AspNet.Identity;
using nguyenxuanloc_2011064700.Models;
using nguyenxuanloc_2011064700.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace nguyenxuanloc_2011064700.Controllers
{
    

     
    
        public class CoursesController : Controller
        {
            // GET: Courses
            private readonly ApplicationDbContext _dbContext;
            public CoursesController()
            {
                _dbContext = new ApplicationDbContext();
            }
        // GET: Courses
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
            [Authorize]
            [HttpPost]
            [ValidateAntiForgeryToken]    

            public ActionResult Create(CourseViewModel viewModel)

            {
                if (!ModelState.IsValid)
            {
                viewModel.Categories = _dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
                var course = new course
                {
                    LecturerId = User.Identity.GetUserId(),
                    DateTime = viewModel.GetDateTime(),
                    CategoryId = viewModel.CateGory,
                    Place = viewModel.Place,
                };
                _dbContext.Course.Add(course);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
       
        }
    }


