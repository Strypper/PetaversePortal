using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetaversePortal.Interfaces;
using PetaversePortal.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PetaversePortal.ViewModels
{
    public partial class SpeciesViewModel : ViewModelBase
    {
        [ObservableProperty]
        SpeciesDTO species;

        public ObservableCollection<SpeciesDTO> SpeciesCollection { get; set; } = new ObservableCollection<SpeciesDTO>();

        private readonly ISpeciesService _speciesService;
        private readonly IBreedService   _breedService;

        public SpeciesViewModel(ISpeciesService speciesService
                               ,IBreedService breedService)
        {
            _speciesService = speciesService;
            _breedService = breedService;

            GetAllBreed();
        }

        [RelayCommand]
        public async Task GetAllBreed()
        {
            IsRunning = true;
            var species = await _speciesService.GetAllAsync();
            species.ToList().ForEach(sp => SpeciesCollection.Add(sp));
            Species = SpeciesCollection.FirstOrDefault();
            IsRunning = false;
            //species.ToList().ForEach(breed => SpeciesCollection.Add(breed));
        }

        public async Task AddBreed()
        {
        }
    }
}
