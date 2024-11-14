namespace Question3;

public class AsyncService
{
    public async Task<string> FetchDataFromAPI1()
    {
        // Mimic
        await Task.Delay(1000);
        return "Data from API 1";
    }

    public async Task<string> FetchDataFromAPI2()
    {
        await Task.Delay(2000);
        return "Data from API 2";
    }

    public async Task FetchAllData()
    {
        var result = await Task.WhenAll(FetchDataFromAPI1(), FetchDataFromAPI2());
        Console.WriteLine($"Result: {result[0]}");
    }

    public async Task FetchAnyData()
    {
        var result = await Task.WhenAny(FetchDataFromAPI1(), FetchDataFromAPI2());
        Console.WriteLine($"Result: {result.Result}");
    }
}