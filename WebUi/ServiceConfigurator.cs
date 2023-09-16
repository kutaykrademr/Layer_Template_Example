using Business.Abstract;
using Business.Concrete;
using DataAccess_Layer.Abstract;
using DataAccess_Layer.Concrete.EntityFramework;

namespace WebUi
{
    public class ServiceConfigurator
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IProductDataAccessLayer, EfProductDataAccessLayer>();
        }
    }
}
