namespace DevBurguer.Models
{
    public class Snacks : UserActivity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public required string ImageUrl { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
