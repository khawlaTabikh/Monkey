using Monkey.Models;
using System.Net.Http.Json;
namespace Monkey.Services;
using System.Net.Http.Json;

public class MonkeyService
{
    HttpClient httpClient;
    public MonkeyService() 
    {
    httpClient = new HttpClient();
    }
    List<Monkey.Models.Monkey> monkeyList = new ();
    public async Task<List<Monkey.Models.Monkey>> GetMonkeys() 
    {
        if(monkeyList?.Count > 0)
            return monkeyList;
        var url = "https://montemagno.com/monkeys.json";
        var response= await httpClient.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey.Models.Monkey>>();
        }
        return monkeyList;
    }
}
