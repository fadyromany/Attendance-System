using Attendance_System.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Attendance_System.Controllers
{
    
    public class HomeController : Controller
    {
        //[AllowAnonymous]
        public IActionResult Index()
        {
            return View();

        }
        [HttpGet]
        //[AllowAnonymous]
        public IActionResult CreateEmployee()
        {
            return View();

        }


        [HttpPost]
        //[AllowAnonymous]
        public IActionResult CreateEmployee(CreateEmployeeCredantialsVM model)
        {
            //if(ModelState.IsValid)
            //{
            //    SmtpClient smtpClient = new SmtpClient();
            //    smtpClient.Credentials=new System.Net.NetworkCredential

            //}

            return View();

        }
        }
    }
