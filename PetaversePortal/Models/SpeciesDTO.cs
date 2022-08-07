using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace PetaversePortal.Models
{
    public partial class SpeciesDTO : BaseDTO
    {
        [ObservableProperty]
        string name;
        [ObservableProperty]
        string color;
        [ObservableProperty]
        string icon;
        [ObservableProperty]
        string description;
        [ObservableProperty]
        string topLovedPetOfTheWeek;

        [ObservableProperty]
        ObservableCollection<BreedDTO> breeds;
    }
}
