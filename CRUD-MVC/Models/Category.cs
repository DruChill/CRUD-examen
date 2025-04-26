using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD_MVC.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nombre de categoria")]
        public string Name { get; set; }
        [DisplayName("Nombre de precio")]

        public int Price { get; set; }
    }
}
