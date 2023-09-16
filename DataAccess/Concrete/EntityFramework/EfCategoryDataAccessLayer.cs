using Core_Layer.DataAccess.EntityFramework;
using DataAccess_Layer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Concrete.EntityFramework
{
    internal class EfCategoryDataAccessLayer : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDataAccessLayer
    {

    }
}
