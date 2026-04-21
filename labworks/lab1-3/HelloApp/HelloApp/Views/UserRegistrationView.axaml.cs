using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HelloApp.ViewModels;

namespace HelloApp.Views;

public partial class UserRegistrationView : UserControl
{
    public UserRegistrationView()
    {
        InitializeComponent();
        DataContext = new UserRegistrationViewModel();
    }
}