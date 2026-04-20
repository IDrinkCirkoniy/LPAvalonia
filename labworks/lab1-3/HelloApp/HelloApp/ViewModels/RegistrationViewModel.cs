using Avalonia.Controls.Primitives;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.ViewModels;

public partial class RegistrationViewModel : ViewModelBase
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Age))]
    private DateTime selectedDate;
    private bool wasBirthday;

    public bool wasBirthDay => DateTime.Now.Month < selectedDate.Month && DateTime.Now.Day < selectedDate.Day;
    public int Age => wasBirthDay ? DateTime.Now.Year - selectedDate.Year : (DateTime.Now.Year - selectedDate.Year) - 1;

    public List<string> ["Russian", "English"];
};
