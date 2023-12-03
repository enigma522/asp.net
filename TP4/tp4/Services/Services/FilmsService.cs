using tp4.Models;

namespace tp4.Services.Services
{
    public class FilmsService
    {
        private readonly ApplicationdbContext _db;
        public FilmsService(ApplicationdbContext db)
        {
            _db = db;
        }

        public List<Films> GetFilms()
        {
            if (_db == null)
            {
                return null;
            }
            return _db.Films.ToList();
        }

        public void AddFile(Films film)
        {
            _db.Films.Add(film);
            _db.SaveChanges();
        }

        public void DeleteFile(int id)
        {
            Films film = _db.Films.Find(id);

            if (film == null)
            {
                   return;
            }
            _db.Films.Remove(film);
            _db.SaveChanges();
        }

        public IEnumerable<Films> GetFilmsByRole(Role role)
        {
            if(role == null)
            {
                return _db.Films;
            }

            return _db.Films.Where(film => film.Roles != null && film.Roles.Contains(role));
        }

        public IEnumerable<Films> GetFilmsOrderCroissantByName()
        {
            return _db.Films.OrderBy(film => film.Name);
        }

        public IEnumerable<Films> GetFilmsByRoleId(int id)
        {
            return _db.Films.Where(film => film.Roles != null && film.Roles.Any(role => role.Id == id));
        }

    }
}
