using Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
	public class BaseEntity : IEntity
	{
		[Key]
		public int Id { get; set; }
		public DateTime InsertDate { get; set; }
		public DateTime LastModifierDate { get; set; }
	}
}
