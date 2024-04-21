using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Services.Abstract;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class ProductBarcodeController : ControllerBase
	{

		private readonly IProductBarcodeService _productBarcodeService;
		private readonly ILoggerService _loggerService;
		public ProductBarcodeController(IProductBarcodeService productBarcodeService, ILoggerService loggerService)
		{
			_productBarcodeService = productBarcodeService;
			_loggerService = loggerService;
		}

		[HttpGet]
		[EnableQuery]
		public async Task<IActionResult> GetAllList()
		{
			var result = await _productBarcodeService.GetAllList();
			_loggerService.Log("Tüm liste çekildi.");
			return Ok(result);
		}


		[HttpPost]
		public async Task<IActionResult> CreateToProductBarcode([FromBody] ProductBarcode productBarcode)
		{
			if (productBarcode == null)
			{
				return BadRequest();
			}

			productBarcode.LastModifierDate = DateTime.UtcNow;
			productBarcode.InsertDate = DateTime.UtcNow;

			await _productBarcodeService.Insert(productBarcode);

			_loggerService.Log("Yeni barcode eklendi.");

			return CreatedAtAction(nameof(GetById), new { id = productBarcode.Id }, productBarcode);
		}


		[HttpPut]
		public async Task<IActionResult> UpdateToProductBarcode([FromBody] ProductBarcode productBarcode)
		{
			if (productBarcode == null)
			{
				return BadRequest();
			}

			var item = await _productBarcodeService.GetById(productBarcode.Id);

			item.Barcode = productBarcode.Barcode;
			item.LastModifierDate = DateTime.UtcNow;

			await _productBarcodeService.Update(item);
			_loggerService.Log(productBarcode.Id + "id'li barcode güncellendi.");

			return CreatedAtAction(nameof(GetById), new { id = item.Id }, item);
		}


		[HttpDelete]
		public async Task<IActionResult> RemoveToProductBarcode(int id)
		{
			if (id == null)
			{
				return BadRequest();
			}

			var item = await _productBarcodeService.GetById(id);
			await _productBarcodeService.Delete(item);
			_loggerService.Log(id + "id'li barcode silindi.");

			string result = "{ \"Result\" : \"The transaction was completed successfully.\"}";

			return Ok(result);
		}


		[HttpGet]
		public async Task<IActionResult> GetById(int id)
		{
			var item = await _productBarcodeService.GetById(id);
			if (item == null)
			{
				return NotFound();
			}
			return Ok(item);
		}
	}
}
