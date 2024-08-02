using System.Xml;

namespace AdapterSample;

//Defining Client who will request the access to Adaptee
public class StockClient
{
    private IStockTarget _stockXMLTarget;
    public StockClient(IStockTarget stockXMLTarget)
    {
        _stockXMLTarget = stockXMLTarget;
    }

    public string? GetByKey(string stockKey)
    {
        return _stockXMLTarget.GetByKey(stockKey);
    }

}