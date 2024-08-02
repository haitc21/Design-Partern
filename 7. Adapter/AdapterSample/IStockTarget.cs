using System.Xml;

namespace AdapterSample;

//Declaring the Target that the Client will use
public interface IStockTarget
{
    string? GetByKey(string stockKey);
}