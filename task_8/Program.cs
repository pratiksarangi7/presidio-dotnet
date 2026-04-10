public interface IRepository<T> where T : class
{
    public void Add(T item);
    public T Get(int ind);
    public T Update(int ind, T data);
    public void Delete(int ind);
}
public class InMemoryRepository<T> : IRepository<T>, IEnumerable<T> where T : class
{

    public List<T> _items = new();
    public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
    public void Add(T item)
    {
        _items.Add(item);
    }
    public T Get(int ind)
    {
        return _items[ind];
    }
    public T Update(int ind, T data)
    {
        _items[ind] = data;
        return _items[ind];
    }
    public void Delete(int ind)
    {
        _items.RemoveAt(ind);
    }
}

public class Product
{
    public string name;
    public int id;
    public Product(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}
public class MainClass
{
    static void Main(string[] args)
    {
        InMemoryRepository<Product> prodRep = new();
        prodRep.Add(new Product("Headphone", 123));
        prodRep.Add(new Product("Bat", 2310));
        prodRep.Add(new Product("Cold drinks", 5829));
        prodRep.Add(new Product("Smart Phone", 291));
        Product p = prodRep.Get(0);
        Console.WriteLine($"{p.id}....{p.name}");
        Console.WriteLine("");
        prodRep.Delete(3);
        var p2 = prodRep.Update(1, new Product("Bat", 1123));
        foreach (var prod in prodRep)
        {
            Console.WriteLine($"{prod.id}....{prod.name}");
        }

    }
}