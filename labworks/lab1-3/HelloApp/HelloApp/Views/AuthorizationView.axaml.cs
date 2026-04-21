using Avalonia.Controls;

namespace HelloApp.Views;

public partial class AuthorizationView : UserControl
{
    public AuthorizationView()
    {
        InitializeComponent();
        DataContext = AuthorizationViewModel();
    }
}