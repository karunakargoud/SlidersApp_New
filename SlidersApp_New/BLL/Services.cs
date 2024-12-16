using SlidersApp_New.DAL;
using SlidersApp_New.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlidersApp_New.BLL
{
    public class Services
    {
        public List<Slider> GetAllSliders()
        {
            SliderContext dal = new SliderContext();
            List<Slider> sliders = dal.Sliders.ToList();
            return sliders;
        }

    }
}