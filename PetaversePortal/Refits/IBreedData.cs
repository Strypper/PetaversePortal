using PetaversePortal.Models;
using Refit;

namespace PetaversePortal.Refits
{
    public interface IBreedData
    {
        [Get("/Breed/GetAll")]
        Task<ICollection<BreedDTO>> GetAllAsync();

        [Get("/Breed/Get/{id}")]
        Task<BreedDTO> GetByIdAsync(int id);

        [Get("/Breed/GetAllBreedsWithMembers")]
        Task<ICollection<BreedDTO>> GetAllBreedsWithMembersAsync();

        [Post("/Breed/Create")]
        Task<BreedDTO?> CreateAsync(BreedDTO dto);
    }
}
