using AdapterSample;

StockAdaptee adaptee = new StockAdaptee();
IStockTarget adapter = new StockJsonAdapter(adaptee);
// Sử dụng Client
StockClient client = new StockClient(adapter);
string? jsonResult = client.GetByKey("TSLA");
Console.WriteLine(jsonResult);