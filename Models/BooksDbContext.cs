using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EspritASPWorkshop.Models
{
    public class BooksDbContext:DbContext
    {


        public DbSet<Book> Books { get; set; }

        public BooksDbContext() :base("BooksDbContext")
        {

        }

    }
}