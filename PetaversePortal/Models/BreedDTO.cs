using CommunityToolkit.Mvvm.ComponentModel;

namespace PetaversePortal.Models
{
    public partial class BreedDTO : BaseDTO
    {
        [ObservableProperty]
        string breedName;
        [ObservableProperty]
        string breedDescription;
        [ObservableProperty]
        string imageUrl;
        [ObservableProperty]
        double minimunSize;
        [ObservableProperty]
        double maximumSize;
        [ObservableProperty]
        double minimumWeight;
        [ObservableProperty]
        double maximumWeight;
        [ObservableProperty]
        int minimumLifeSpan;
        [ObservableProperty]
        int maximumLifeSpan;
        [ObservableProperty]
        string color;

        public CoatType Coat { get; set; }
    }
    public enum CoatType
    {
        Medium,
        Heavy,
        Light
    }
}
