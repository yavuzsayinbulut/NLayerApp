using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class Product:BaseEntity
    {
     /*   public Product(string name)
        {
            name = name ?? throw new ArgumentNullException(nameof(Name));
        }
     */
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        // Navigation Property 
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }





    }
}



/*
 
 [Key]
  public int CategoryId { get; set; }

 [ForeignKey("Category_Id")]
 public Category Category { get; set; }

 */