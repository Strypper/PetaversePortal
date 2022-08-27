using PetaversePortal.Constants;
using PetaversePortal.Interfaces;
using PetaversePortal.Models;
using PetaversePortal.Refits;
using Refit;

namespace PetaversePortal.Services
{
    public class SpeciesService : ISpeciesService
    {
        private readonly ISpeciesData _speciesData = RestService.For<ISpeciesData>(AppConstants.PetaverseBaseUrl);
        public SpeciesService()
        {

        }

        public async Task<ICollection<SpeciesDTO>> GetAllAsync()
        {
            try
            {
                return await _speciesData.GetAllAsync();
            }
            catch (ApiException ex)
            {
                //await new HttpRequestErrorContentDialog() { Exception = ex }.ShowAsync();
                return null;
            }
        }

        public async Task<SpeciesDTO> GetByIdAsync(int id)
        {
            try
            {
                return await _speciesData.GetByIdAsync(id);
            }
            catch (ApiException ex)
            {
                //await new HttpRequestErrorContentDialog() { Exception = ex }.ShowAsync();
                return null;
            }
        }

        public async Task<SpeciesDTO> CreateAsync(SpeciesDTO dto)
        {
            try
            {
                var speciesId = await _speciesData.CreateAsync(dto);
                return await _speciesData.GetByIdAsync(speciesId);
            }
            catch (ApiException ex)
            {
                //await new HttpRequestErrorContentDialog() { Exception = ex }.ShowAsync();
                return null;
            }
        }

        public Task<SpeciesDTO> DeleteAsync(SpeciesDTO dto)
        {
            throw new NotImplementedException();
        }

        public Task<SpeciesDTO> UpdateAsync(SpeciesDTO dto)
        {
            throw new NotImplementedException();
        }
    }
}
