using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookCatalog.Models;

namespace BookCatalog.Data
{
    public class BookCatalogContext : DbContext
    {
        public BookCatalogContext (DbContextOptions<BookCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<BookCatalog.Models.Book> Book { get; set; } = default!;
    }
}
