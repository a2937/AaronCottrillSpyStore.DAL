using System.Collections.Generic;
using AaronCottrillSpyStore.DAL.Repos.Base;
using AaronCottrillSpyStore.Models.Entities;
using AaronCottrillSpyStore.Models.ViewModels;

namespace AaronCottrillSpyStore.DAL.Repos.Interfaces
{
    public interface IOrderDetailRepo :IRepo<OrderDetail>
    {
        IEnumerable<OrderDetailWithProductInfo> GetCustomersOrdersWithDetails(int customerId);
        IEnumerable<OrderDetailWithProductInfo> GetSingleOrderWithDetails(int orderId);
    }
}
