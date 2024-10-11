using System.Net.Http.Json;
using System.Text.Json;
using MonkeyFinder.Models;

namespace MonkeyFinder.Services;

public static class MonkeyService
{
    public static async Task<List<Monkey>> getMonkeys()
    {
        List<Monkey> monkeyList = new List<Monkey>();
        using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
        using var reader = new StreamReader(stream);
        var contents = await reader.ReadToEndAsync();
        monkeyList = JsonSerializer.Deserialize<List<Monkey>>(contents);
        return monkeyList;
    }
}
