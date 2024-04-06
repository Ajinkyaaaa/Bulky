using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key] // Data annotation for primary key [] when we use ef core
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        // Make it absolute for ef core
        public  string Name { get; set; }
        [DisplayName("Order Name")]
        public int Displayorder { get; set; }
    }
}
