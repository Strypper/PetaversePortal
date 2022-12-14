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

        public ObservableCollection<SpeciesDTO> SpeciesCollection { get; set; } = new ObservableCollection<SpeciesDTO>();

        private readonly ISpeciesService _speciesService;
        private readonly IFileService    _fileService;
        private readonly IBreedService   _breedService;

        public SpeciesViewModel(ISpeciesService speciesService
                               ,IFileService fileService
                               ,IBreedService breedService)
        {
            _speciesService = speciesService;
            _fileService    = fileService;
            _breedService   = breedService;

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
        }

        [RelayCommand]
        public async Task AddBreed(BreedDTO breedDTO)
        {
            if(breedDTO is not null)
            {
                var breed = await _breedService.CreateAsync(breedDTO);
                Species.Breeds.Add(breed);
            }
        }
    }
}
