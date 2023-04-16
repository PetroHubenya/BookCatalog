using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookCatalog.Data;
using BookCatalog.Models;

namespace BookCatalog.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookCatalog.Data.BookCatalogContext _context;

        public IndexModel(BookCatalog.Data.BookCatalogContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
