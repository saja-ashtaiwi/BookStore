using System.ComponentModel.DataAnnotations;

namespace BookStore.BLL
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
