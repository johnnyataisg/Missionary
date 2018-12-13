using Missionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Missionary.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        static Mission mission = new Mission();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Mission()
        {
            return View();
        }

        public ActionResult MissionInfo(string value)
        {
            if (value == "Shanghai")
            {
                mission.MissionName = "China Shanghai Mission";
                mission.PresidentName = "Xi Jin Ping";
                mission.Address = "1912 Democracy St, Shanghai";
                mission.Language = "Mandarin Chinese";
                mission.Climate = "Not too hot, mildly humid";
                mission.Religion = "Materialism";
                mission.Flag = "../Content/255px-Flag_of_the_People's_Republic_of_China.svg.png";
            }
            else if (value == "Pyongyang")
            {
                mission.MissionName = "North Korea Pyongyang Mission";
                mission.PresidentName = "Kim Jong Eun";
                mission.Address = "1776 America Blvd, Pyongyang";
                mission.Language = "Korean";
                mission.Climate = "Politically sensitive";
                mission.Religion = "Kim Ancestral Worship";
                mission.Flag = "../Content/1200px-Flag_of_North_Korea.svg.png";
            }
            else
            {
                mission.MissionName = "Spirit Prison Mission";
                mission.PresidentName = "Jesus";
                mission.Address = "Paradise Temple Work Mission Department Room AD-33";
                mission.Language = "Multilingual";
                mission.Climate = "Not applicable";
                mission.Religion = "Awaiting Conversion-ism";
                mission.Flag = "../Content/Christ_in_Spirit_World-e1385391202877.jpg";
            }
            ViewBag.Mission = mission.MissionName;
            ViewBag.Output += "<div class=\"mission-textbox\">";
            ViewBag.Output += "<h4>Mission Name: " + mission.MissionName + "</h4>";
            ViewBag.Output += "<h4>President's Name: " + mission.PresidentName + "</h4>";
            ViewBag.Output += "<h4>Mission Address: " + mission.Address + "</h4>";
            ViewBag.Output += "<h4>Language Spoken: " + mission.Language + "</h4>";
            ViewBag.Output += "<h4>Area Climate: " + mission.Climate + "</h4>";
            ViewBag.Output += "<h4>Local Religion: " + mission.Religion + "</h4>";
            ViewBag.Output += "<img style=\"width: 300px; height: 200px;\" src=" + mission.Flag + ">";
            ViewBag.Output += "</div>";
            return View("MissionInfo");
        }

        public ActionResult Reply()
        {
            ViewBag.Mission = mission.MissionName;
            ViewBag.Output += "<div class=\"mission-textbox\">";
            ViewBag.Output += "<h4>Mission Name: " + mission.MissionName + "</h4>";
            ViewBag.Output += "<h4>President's Name: " + mission.PresidentName + "</h4>";
            ViewBag.Output += "<h4>Mission Address: " + mission.Address + "</h4>";
            ViewBag.Output += "<h4>Language Spoken: " + mission.Language + "</h4>";
            ViewBag.Output += "<h4>Area Climate: " + mission.Climate + "</h4>";
            ViewBag.Output += "<h4>Local Religion: " + mission.Religion + "</h4>";
            ViewBag.Output += "<img style=\"width: 300px; height: 200px;\" src=" + mission.Flag + ">";
            ViewBag.Output += "</div>";
            ViewBag.Reply += "<textarea placeholder=\"Type something...\" style=\"margin-top: 15px;\" class=\"form-control\" rows=\"10\" cols=\"75\"></textarea>";
            return View("MissionInfo");
        }
    }
}