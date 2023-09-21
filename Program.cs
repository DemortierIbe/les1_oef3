Dictionary<String, int> lokalen = new Dictionary<string, int> {
    { "KWE.P.0.002", 200 },
    { "KWE.P.1.103", 20 },
    { "KWE.A.1.103", 60 },
    { "KWE.A.1.104", 30 },
    { "KWE.A.1.302", 64 },
    { "KWE.A.1.301", 64 }
};

Console.WriteLine("Group size:");
int size = int.Parse(Console.ReadLine());

var safeClassrooms = GetCoronaClassRooms(lokalen, size);
Print(safeClassrooms);

void Print(Dictionary<string, int> lokalen)
{
    foreach (KeyValuePair<string, int> lokaal in lokalen)
    {
        Console.WriteLine($"{lokaal.Key}");
    }
}

Dictionary<string, int> GetCoronaClassRooms(Dictionary<string, int> lokalen, int size)
{
    Dictionary<string, int> results = new Dictionary<string, int>();

    foreach (KeyValuePair<string, int> lokaal in lokalen)
    {
        if (lokaal.Value >= 2 * size)
        {
            results.Add(lokaal.Key, lokaal.Value);
        }
    }

    return results;
}
