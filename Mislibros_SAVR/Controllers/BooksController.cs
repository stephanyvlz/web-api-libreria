using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mislibros_SAVR.Data.Services;
using Mislibros_SAVR.Data.viewModels;

namespace Mislibros_SAVR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }
        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksService.AddBook(book);
            return Ok();
        }
    }
}
