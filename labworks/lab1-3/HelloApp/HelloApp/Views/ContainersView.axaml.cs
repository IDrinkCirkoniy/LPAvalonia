using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using HelloApp.ViewModels;

namespace HelloApp.Views;

public partial class ContainersView : UserControl
{
    public ContainersView()
    {
        InitializeComponent();
        DataContext = new HomeViewModel();
    }
}