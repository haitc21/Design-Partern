using System.Xml;
using System.Xml.Serialization;

namespace AdapterSample;
//Defining the Adaptee to be accessed by the Client
public class StockAdaptee
{
    private List<StockInfo> _listStocks;
    public StockAdaptee()
    {
        _listStocks = new List<StockInfo>()
        {
            new ("TSLA", "Tesla, Inc.", 160.9, 165, 157.32),
            new ("TSLA", "Tesla, Inc.", 107.73, 09.48, 104.32),
            new ("AAPL", "Apple, Inc.", 168.49, 169.76, 167.88),
            new ("MSFT", "Microsoft Corporation.", 304.01, 308.93, 303.31)
        };
    }
    public XmlDocument? GetByKey(string stockKey)
    {
        var result = _listStocks.FirstOrDefault(x => x.StockKey == stockKey);
        if (result != null)
        {
            return SerializeToXmlDocument(result);
        }
        return null;
    }

    public XmlDocument SerializeToXmlDocument(object input)
    {
        XmlSerializer ser = new XmlSerializer(input.GetType());

        XmlDocument xd = new XmlDocument();

        using (MemoryStream memStm = new MemoryStream())
        {
            ser.Serialize(memStm, input);
            memStm.Position = 0;

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            using (var xtr = XmlReader.Create(memStm, settings))
            {
                xd.Load(xtr);
            }
        }
        return xd;
    }
}
