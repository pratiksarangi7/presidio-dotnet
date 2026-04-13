public delegate void SufficientItemsEventHandler();
public class Producer
{
    int itemsCount = 0;
    public event SufficientItemsEventHandler onSuffItemsProduced;
    public void produceItem()
    {
        itemsCount++;
        if (itemsCount >= 15 && onSuffItemsProduced != null)
        {
            onSuffItemsProduced();
        }
    }
}

public class Consumer
{
    string name;

    public Consumer(string name) => this.name = name;
    public void consumeItem()
    {
        System.Console.WriteLine($"Consuming Item!!!: {name}");
    }
}

public class MainBlock
{
    public static void Main(string[] args)
    {
        Consumer c1 = new("Consumer 1");
        Consumer c2 = new("Consumer 2");
        Producer p = new();
        p.onSuffItemsProduced += c1.consumeItem;
        p.onSuffItemsProduced += c2.consumeItem;
        while (true)
        {
            System.Console.WriteLine("Press any key to produce items");
            var k = Console.ReadKey();
            p.produceItem();
        }

    }
}