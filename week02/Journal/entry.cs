public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;

    public Entry(string date, string prompt, string response, string mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }

    public string ToDisplayString()
    {
        return $"{_date} | Mood: {_mood}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }

    public string ToCsv()
    {
        return $"\"{_date}\",\"{_mood}\",\"{_prompt}\",\"{_response}\"";
    }

    public static Entry FromCsv(string line)
    {
        string[] parts = ParseCsvLine(line);
        return new Entry(parts[0], parts[2], parts[3], parts[1]);
    }

    private static string[] ParseCsvLine(string line)
    {
        var parts = new List<string>();
        bool inQuotes = false;
        string current = "";

        foreach (char c in line)
        {
            if (c == '\"')
            {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                parts.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }
        parts.Add(current);
        return parts.ToArray();
    }
}