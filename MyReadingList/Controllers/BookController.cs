using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyReadingList.Models;
using MyReadingList.Services;

namespace MyReadingList.Controllers
{
    //This is the route to the class
    [Route("api/[controller]")]
    //tell .NET to treat the class as a webapi controller
    [ApiController]
    public class BookController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Book>> GetAllBooks() => BookService.GetAll();

        [HttpGet]
        [Route ("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var book = BookService.Get(id);
            if (book == null)
                return NotFound();
            return book;
        }
    }

}
