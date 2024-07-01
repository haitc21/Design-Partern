// Abstract Product Interface
public interface ICake
{
    void Bake();
}
// Concrete Product - New Year Cake
public class NewYearCake : ICake
{
    public void Bake()
    {
        Console.WriteLine("Baking New Year Cake!");
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