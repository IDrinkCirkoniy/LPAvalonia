using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelloApp.Services;
using HelloApp.ViewModels;
using HelloApp.Services;

namespace HelloApp.ViewModels
{
    public partial class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentPage => navService.CurrentPage;

        public static NavigationService navService = new();

        public MainViewModel()
        {
            navService.NavigateTo(new RegistrationViewModel());
        }

        [RelayCommand]
        private void EnterAuthorization()
        {
            navService.NavigateTo(new AuthorizationViewModel());
            OnPropertyChanged(nameof(CurrentPage));
        }

        [RelayCommand]
        private void EnterLogin()
        {
            navService.NavigateTo(new RegistrationViewModel());
            OnPropertyChanged(nameof(CurrentPage));
        }
    }
}