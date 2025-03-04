using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Models.Base
{
    public class BaseIdentity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
