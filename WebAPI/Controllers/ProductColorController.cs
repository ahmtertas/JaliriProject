using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Abstract;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class ProductColorController : ControllerBase
	{

		private readonly IProductColorService _productColorService;
		private readonly ILoggerService _loggerService;
		public ProductColorController(IProductColorService productColorService, ILoggerService loggerService)
		{
			_productColorService = productColorService;
			_loggerService = loggerService;
		}

		[HttpGet]
		[EnableQuery]
		public async Task<IActionResult> GetAllList()
		{
			var result = await _productColorService.GetAllList();
			_loggerService.Log("Tüm renk liste çekildi.");
			return Ok(result);
		}


		[HttpPost]
		public async Task<IActionResult> CreateToProductColor([FromBody] ProductColor productColor)
		{
			if (productColor == null)
			{
				return BadRequest();
			}

			productColor.LastModifierDate = DateTime.UtcNow;
			productColor.InsertDate = DateTime.UtcNow;

			await _productColorService.Insert(productColor);
			_loggerService.Log("Yeni renk eklendi.");

			return CreatedAtAction(nameof(GetById), new { id = productColor.Id }, productColor);
		}


		[HttpPut]
		public async Task<IActionResult> UpdateToProductColor([FromBody] ProductColor productColor)
		{
			if (productColor == null)
			{
				return BadRequest();
			}

			var item = await _productColorService.GetById(productColor.Id);

			item.LastModifierDate = DateTime.UtcNow;
			item.ColorName = productColor.ColorName;
			item.ColorCode = productColor.ColorCode;

			await _productColorService.Update(item);

			_loggerService.Log(productColor.Id + "id'li renk güncellendi.");

			return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
		}


		[HttpDelete]
		public async Task<IActionResult> RemoveToProductColor(int id)
		{
			if (id == null)
			{
				return BadRequest();
			}

			var item = await _productColorService.GetById(id);
			await _productColorService.Delete(item);
			_loggerService.Log(id + "id'li renk silindi.");

			string result = "{ \"Result\" : \"The transaction was completed successfully.\"}";

			return Ok(result);
		}


		[HttpGet]
		public async Task<IActionResult> GetById(int id)
		{
			var item = await _productColorService.GetById(id);
			if (item == null)
			{
				return NotFound();
			}
			return Ok(item);
		}
	}
}
