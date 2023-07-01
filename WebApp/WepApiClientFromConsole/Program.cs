// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//HttpClientFactory

Console.WriteLine("...");
Console.ReadKey();

using (var client = new HttpClient())
{
    var response = await client.GetAsync("https://localhost:7051/api/emails");

    if (response.IsSuccessStatusCode)
    {
        var content = await response.Content.ReadAsStringAsync();
        Console.WriteLine(content);
    }
    else 
    { 
        Console.WriteLine($"ERROR: StatusCode: {response.StatusCode}"); 
    }
}

Console.ReadKey();