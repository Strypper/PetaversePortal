using PetaversePortal.Constants;
using PetaversePortal.Interfaces;
using PetaversePortal.Models;
using PetaversePortal.Refits;
using Refit;

namespace PetaversePortal.Services
{
    public class BreedService : IBreedService
    {
        private readonly IBreedData _breedData = RestService.For<IBreedData>(AppConstants.PetaverseBaseUrl);
        public BreedService()
        {

        }
        public async Task<BreedDTO> CreateAsync(BreedDTO dto)
        {
            try
            {
                var breedId = await _breedData.CreateAsync(dto);
                return await _breedData.GetByIdAsync(breedId);
            }
            catch (ApiException ex)
            {
                //await new HttpRequestErrorContentDialog() { Exception = ex }.ShowAsync();
                return null;
            }
        }

        public Task<BreedDTO> DeleteAsync(BreedDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<BreedDTO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BreedDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BreedDTO> UpdateAsync(BreedDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
