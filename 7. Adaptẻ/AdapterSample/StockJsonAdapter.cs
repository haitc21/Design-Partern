using System.Xml;
using Newtonsoft.Json;

namespace AdapterSample;

//Defining the Adapter that implements the Target interface
public class StockJsonAdapter : IStockTarget
{
    private readonly StockAdaptee _xmlAdaptee;

    public StockJsonAdapter(StockAdaptee jsonAdaptee)
    {
        _xmlAdaptee = jsonAdaptee;
    }

    public string? GetByKey(string stockKey)
    {
        // Sử dụng StockJsonAdaptee để lấy dữ liệu XML
        XmlDocument? xmlDoc = _xmlAdaptee.GetByKey(stockKey);

        if (xmlDoc != null)
        {
            // Remove any namespace attributes
            xmlDoc?.DocumentElement?.RemoveAllAttributes();
            // Lấy phần nội dung cần thiết từ XmlDocument (chỉ node StockInformation)
            XmlNode? stockInfoNode = xmlDoc?.SelectSingleNode("//StockInfo");
            if (stockInfoNode != null)
            {
                // Chuyển đổi node StockInformation thành JSON
                string jsonText = JsonConvert.SerializeXmlNode(stockInfoNode, Newtonsoft.Json.Formatting.Indented, true);
                return jsonText;
            }
        }
        return null;
    }
}
