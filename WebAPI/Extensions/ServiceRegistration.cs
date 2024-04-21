using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Services.Abstract;
using Services.Concrete;

namespace WebAPI.Extensions
{
	public static class ServiceRegistration
	{
		public static void AddApplicationServices(this IServiceCollection service)
		{
			service.AddTransient<IProductService, ProductManager>();
			service.AddTransient<IProductDal, ProductDal>();

			service.AddTransient<IProductColorService, ProductColorManager>();
			service.AddTransient<IProductColorDal, ProductColorDal>();

			service.AddTransient<IProductSizeService, ProductSizeManager>();
			service.AddTransient<IProductSizeDal, ProductSizeDal>();

			service.AddTransient<IProductBarcodeService, ProductBarcodeManager>();
			service.AddTransient<IProductBarcodeDal, ProductBarcodeDal>();

			service.AddTransient<IProductBrandService, ProductBrandManager>();
			service.AddTransient<IProductBrandDal, ProductBrandDal>();

			service.AddScoped<ILoggerService, LoggerManager>();
		}
	}
}
