using Core_Layer.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess_Layer.Abstract
{
    public interface ICategoryDataAccessLayer : IEntityRepository<Category>
    {
      
    }
}
