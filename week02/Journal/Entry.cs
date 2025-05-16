// This represents a single entry for my journal
class Entry
{
    public string _prompt { get; }
    public string _response { get; }
    public string _date { get; }

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
    }
}

// class Entry
// {
//     public string Prompt { get; }
//     public string Response { get; }
//     public string Date { get; }

//     public Entry(string prompt, string response, string date)
//     {
//         Prompt = _prompt;
//         Response = _response;
//         Date = _date;
//     }

//     public void Display()
//     {
//         Console.WriteLine($"\nDate: {Date}");
//         Console.WriteLine($"Prompt: {Prompt}");
//         Console.WriteLine($"Response: {Response}");
//     }
// }