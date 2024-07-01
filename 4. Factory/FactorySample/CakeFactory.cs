public static class CakeFactory
{
    // Factory method to create cakes based on recipe
    public static ICake CreateCake(string recipe)
    {
        switch (recipe)
        {
            case "chocolate":
                return new ChocolateCake();
            case "mid autumn":
                return new MidAutumnCake();
            case "cookue":
                return new Cookie();
            default:
                throw new ArgumentException("Unknown recipe", nameof(recipe));
        }
    }
}