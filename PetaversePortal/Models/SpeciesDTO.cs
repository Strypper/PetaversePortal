namespace PetaversePortal.Models
{
    public class SpeciesDTO : BaseDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string TopLovedPetOfTheWeek { get; set; } = string.Empty;

        public virtual ICollection<BreedDTO> Breeds { get; set; } = Array.Empty<BreedDTO>();
    }
}
