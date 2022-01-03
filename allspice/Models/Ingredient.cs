using System.ComponentModel.DataAnnotations;

namespace allspice.Models
{
  public class Ingredient
    {
        [Required]
        public string name { get; set; }
        public string quantity { get; set; }
        public int recipeId { get; set; }

    }
}