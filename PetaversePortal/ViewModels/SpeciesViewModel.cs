using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PetaversePortal.Interfaces;
using PetaversePortal.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using static AndroidX.Activity.Result.Contract.ActivityResultContracts;

namespace PetaversePortal.ViewModels
{
    public partial class SpeciesViewModel : ViewModelBase
    {
        [ObservableProperty]
        SpeciesDTO species;

        public ObservableCollection<SpeciesDTO> SpeciesCollection { get; set; } = new ObservableCollection<SpeciesDTO>();

        public ICommand TakePictureCommand { get; set; }
        public ICommand PickPictureCommand { get; set; }

        private readonly ISpeciesService _speciesService;
        private readonly IBreedService   _breedService;

        public SpeciesViewModel(ISpeciesService speciesService
                               ,IBreedService breedService)
        {
            _speciesService = speciesService;
            _breedService   = breedService;
            TakePictureCommand = new Command(() => TakePicture());
            PickPictureCommand = new Command(() => PickPicture());
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

        public async Task TakePicture()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

                if (photo != null)
                {
                    // save the file into local storage
                    string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                    using Stream sourceStream = await photo.OpenReadAsync();
                    using FileStream localFileStream = File.OpenWrite(localFilePath);

                    await sourceStream.CopyToAsync(localFileStream);
                }
            }
        }

        public async Task PickPicture()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.PickPhotoAsync(new MediaPickerOptions());
                if (photo != null)
                {
                    // save the file into local storage
                    string localFilePath = Path.Combine(FileSystem.CacheDirectory, photo.FileName);

                    using Stream sourceStream = await photo.OpenReadAsync();
                    using FileStream localFileStream = File.OpenWrite(localFilePath);

                    await sourceStream.CopyToAsync(localFileStream);
                }
            }
        }

    }
}
