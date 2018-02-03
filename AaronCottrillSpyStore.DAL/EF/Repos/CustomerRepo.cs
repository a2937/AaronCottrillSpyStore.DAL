using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AaronCottrillSpyStore.DAL.EF;
using AaronCottrillSpyStore.DAL.Repos.Base;
using AaronCottrillSpyStore.DAL.Repos.Interfaces;
using AaronCottrillSpyStore.Models.Entities;

namespace AaronCottrillSpyStore.DAL.Repos
{
    public class CustomerRepo : RepoBase<Customer>, ICustomerRepo
    {
        public CustomerRepo(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        public CustomerRepo() : base()
        {
        }

        public override IEnumerable<Customer> GetAll()
            => Table.OrderBy(x => x.FullName);

        public override IEnumerable<Customer> GetRange(int skip, int take)
            => GetRange(Table.OrderBy(x => x.FullName), skip, take);

    }
}
