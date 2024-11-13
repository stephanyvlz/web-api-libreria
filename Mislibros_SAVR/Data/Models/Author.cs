using System.Collections.Generic;

namespace Mislibros_SAVR.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Propiedades de navegación (
        public List<Book_Author> Books_Authors { get; set; }

    }
}
