using ATP2_Mid_2nd_Lab_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATP2_Mid_2nd_Lab_Task.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello!";
            string name = "Fahim Mahmud Bhuiyan";
            string id = "20-42970-1";
            string email = "fahim.mahi@yahoo.com";
            string phone = "01825814736";

            ViewBag.Name = name;
            ViewBag.Id = id;
            ViewBag.Email = email;
            ViewBag.Phone = phone;

            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "My Education";
            var uni = new Education();
            uni.year = 2024;
            uni.degree = "CSE";
            uni.institute = "American International University-Bangladesh (AIUB)";
            uni.grade = 3.8f;

            var clg = new Education();
            clg.year = 2019;
            clg.degree = "HSC";
            clg.institute = "Milestone College";
            clg.grade = 5.00f;

            var schl = new Education();
            schl.year = 2017;
            schl.degree = "SSC";
            schl.institute = "Cambrian School";
            schl.grade = 5.00f;

            var edu = new Education[] { uni, clg, schl };

            ViewBag.Edu = edu;

            return View();
        }

        public ActionResult PersonalDetails()
        {
            ViewBag.Message = "My Personal Details";

            string father_name = "Bhuiyan";
            string mother_name = "Nesa";
            string address = "Bashundhara, Dhaka.";
            string dob = "31/12/1999";
            string nationality = "Bangladeshi";
            string religion = "Islam";
            string married_status = "Single";

            ViewBag.father_name = father_name;
            ViewBag.Mother_name = mother_name;
            ViewBag.address = address;
            ViewBag.dob = dob;
            ViewBag.nationality = nationality;
            ViewBag.Religion = religion;
            ViewBag.MarriedStatus = married_status;

            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Message = "My Projects";

            var project1 = new Projects();
            project1.project_name = "Mental Health Counciling Management System";
            project1.course_name = "Web Technologies";
            project1.pl_name = "PHP, JS";
            project1.project_description = "The Mental Health Counseling Management System (MHCMS) is a technology-driven, effective platform designed to meet the growing need for mental health services.";
            
            var project2 = new Projects();
            project2.project_name = "Player Management System";
            project2.course_name = "Object Oriented Programming 2 (C#)";
            project2.pl_name = "C#";
            project2.project_description = "The Player Management System aims to create a centralized platform to efficiently manage and organize information related to players involved in a sports context.";

            var project3 = new Projects();
            project3.project_name = "Automatic Timetable Management System";
            project3.course_name = "Object Oriented Programming 1 (JAVA)";
            project3.pl_name = "JAVA";
            project3.project_description = "The Automatic Timetable Management System for University Course Registration is designed to streamline the course registration process and automatically generate timetables for students and faculty. The system aims to efficiently allocate resources, prevent scheduling conflicts, and enhance the overall experience for students during the course registration period.";

            var project4 = new Projects();
            project4.project_name = "Quiz Management System";
            project4.course_name = "Object Oriented Analysis and Design";
            project4.pl_name = "None";
            project4.project_description = "Quiz Management System is a web-based examination system where quiz is taken through the internet using computer system. Quiz Management System is to take Semester Quizzes in an efficient manner and no time wasting for checking the paper.";

            var project5 = new Projects();
            project5.project_name = "Phonebook Management System";
            project5.course_name = "Introduction To Programming Lab";
            project5.pl_name = "C++";
            project5.project_description = "The Phonebook Management System is designed to efficiently manage and organize contact information. This system will provide users with a centralized platform to store, retrieve, update, and delete contact details.";

            var projects = new Projects[] { project1, project2, project3, project4, project5 };
            ViewBag.projects = projects;

            return View();
        }
        public ActionResult References()
        {
            ViewBag.Message = "References";

            var refer = new References();
            refer.ref_name = "Md. Nazmul Hossain";
            refer.ref_designation = "Lecturer";
            refer.ref_department = "Department of Computer Science";
            refer.ref_institute = "American International University-Bangladesh (AIUB).";
            refer.ref_email = "nazmul@aiub.edu";

            var refer2 = new References();
            refer2.ref_name = "Tanvir Ahmed";
            refer2.ref_designation = "Lecturer";
            refer2.ref_department = "Department of Computer Science";
            refer2.ref_institute = "American International University-Bangladesh (AIUB).";
            refer2.ref_email = "tanvir.ahmed@aiub.edu";

            var references = new References[] { refer, refer2 };
            ViewBag.references = references;

            return View();
        }
    }
}