using System.Collections.Generic;
using YtBookStore.Models.Domain;

namespace YtBookStore.Repositories.Abstract
{
    public interface IAuthorService
    {
        IEnumerable<Author> All { get; }

        bool Create(Author model);
        bool Update(Author model);
        bool Delete(int id);
        Author FindById(int id);
        IEnumerable<Author> GetAll();
    }
}
