using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HelloApp.ViewModels;

public partial class HomeViewModel : ViewModelBase
{
    [ObservableProperty]
    private string text = "Hello Avalonia!";

    [RelayCommand]
    public void ChangeText()
    {
        Text = "Привет Авалония!";
    }
}
