using System.Collections.Generic;
using YtBookStore.Models.Domain;

namespace YtBookStore.Repositories.Abstract
{
    public interface IPublisherService
    {
        bool Create(Publisher model);
        bool Update(Publisher model);
        bool Delete(int id);
        Publisher FindById(int id);
        IEnumerable<Publisher> All { get; }
        IEnumerable<Publisher> GetAll();
    }
}
