using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace calendar.Models.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEvents()
        {
            using (NccuCalendar1 dc = new NccuCalendar1())
            {
                var events = dc.miappcal_sch.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }
        
        public JsonResult addPushNotice(miapppushnotice_cal e)
         {
             var status = false;
             using (NccuCalendar1 dc = new NccuCalendar1())
             {
                 if (e.id > 0)
                 {
                    //Update the event
                     var v = dc.miapppushnotice_cal.Where(a => a.id == e.id).FirstOrDefault();
                     if (v != null)
                     {
                         v.id = 3;   
                         v.ldap_id = e.ldap_id;
                         v.role_cod = null;
                         v.title = e.title;
                         v.body = e.body;
                         v.inserted_date = e.inserted_date;
                         v.set_pushdate = e.set_pushdate;
                         v.tran_date = null;
                         v.istran = false;
                     }
                 }
                 else
                 {
                     dc.miapppushnotice_cal.Add(e);
                 }
                 dc.SaveChanges();
                 status = true;
             }
             return new JsonResult { Data = new { status = status } };
         }
         
        /*
        public JsonResult DeleteEvent(int ID)
        {
            var status = false;
            using (MySQLEntities dc = new MySQLEntities())
            {
                var v = dc.test.Where(a => a.EventId == ID).FirstOrDefault();
                Console.WriteLine("Hello World!");
                if (v != null)
                {
                    dc.test.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }
        */
    }
}