using System.Collections.Generic;
using BookStore.BLL;

namespace BookStore.Models.Services.Bases
{
    public interface IGenreService
    {
        bool Create(Genre model);
        bool Update(Genre model);
        bool Delete(int id);
        Genre FindById(int id);
        IEnumerable<Genre> GetAll();
    }
}
