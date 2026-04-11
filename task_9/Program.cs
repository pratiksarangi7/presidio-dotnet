
[AttributeUsage(AttributeTargets.Method)]
public class Runnable : Attribute
{
    public string Taskname;
    public Runnable(string taskName) => Taskname = taskName;
}

public class BackgroundWork
{
    [Runnable("Database Cleanup")]
    public void Cleanup() => Console.WriteLine("Cleaning up database...");

    [Runnable("Cache Refresh")]
    public void Refresh() => Console.WriteLine("Refreshing cache...");

    public void DoNotRun() => Console.WriteLine("This won't run.");
}

public class Engine
{
    static void Main(string[] args)
    {
        var bgWork = new BackgroundWork();
        var type = bgWork.GetType();
        var methods = type.GetMethods().Where(m => m.GetCustomAttributes(typeof(Runnable), false).Length > 0);
        foreach (var method in methods)
        {
            method.Invoke(bgWork, null);
        }
    }
}
