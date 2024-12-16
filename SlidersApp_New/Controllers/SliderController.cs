using SlidersApp_New.DAL;
using SlidersApp_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlidersApp_New.Controllers
{
    public class SliderController : Controller
    {
        private readonly SliderContext context;
        public SliderController() : base()
        {
            context = new SliderContext();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveSlider(Slider s)
        {
            s.Files = Request.Files;
            HttpPostedFileBase file = s.Files[0];
            string fp = "~/Images/Sliders/" + file.FileName;
            s.FilePath = fp;
            if (ModelState.IsValid)
            {
                return View("Index", s);
                
            }
            else
            {
                context.Sliders.Add(s);
                context.SaveChanges();
                file.SaveAs(Server.MapPath(fp));
                List<Slider> slist = context.Sliders.ToList();
                return View("DisplaySlider", slist);
            }
        }
        public ActionResult DisplaySlider()
        {
            List<Slider> Slider = context.Sliders.ToList();
            return View(Slider);
        }
    }
}