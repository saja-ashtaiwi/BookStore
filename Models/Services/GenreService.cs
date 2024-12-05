using System;
using System.Collections.Generic;
using System.Linq;
using BookStore.BLL;
using BookStore.Models.Services.Bases;
using BookStore.Models.Domain;

namespace BookStore.Models.Services
{
    public class GenreService : IGenreService
    {
        private readonly DatabaseContext context;
        public GenreService(DatabaseContext context)
        {
            this.context = context;
        }
        public bool Create(Genre model)
        {
            try
            {
                context.Genre.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Create(Genre model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            try
            {
                var data = FindById(id);
                if (data == null)
                    return false;
                context.Genre.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Genre FindById(int id)
        {
            return context.Genre.Find(id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return context.Genre.ToList();
        }

        public bool Update(Genre model)
        {
            try
            {
                context.Genre.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        IEnumerable<Genre> IGenreService.GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
