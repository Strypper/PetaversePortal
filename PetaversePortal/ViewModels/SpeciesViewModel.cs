using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetaversePortal.Interfaces;
using PetaversePortal.Models;
using System.Collections.ObjectModel;

namespace PetaversePortal.ViewModels
{
    public partial class SpeciesViewModel : ViewModelBase
    {
        [ObservableProperty]
        SpeciesDTO species;

        public ObservableCollection<BreedDTO> BreedCollection { get; set; } = new ObservableCollection<BreedDTO>();

        private readonly ISpeciesService _speciesService;
        private readonly IBreedService _breedService;

        public SpeciesViewModel(ISpeciesService speciesService
                               ,IBreedService breedService)
        {
            _speciesService = speciesService;
            _breedService   = breedService;
        }

        [RelayCommand]
        public async Task GetAllBreed()
        {
            IsRunning = true;
            var species = await _speciesService.GetAllAsync();
            var catSpecies = species.FirstOrDefault();
            catSpecies.Breeds.ToList().ForEach(cat => BreedCollection.Add(cat));
            IsRunning = false;
            //species.ToList().ForEach(breed => SpeciesCollection.Add(breed));
        }
        
        public async Task AddBreed()
        {
        }
    }
}
