using System.Collections.Generic;
using AaronCottrillSpyStore.DAL.Repos.Base;
using AaronCottrillSpyStore.Models.Entities;
using AaronCottrillSpyStore.Models.ViewModels;

namespace AaronCottrillSpyStore.DAL.Repos.Interfaces
{
    public interface IOrderRepo :IRepo<Order>
    {
        IEnumerable<Order> GetOrderHistory(int customerId);
        OrderWithDetailsAndProductInfo GetOneWithDetails(int customerId, int orderId);
    }
}
