using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mislibros_SAVR.Data.Services;
using Mislibros_SAVR.Data.viewModels;

namespace Mislibros_SAVR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publisherServices;
        public PublishersController(PublishersService publishersServices)
        {
            _publisherServices = publishersServices;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherVM publisher)
        {
            _publisherServices.AddPublisher(publisher);
            return Ok();
        }
    }
}
