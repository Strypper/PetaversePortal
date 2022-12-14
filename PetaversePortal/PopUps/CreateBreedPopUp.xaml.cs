using CommunityToolkit.Maui.Views;
using PetaversePortal.Models;

namespace PetaversePortal.PopUps;

public partial class CreateBreedPopUp : Popup
{
    public BreedDTO BreedDTO { get; set; } = new BreedDTO();

    public CreateBreedPopUp(int speciesId)
    {
        InitializeComponent();
        BreedDTO.SpeciesId = speciesId;
    }

    void OnYesButtonClicked(object? sender, EventArgs e) => Close(BreedDTO);

    void OnNoButtonClicked(object? sender, EventArgs e) => Close(null);
}