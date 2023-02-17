using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ReposiratoryPattern.BL.Interface;
using ReposiratoryPattern.BL.ModelVM;
using ReposiratoryPattern.DAL.Entites;
namespace ReposiratoryPattern.PL.Controllers
{
    public class BookController : Controller
    {
        private readonly IBaseReposaratory<Book> book;
        private readonly IMapper mapper;
        public BookController(IBaseReposaratory<Book> book, IMapper mapper)
        {
            this.book = book;
            this.mapper = mapper;
        }
        public async Task <IActionResult> Index()
        {
            var data = await book.GetALLAsync();
            var result = mapper.Map<IEnumerable<BookVM>>(data);
            return View(result);
        }
    }
}
