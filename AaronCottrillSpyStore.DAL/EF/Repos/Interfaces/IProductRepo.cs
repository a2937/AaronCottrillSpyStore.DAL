using System.Collections.Generic;
using AaronCottrillSpyStore.DAL.Repos.Base;
using AaronCottrillSpyStore.Models.Entities;
using AaronCottrillSpyStore.Models.ViewModels.Base;

namespace AaronCottrillSpyStore.DAL.Repos.Interfaces
{
    public interface IProductRepo : IRepo<Product>
    {
        IEnumerable<ProductAndCategoryBase> Search(string searchString);
        IEnumerable<ProductAndCategoryBase> GetAllWithCategoryName();
        IEnumerable<ProductAndCategoryBase> GetProductsForCategory(int id);
        IEnumerable<ProductAndCategoryBase> GetFeaturedWithCategoryName();
        ProductAndCategoryBase GetOneWithCategoryName(int id);
    }
}
