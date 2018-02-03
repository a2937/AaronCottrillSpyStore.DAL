using System.Collections.Generic;
using AaronCottrillSpyStore.DAL.Repos.Base;
using AaronCottrillSpyStore.Models.Entities;

namespace AaronCottrillSpyStore.DAL.Repos.Interfaces
{
    public interface ICategoryRepo : IRepo<Category>
    {
        IEnumerable<Category> GetAllWithProducts();
        Category GetOneWithProducts(int? id);
    }
}