using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using GeekShopping.ProductAPI.Models.Base;

namespace GeekShopping.ProductAPI.Models
{
    [Table("Product")]
    public class Product : BaseIdentity
    {        
        [Column("itemName")]
        [Required]
        [StringLength(30)]
        public string ProductName { get; set; } 

        [Column("description")]
        [StringLength(350)]
        public string Description { get; set; } 

        [Column("price")]
        [Required]
        [Range(0, 10000)]
        public double Price{ get; set; }

        [Column("categoryName")]        
        [StringLength(50)]
        public string CategoryName { get; set; }


        [Column("imageUrl")]
        [StringLength(300)]
        public string ImageUrl { get; set; }
    }
}
