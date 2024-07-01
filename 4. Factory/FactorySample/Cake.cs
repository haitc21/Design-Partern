// Abstract Product Interface
public interface ICake
{
    void Bake();
}
// Concrete Product - Chocolate Cake
public class ChocolateCake : ICake
{
    public void Bake()
    {
        Console.WriteLine("Baking a chocolate cake.");
    }
}

// Concrete Product - MidAutumn Cake
public class MidAutumnCake : ICake
{
    public void Bake()
    {
        Console.WriteLine("Baking Mid-Autumn Cake!");
    }
}

// Concrete Product - Cookie
public class Cookie : ICake
{
    public void Bake()
    {
        Console.WriteLine("Baking Cookie!");
    }
}