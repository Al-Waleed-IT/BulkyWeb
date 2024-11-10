using System.ComponentModel.DataAnnotations;

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
}