using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monkey.Services;
using CommunityToolkit.Mvvm.Input;
using Monkey.View;
using Monkey.Models;
namespace Monkey.ViewModel;
public partial class MonkeysViewModel:BaseViewModel
{
    MonkeyService monkeyService;
    public ObservableCollection<Monkey.Models.Monkey> Monkeys { get; } = new();
   

    public MonkeysViewModel(MonkeyService monkeyService) {
        Title = "Monkey Finder";
        this.monkeyService = monkeyService;
       


    }
    [RelayCommand]

    async Task GoToDetailsAsync(Monkey.Models.Monkey monkey) 
    {
        if (monkey == null)
            return;
        await Shell.Current.GoToAsync(nameof(DetailsPage),true,new Dictionary<string, object> {

            {"Monkey",monkey }
        
        });

    }
    [RelayCommand]
    async Task GetMonkeysAsync() 
    {
        if (IsBusy)
      { return; }
        try
        {
            IsBusy = true;
            var monkeys = await monkeyService.GetMonkeys();

            if(Monkeys.Count!=0)
            {
                Monkeys.Clear();
            }
            foreach (var monkey in monkeys) 
            { 
             Monkeys.Add(monkey);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!",$"Unable to get monkeys:{ex.Message}","OK");
        }
        finally
        { 
            IsBusy = false; 
        }
    }
}
