using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _dbContext;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWork(ApplicationDBContext db)
        {
            this._dbContext = db;
            Category = new CategoryRepository(db);
            Product = new ProductRepository(db);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
