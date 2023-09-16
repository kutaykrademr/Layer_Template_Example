using Core_Layer.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.ViewModels
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; internal set; }
    }
}
