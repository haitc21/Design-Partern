public static class CakeFactory
{
    // Factory method to create cakes based on recipe
    public static ICake CreateCake(string recipe)
    {
        switch (recipe.ToLower())
        {
            case "new year":
                return new NewYearCake();
            case "mid autumn":
                return new MidAutumnCake();
            case "cookue":
                return new MidAutumnCake();
            default:
                throw new ArgumentException("Unknown recipe", nameof(recipe));
        }
    }
}