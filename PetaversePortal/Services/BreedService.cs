using PetaversePortal.Interfaces;
using PetaversePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaversePortal.Services
{
    public class BreedService : IBreedService
    {
        public Task<BreedDTO> CreateAsync(BreedDTO dto)
        {
            throw new NotImplementedException();
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
