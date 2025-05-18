using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriEnergyConnect.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Category")]
        public ProductCategory Category { get; set; }

        [Range(0.01, 10000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Range(0.01, 10000)]
        [Display(Name = "Quantity (kg)")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }

        [Required]
        [Display(Name = "Production Date")]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; } = DateTime.Now;

        [Display(Name = "Best Before")]
        [DataType(DataType.Date)]
        public DateTime? BestBefore { get; set; }

        [Display(Name = "Available")]
        public bool IsAvailable { get; set; } = true;

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Navigation properties
        public int FarmerId { get; set; }

        [ForeignKey("FarmerId")]
        public virtual Farmer? Farmer { get; set; }
    }

    public enum ProductCategory
    {
        Vegetables,
        Fruits,
        Dairy,
        Meat,
        Eggs,
        Grains,
        Nuts,
        Honey,
        Other
    }
}