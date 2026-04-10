try
{
    var lines = File.ReadLines("xyz.csv").Skip(1).ToList();
    int numLines = lines.Count;
    int numWords = 0;
    foreach (var line in lines)
    {
        var words = line.Split(',');
        numWords += words.Length;
    }
    string output = $"Number of words: {numWords}, Number of lines: {numLines}";
    File.WriteAllText("data.txt", output);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"File Not found: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"IO Exception: {ex.Message} ");
}
