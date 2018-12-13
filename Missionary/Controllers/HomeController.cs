﻿using Missionary.DAL;
using Missionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Missionary.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private MissionDatabase db = new MissionDatabase();
        static User currentUser = new User();
        
        public ActionResult Index()
        {
            ViewBag.User = currentUser.Email;
            return View();
        }

        public ActionResult About()
        {
            return View(currentUser);
        }

        public ActionResult Contact()
        {
            return View();
        }
        
        public ActionResult Mission()
        {
            List<Mission> missionList = db.Missions.ToList();
            return View(missionList);
        }

        public ActionResult MissionInfo(int value)
        {
            if (currentUser.UserID == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else
            {
                Mission mission = db.Missions.Find(value);
                return View(mission);
            }
        }

        public ActionResult Reply()
        {
            
            return View("MissionInfo");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user, string confirmPassword)
        {
            if (ModelState.IsValid)
            {
                User test = db.Users.Where(m => m.Email == user.Email).FirstOrDefault();
                if (test == null)
                {
                    if (user.Password == confirmPassword)
                    {
                        db.Users.Add(user);
                        db.SaveChanges();
                        FormCollection form = new FormCollection();
                        form["email"] = user.Email;
                        form["password"] = user.Password;
                        return Login(form);
                    }
                    else
                    {
                        return View();
                    }
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string email = form["email"].ToString();
            string password = form["password"].ToString();

            User user = db.Users.Where(m => m.Email == email && m.Password == password).FirstOrDefault();
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(email, false);
                currentUser = user;
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult Logoff()
        {
            currentUser = new User();
            return RedirectToAction("Index", "Home");
        }
    }
}