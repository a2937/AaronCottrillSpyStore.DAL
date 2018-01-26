using AaronCottrillSpyStore.DAL.EF.Repos.Base;
using AaronCottrillSpyStore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AaronCottrillSpyStore.DAL.EF.Repos
{
    public class CategoryRepo : RepoBase<Category>
    {
        public CategoryRepo(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        public CategoryRepo()
        {
        }
        public override IEnumerable<Category> GetAll()
            => Table.OrderBy(x => x.CategoryName);

        public override IEnumerable<Category> GetRange(int skip, int take)
            => GetRange(Table.OrderBy(x => x.CategoryName), skip, take);
    }
}
