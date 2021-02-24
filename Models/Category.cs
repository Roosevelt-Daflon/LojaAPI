using System.ComponentModel.DataAnnotations;

namespace LojaAPI.Models
{
    public class Category
    {
        [Key]
        public int id{get; set;}

        [Required(ErrorMessage = "Este campo � obrigat�rio")]
		[MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
		[MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
		public string title {get; set;}
    }
}