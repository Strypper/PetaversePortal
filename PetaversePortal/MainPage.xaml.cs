﻿using CommunityToolkit.Maui.Views;
using PetaversePortal.Models;
using PetaversePortal.PopUps;
using PetaversePortal.ViewModels;

namespace PetaversePortal;

public partial class MainPage : ContentPage
{
    private SpeciesViewModel _svm;
    public MainPage(SpeciesViewModel svm)
	{
		InitializeComponent();
        _svm = svm;
		BindingContext = svm;
		Appearing += async (sender, args) => await svm.GetAllBreed();
	}

	private async void AddBreedBtn_Clicked(object sender, EventArgs e)
	{
		var result = await this.ShowPopupAsync(new CreateBreedPopUp());
        if (result is bool boolResult)
        {
            if (boolResult)
            {
                // Yes was tapped
                await _svm.AddBreed();
            }
            else
            {
                // No was tapped
            }
        }
    }
}
