using PetaversePortal.Constants;
using PetaversePortal.Interfaces;
using PetaversePortal.Models;
using PetaversePortal.Refits;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaversePortal.Services
{
    public class BreedService : IBreedService
    {
        private readonly IBreedData _breedsData = RestService.For<IBreedData>(AppConstants.PetaverseBaseUrl);

        public BreedService()
        { }

        public async Task<BreedDTO> CreateAsync(BreedDTO dto)
        {
            try
            {
                return await _breedsData.CreateAsync(dto);
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
