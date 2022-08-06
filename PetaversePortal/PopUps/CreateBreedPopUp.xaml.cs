using CommunityToolkit.Maui.Views;

namespace PetaversePortal.PopUps;

public partial class CreateBreedPopUp : Popup
{
	public CreateBreedPopUp()
	{
		InitializeComponent();
	}

    void OnYesButtonClicked(object? sender, EventArgs e) => Close(true);

    void OnNoButtonClicked(object? sender, EventArgs e) => Close(false);
}