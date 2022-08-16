using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetaversePortal.Interfaces;
using PetaversePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetaversePortal.ViewModels
{
    public partial class BreedsViewModel : ViewModelBase
    {
        [ObservableProperty]
        BreedDTO breeds;

        private readonly ISpeciesService _speciesService;
        private readonly IFileService _fileService;
        private readonly IBreedService _breedService;

        public BreedsViewModel(ISpeciesService speciesService,
                               IFileService fileService,
                               IBreedService breedService)
        {
            _speciesService = speciesService;
            _fileService = fileService;
            _breedService = breedService;
        }
    }


}
