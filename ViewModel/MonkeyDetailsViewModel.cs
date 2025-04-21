using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkey.ViewModel;
[QueryProperty(nameof(Monkey),"Monkey")]

public partial class MonkeyDetailsViewModel:BaseViewModel
{
    public MonkeyDetailsViewModel() 
    {
    
    }
    [ObservableProperty]
    Monkey.Models.Monkey monkey;
  
  
}
