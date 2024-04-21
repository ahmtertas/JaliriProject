using Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
	public class Gender : IEntity
	{
		[Key]
		public int Id { get; set; }
		public String Genders { get; set; }
	}
}
