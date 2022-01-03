using System.ComponentModel.DataAnnotations;

namespace allspice.Models
{
  public class Step
    {
        [Required]
        public int order { get; set; }
        public string body { get; set; }
        public int recipeId { get; set; }

    }
}