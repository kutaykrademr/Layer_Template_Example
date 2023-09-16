using Business.Abstract;
using DataAccess_Layer.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDataAccessLayer _categoryDataAccessLayer;

        public CategoryManager(ICategoryDataAccessLayer categoryDal)
        {
            _categoryDataAccessLayer = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDataAccessLayer.GetList();
        }
    }
}
