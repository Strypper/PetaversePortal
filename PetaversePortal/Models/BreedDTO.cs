namespace PetaversePortal.Models
{
    public class BreedDTO : BaseDTO
    {
        public string BreedName { get; set; } = string.Empty;
        public string BreedDescription { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public double MinimunSize { get; set; }
        public double MaximumSize { get; set; }
        public double MinimumWeight { get; set; }
        public double MaximumWeight { get; set; }
        public int MinimumLifeSpan { get; set; }
        public int MaximumLifeSpan { get; set; }
        public CoatType Coat { get; set; }
        public string Color { get; set; } = string.Empty;
    }
    public enum CoatType
    {
        Medium,
        Heavy,
        Light
    }
}
