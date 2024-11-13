using Mislibros_SAVR.Data.Models;
using Mislibros_SAVR.Data.viewModels;
using System;

namespace Mislibros_SAVR.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo que permite agregar una nueva Editora en la BD
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
               Name = publisher.Name,

            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
        
    }
}
