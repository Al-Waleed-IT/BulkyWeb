using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public String Title { get; set; }
    
    public String Description { get; set; }
    
    [Required]
    public String ISBN { get; set; }
    
    [Required]
    public String Author { get; set; }
    
    [Required]
    [Display(Name = "List Price")]
    [Range(1,1000)]
    public Decimal ListPrice { get; set; }
    
    [Required]
    [Display(Name = "Price for 1-50")]
    [Range(1,1000)]
    public Decimal Price { get; set; }
    
    [Required]
    [Display(Name = "Price for 50+")]
    [Range(1,1000)]
    public Decimal Price50 { get; set; }
    
    [Required]
    [Display(Name = "Price for 100+")]
    [Range(1,1000)]
    public Decimal Price100 { get; set; }
    
    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }
    
    
    public String? ImageUrl { get; set; }
}