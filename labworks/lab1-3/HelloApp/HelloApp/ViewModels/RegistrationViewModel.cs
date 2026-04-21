using Avalonia.Controls.Primitives;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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

    public bool wasBirthDay => DateTime.Now.Month > selectedDate.Month && DateTime.Now.Day > selectedDate.Day;
    public int Age => wasBirthDay ? DateTime.Now.Year - selectedDate.Year : (DateTime.Now.Year - selectedDate.Year) - 1;

    [ObservableProperty]
    private ObservableCollection<string> language = ["Russian", "English"];

    [ObservableProperty]
    private string selectedLanguage = "Russian";

    [ObservableProperty]
    private double opacityValue = 0;

    [ObservableProperty]
    private UserCreditionals userCreditionals = new();
};

public partial class UserCreditionals : ObservableValidator
{
    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Логин обязателен")]
    [RegularExpression(@"^([a-zA-Z0-9_]+){3,20}$", ErrorMessage = "Логин должен состоять из латиницы цифр и нижнего подчёркивания")]
    private string login = "";

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Пароль обязателен")]
    [MinLength(8, ErrorMessage = "Минимум 8 символов")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$]).*$", ErrorMessage = "Пароль должен состоять из латиницы, цифр и спецсимвола")]
    private string password = "";

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Required(ErrorMessage = "Пароль обязателен")]
    [property:Compare(nameof(Password))]
    private string repeatedPassword = "";

    [ObservableProperty]
    [NotifyDataErrorInfo]
    [Phone(ErrorMessage = "Неверный формат телефонного номера")]
    private string number = "";

}