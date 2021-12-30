using ILearningApp.Application.Interfaces.Repository;
using ILearningApp.Domain.Entities;
using ILearningApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILearningApp.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext DbContext) : base(DbContext)
        {

        }
    }
}
