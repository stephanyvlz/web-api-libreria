using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mislibros_SAVR.Data.Services;
using Mislibros_SAVR.Data.viewModels;

namespace Mislibros_SAVR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorsService _authorServices;
        public AuthorsController(AuthorsService authorsServices)
        {
            _authorServices = authorsServices;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorServices.AddAuthor(author);
            return Ok();
        }
    }
    
}
