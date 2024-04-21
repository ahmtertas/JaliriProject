using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Abstract;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class ProductSizeController : ControllerBase
	{

		private readonly IProductSizeService _productSizeService;
		private readonly ILoggerService _loggerService;
		public ProductSizeController(IProductSizeService productSizeService, ILoggerService loggerService)
		{
			_productSizeService = productSizeService;
			_loggerService = loggerService;
		}

		[HttpGet]
		[EnableQuery]
		public async Task<IActionResult> GetAllList()
		{
			var result = await _productSizeService.GetAllList();
			_loggerService.Log("Tüm liste çekildi.");
			return Ok(result);
		}


		[HttpPost]
		public async Task<IActionResult> CreateToProductSize(ProductSize productSize)
		{
			if (productSize == null)
			{
				return BadRequest();
			}

			productSize.LastModifierDate = DateTime.UtcNow;
			productSize.InsertDate = DateTime.UtcNow;

			await _productSizeService.Insert(productSize);

			_loggerService.Log("Yeni beden/boyut eklendi.");

			return CreatedAtAction(nameof(GetById), new { id = productSize.Id }, productSize);
		}


		[HttpPut]
		public async Task<IActionResult> UpdateToProductSize([FromBody] ProductSize productSize)
		{

			if (productSize == null)
			{
				return BadRequest();
			}

			var item = await _productSizeService.GetById(productSize.Id);

			item.LastModifierDate = DateTime.UtcNow;
			item.Size = productSize.Size;
			await _productSizeService.Update(item);

			_loggerService.Log(item.Id + "id'li beden/boyut güncellendi.");

			return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
		}


		[HttpDelete]
		public async Task<IActionResult> RemoveToProductSize(int id)
		{
			if (id == null)
			{
				return BadRequest();
			}

			var item = await _productSizeService.GetById(id);
			await _productSizeService.Delete(item);
			_loggerService.Log(id + "id'li beden/boyut silindi.");

			string result = "{ \"Result\" : \"The transaction was completed successfully.\"}";

			return Ok(result);
		}


		[HttpGet]
		public async Task<IActionResult> GetById(int id)
		{
			var item = await _productSizeService.GetById(id);
			if (item == null)
			{
				return NotFound();
			}
			return Ok(item);
		}
	}
}
