public class HttpRequest
{
    public string Method { get; set; } = "GET";
    public string Url { get; set; }
    public Dictionary<string, string> Headers { get; set; } = new();
    public string? Body { get; set; }

    public void Send()
    {
        Console.WriteLine($"Method: {Method}");
        Console.WriteLine($"URL: {Url}");
        Console.WriteLine($"Headers: {string.Join(", ", Headers.Select(kv => kv.Key + ": " + kv.Value))}");
        Console.WriteLine($"Body: {Body ?? "(boş)"}");
    }
}