using SlidersApp_New.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SlidersApp_New.DAL
{
    public class SliderContext:DbContext
    {
        public SliderContext()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Slider>().ToTable("Slider");
        }
        public DbSet<Slider> Sliders { get; set; }
    }
}