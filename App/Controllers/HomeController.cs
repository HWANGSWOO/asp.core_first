using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App.Data.Repositories;
using App.Models;
using App.ViewModels;
using App.Views.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        public HomeController(ITeacherRepository teacherRepository,
                              IStudentRepository studentRepository)

        {
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
        }
      [Authorize]
        public IActionResult Index()
        {
            var teachers = _teacherRepository.GetAllTeachers();

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Teachers = (List<Teacher>)teachers
                
            };
            return View(viewModel);
        }
     

        [Authorize(Roles = "Admin")]
        public IActionResult Student()
        {
            var students = _studentRepository.GetAllStudents();

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Students = students

            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult Student(StudentTeacherViewModel model)
        {
            if(ModelState.IsValid)
            {
                // model 데이터를 student 테이블에 저장
                _studentRepository.AddStudent(model.Student);
                _studentRepository.Save();

                ModelState.Clear();
            }
            else
            {
                //에러를 보여준다
            }

            var students = _studentRepository.GetAllStudents();
            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Students = students
            };

            return View(viewModel);
        }
        public IActionResult Detail(int id)
        {
            var result = _studentRepository.GetStudent(id);
            return View(result);
        }

        public IActionResult Edit(int id)
        {
            var result = _studentRepository.GetStudent(id);
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.Edit(student);
                _studentRepository.Save();

                return RedirectToAction("Student");
            }

            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var result = _studentRepository.GetStudent(id);
            
            if(result != null)
            {
                _studentRepository.Delete(result);
                _studentRepository.Save();
            }

            return RedirectToAction("Student");
        }
















        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
