using PetaversePortal.Models;

namespace PetaversePortal.ContentViews;

public partial class BreedCardContentView : ContentView
{
	public BreedCardContentView()
	{
		InitializeComponent();
	}

    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        BindingContext = (BreedDTO)BindingContext;
    }
}