
IGUIFactory factory;
Console.WriteLine("Enter OS type (Windows/Mac): ");
string osType = Console.ReadLine();

if (osType.Equals("Windows", StringComparison.OrdinalIgnoreCase))
{
    factory = new WindowsFactory();
}
else
{
    factory = new MacFactory();
}

Application app = new Application(factory);
app.Paint();
