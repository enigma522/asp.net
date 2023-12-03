using Microsoft.AspNetCore.Mvc;
using tp4.Services.Services;
using tp4.Models;

namespace tp4.Controllers
{
    public class FilmsController : Controller
    {

        private readonly FilmsService filmsService;

        public FilmsController(FilmsService filmsService)
        {
            this.filmsService = filmsService;
        }
        public IActionResult Index()
        {
            var films = filmsService.GetFilms();
            return View(films);
        }
        [HttpGet]
        [Route("Films/ordered")]
        public IEnumerable<Films> GetFilmsOrderCroissantByName()
        {
            
            return filmsService.GetFilmsOrderCroissantByName();
        }

        [HttpGet]
        [Route("Films/role/{id}")]
        public IEnumerable<Films> GetFilmsByRoleId(int id)
        {
            return filmsService.GetFilmsByRoleId(id);
        }

        [HttpGet]
        [Route("Films/role")]
        public IEnumerable<Films> GetFilmsByRole(Role role)
        {
            return filmsService.GetFilmsByRole(role);
        }

        [HttpPost]
        [Route("Films/add")]
        public void AddFile(Films film)
        {
            filmsService.AddFile(film);
        }
        [HttpDelete]
        [Route("Films/{id}")]
        public void DeleteFile(int id)
        {
            filmsService.DeleteFile(id);
        }



        
    }
}
