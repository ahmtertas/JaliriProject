using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Abstract;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class ProductController : ControllerBase
	{

		private readonly IProductService _productService;
		private readonly ILoggerService _loggerService;
		public ProductController(IProductService productService, ILoggerService loggerService)
		{
			_productService = productService;
			_loggerService = loggerService;
		}

		[HttpGet]
		[EnableQuery]
		public async Task<IActionResult> Product()
		{
			var result = await _productService.GetAllList();
			_loggerService.Log("Tüm liste çekildi.");
			return Ok(result);
		}


		[HttpGet]
		public async Task<IActionResult> ProductWithNestedList()
		{
			var result = await _productService.GetWithNestedList();
			_loggerService.Log("Tüm liste çekildi.");
			return Ok(result);
		}

		[HttpGet]
		[EnableQuery]
		public async Task<IActionResult> ProductWithOData()
		{
			var result = await _productService.GetAllWithOData();
			_loggerService.Log("Tüm ürün listesi çekildi.");
			return Ok(result);
		}


		[HttpPost]
		public async Task<IActionResult> Product(Product product)
		{
			if (product == null)
			{
				return BadRequest();
			}

			product.LastModifierDate = DateTime.UtcNow;
			product.InsertDate = DateTime.UtcNow;

			await _productService.Insert(product);

			_loggerService.Log("Yeni ürün eklendi.");

			return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
		}


		[HttpPut]
		public async Task<IActionResult> Product(int id, [FromBody] Product product)
		{
			var item = await _productService.GetById(id);
			if (item == null)
			{
				return BadRequest("Product object is null");
			}

			if (!ModelState.IsValid)
			{
				return BadRequest("Invalid model object");
			}

			if (product == null)
			{
				return BadRequest();
			}

			item.Data.LastModifierDate = DateTime.UtcNow;
			item.Data.UnitPrice = product.UnitPrice;
			item.Data.ProductName = product.ProductName;
			item.Data.ProductDescription = product.ProductDescription;
			item.Data.QuantityPerUnit = product.QuantityPerUnit;
			item.Data.UnitsInStock = product.UnitsInStock;
			await _productService.Update(item.Data);

			_loggerService.Log(product.Id + "id'li ürün güncellendi.");

			return CreatedAtAction(nameof(GetById), new { id = item.Data.Id }, item.Data);
		}


		[HttpDelete]
		public async Task<IActionResult> Product(int id)
		{
			if (id == null)
			{
				return BadRequest();
			}

			var item = await _productService.GetById(id);
			var result = await _productService.Delete(item.Data);
			_loggerService.Log(id + "id'li ürün silindi.");

			return Ok(result);
		}


		[HttpGet]
		public async Task<IActionResult> GetById(int id)
		{
			var item = await _productService.GetById(id);
			if (item == null)
			{
				return NotFound();
			}

			return Ok(item);
		}

	}
}
