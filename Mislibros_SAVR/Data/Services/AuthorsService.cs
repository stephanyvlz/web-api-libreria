using Mislibros_SAVR.Data.Models;
using Mislibros_SAVR.Data.viewModels;
using System;

namespace Mislibros_SAVR.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que permite agregar un nuevo Autor en la BD
        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
               FullName = author.FullName,

            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
        
    }
}
