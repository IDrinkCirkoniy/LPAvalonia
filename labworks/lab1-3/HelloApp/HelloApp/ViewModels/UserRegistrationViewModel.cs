using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.ViewModels;

public partial class UserRegistrationViewModel : ObservableObject
{
    [ObservableProperty]
    private UserCreditionals credential = new();
}
