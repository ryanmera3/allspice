using System.ComponentModel.DataAnnotations;

namespace allspice.Models
{
  public class Recipe
    {
        public int Id { get; set; }
        [Required]
        public string title { get; set; }
        public string subtitle { get; set; }
        public string category { get; set; }
        public string creatorId {get; set;}
    }
}