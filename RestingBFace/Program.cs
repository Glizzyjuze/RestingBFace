using System.Text.Json;
using RestSharp;
using System.IO;
using System.Runtime.InteropServices;

RestClient client = new("https://swapi.py4e.com/api/");

Console.WriteLine("Which character?");
string charName = Console.ReadLine();
RestRequest request = new($"people/{charName}/");

RestResponse response = client.GetAsync(request).Result;

if (response.StatusCode == System.Net.HttpStatusCode.OK)
{
    Character c = JsonSerializer.Deserialize<Character>(response.Content);
    Console.WriteLine(c.Height);
}
else
{
    Console.WriteLine("Error");
}

//Console.WriteLine(response.Content);
//File.WriteAllText("StarWars.json", response.Content);

Console.ReadLine();