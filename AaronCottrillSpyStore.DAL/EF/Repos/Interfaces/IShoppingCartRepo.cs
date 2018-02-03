using System.Collections.Generic;
using AaronCottrillSpyStore.DAL.Repos.Base;
using AaronCottrillSpyStore.Models.Entities;
using AaronCottrillSpyStore.Models.ViewModels;

namespace AaronCottrillSpyStore.DAL.Repos.Interfaces
{
    public interface IShoppingCartRepo :IRepo<ShoppingCartRecord>
    {
        CartRecordWithProductInfo GetShoppingCartRecord(int customerId, int productId);
        IEnumerable<CartRecordWithProductInfo> GetShoppingCartRecords(int customerId);
        int Purchase(int customerId);
        ShoppingCartRecord Find(int customerId, int productId);
        int Update(ShoppingCartRecord entity, int? quantityInStock, bool persist = true);
        int Add(ShoppingCartRecord entity, int? quantityInStock, bool persist = true);
    }
}
