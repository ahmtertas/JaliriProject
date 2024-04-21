using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Abstract;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class ProductBrandController : ControllerBase
	{

		private readonly IProductBrandService _productBrandService;
		private readonly ILoggerService _loggerService;
		public ProductBrandController(IProductBrandService productBrandService, ILoggerService loggerService)
		{
			_productBrandService = productBrandService;
			_loggerService = loggerService;
		}

		[HttpGet]
		[EnableQuery]
		public async Task<IActionResult> GetAllList()
		{
			var result = await _productBrandService.GetAllList();
			_loggerService.Log("Tüm marka listesi çekildi.");
			return Ok(result);
		}


		[HttpPost]
		public async Task<IActionResult> CreateToProductBrand(ProductBrand productBrand)
		{
			if (productBrand == null)
			{
				return BadRequest();
			}

			productBrand.LastModifierDate = DateTime.UtcNow;
			productBrand.InsertDate = DateTime.UtcNow;

			await _productBrandService.Insert(productBrand);
			_loggerService.Log("Yeni marka eklendi.");

			return CreatedAtAction(nameof(GetById), new { id = productBrand.Id }, productBrand);
		}


		[HttpPut]
		public async Task<IActionResult> UpdateToProductBrand(ProductBrand productBrand)
		{
			if (productBrand == null)
			{
				return BadRequest();
			}

			var item = await _productBrandService.GetById(productBrand.Id);

			item.LastModifierDate = DateTime.UtcNow;
			item.BrandName = productBrand.BrandName;
			item.BrandCode = productBrand.BrandCode;

			await _productBrandService.Update(item);

			_loggerService.Log(item.Id + "id'li marka güncellendi.");

			return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
		}


		[HttpDelete]
		public async Task<IActionResult> RemoveToProductBrand(int id)
		{
			if (id == null)
			{
				return BadRequest();
			}

			var item = await _productBrandService.GetById(id);
			await _productBrandService.Delete(item);
			_loggerService.Log(id + "id'li marka silindi.");

			string result = "{ \"Result\" : \"The transaction was completed successfully.\"}";

			return Ok(result);
		}


		[HttpGet]
		public async Task<IActionResult> GetById(int id)
		{
			var item = await _productBrandService.GetById(id);
			if (item == null)
			{
				return NotFound();
			}
			return Ok(item);
		}
	}
}
