using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace FuelSitesUI.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    bool isBusy;

    [ObservableProperty]
    string title;

    
}   