using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TextDumper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;userid=textdumper;password=textdumper;database=flikka_org;");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM textdump");
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}