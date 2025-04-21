global using CommunityToolkit.Mvvm.Input;
global using Monkey.Models;
global using Monkey.ViewModel;
global using System.Collections.ObjectModel;
global using System.ComponentModel;
global using System.Diagnostics;
global using System.Text.Json;
global using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;





namespace Monkey.ViewModel;
//[INotifyPropertyChanged]

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {

    }
 
    partial void OnIsBusyChanged(bool oldValue)
    {
        OnPropertyChanged(nameof(IsNotBusy));
            }
    [ObservableProperty]
    bool isBusy;

    [ObservableProperty]
    string title;
   
    public bool IsNotBusy => !IsBusy;

    public string Title1 { get => title; set => title = value; }
}
