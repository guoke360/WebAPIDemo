using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPIDemo.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Styless> Styless { get; set; }
    }
}