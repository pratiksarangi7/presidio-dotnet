static async Task<string> WaitForWork(int time, string workName)
{
    await Task.Delay(time);
    return $"Finished {workName}.";
}

try
{
    var task1 = WaitForWork(2000, "Database");
    var task2 = WaitForWork(2000, "API");
    var task3 = WaitForWork(2000, "Cloud");

    var results = await Task.WhenAll(task1, task2, task3);
    foreach (var item in results)
    {
        Console.WriteLine(item);
    }
}
catch (OperationCanceledException)
{

    Console.WriteLine("Operation was cancelled");
}
catch (Exception e)
{
    Console.WriteLine($"An error Occurred!{e.Message}");
}
