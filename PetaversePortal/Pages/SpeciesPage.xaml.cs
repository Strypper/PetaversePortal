using CommunityToolkit.Maui.Views;
using PetaversePortal.Models;
using PetaversePortal.PopUps;
using PetaversePortal.ViewModels;

namespace PetaversePortal.Pages;

public partial class SpeciesPage : ContentPage
{
    private SpeciesViewModel _svm;

    public SpeciesPage(SpeciesViewModel svm)
    {
        InitializeComponent();
        _svm = svm;
        BindingContext = svm;

    }

    private async void AddBreedBtn_Clicked(object sender, EventArgs e)
    {
        var result = await this.ShowPopupAsync(new CreateBreedPopUp(_svm.Species.Id));
        if (result != null)
        {
        }
        else
        {
        }
    }
}