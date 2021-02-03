using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PortalGroup_Omer_Karagulmez.Models;

namespace PortalGroup_Omer_Karagulmez.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Starbucks()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Starbucks(string name, string surname, string mail, string password, string tel, string gender, DateTime birthdate,string ID_NO)
        {
            if (MernisHelper.IDCheck(long.Parse(ID_NO), name, surname, birthdate.Year))
            {
                ViewBag.Result = "Registration succeed.";
                StarbucksEntities starbucksEntities = new StarbucksEntities();
                TBL_CUSTOMERS customer = new TBL_CUSTOMERS();
                customer.Name = name;
                customer.Surname = surname;
                customer.Mail = mail;
                customer.Password = password;
                customer.Telephone = tel;
                customer.Gender = gender;
                customer.Identity_No = ID_NO;
                customer.Birth_Date = Convert.ToDateTime(birthdate.ToShortDateString());
                starbucksEntities.TBL_CUSTOMERS.Add(customer);
                starbucksEntities.SaveChanges();
            }
            else
            {
                ViewBag.Result = "Invalid Identity Number please check and try again.";
            }
                        
            return View();
        }
        public ActionResult Portal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Portal(string name, string surname, string mail, string password, string tel, string gender, DateTime birthdate, string ID_NO)
        {
            try
            {
                PortalEntities portalEntities = new PortalEntities();
                TBL_CUSTOMERS customer = new TBL_CUSTOMERS();
                customer.Name = name;
                customer.Surname = surname;
                customer.Mail = mail;
                customer.Password = password;
                customer.Telephone = tel;
                customer.Gender = gender;
                customer.Identity_No = ID_NO;
                customer.Birth_Date = Convert.ToDateTime(birthdate.ToShortDateString());
                portalEntities.TBL_CUSTOMERS.Add(customer);
                portalEntities.SaveChanges();
                ViewBag.Result = "Registration succeed.";
            }
            catch
            {
                ViewBag.Result = "Invalid Identity Number please check and try again.";
            }
            return View();
        }
    }
}