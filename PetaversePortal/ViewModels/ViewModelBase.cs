using CommunityToolkit.Mvvm.ComponentModel;

namespace PetaversePortal.ViewModels
{
    public partial class ViewModelBase : ObservableRecipient
    {
        [ObservableProperty]
        bool isRunning = true;

        public ViewModelBase()
        {
            IsRunning = true;
        }
    }
}
