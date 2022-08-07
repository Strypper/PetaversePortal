using PetaversePortal.Models;
using Refit;

namespace PetaversePortal.Refits
{
    public interface ISpeciesData
    {
        [Get("/Species/GetAll")]
        Task<ICollection<SpeciesDTO>> GetAllAsync();

        [Get("/Species/Get/{id}")]
        Task<SpeciesDTO> GetByIdAsync(int id);

        [Get("/Species/GetAllSpeciessWithMembers")]
        Task<ICollection<SpeciesDTO>> GetAllSpeciessWithMembersAsync();

        [Post("/Species/Create")]
        Task<SpeciesDTO?> CreateAsync(SpeciesDTO dto);
    }
}
