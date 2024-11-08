using Mislibros_SAVR.Data.viewModels;
using Mislibros_SAVR.Data.Models;
using System;

namespace Mislibros_SAVR.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM book)
        {
            var _book = new Books()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now,

            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

    }
}
