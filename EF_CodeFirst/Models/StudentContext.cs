using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EF_C1.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<student> students { get; set; }
    }
}