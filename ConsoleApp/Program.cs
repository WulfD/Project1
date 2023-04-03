﻿using System.Net.Http.Headers;
using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

await ProcessRepositoriesAsync(client);

static async Task ProcessRepositoriesAsync(HttpClient client)
{
    var json = await client.GetStringAsync("http://localhost:5092/getfile");
    Console.Write(json);
}

while (true)
{
    Console.Write("Befehl wird erwartet: ");
    string command = Console.ReadLine();

    switch (command)
    {
        case "getfile":
            Console.WriteLine("Befehl wird ausgeführt");
            //await ProcessRepositoriesAsync(client);
            break;
        default:
            Console.WriteLine("Unbekannter befehl");
            break;
    }
}