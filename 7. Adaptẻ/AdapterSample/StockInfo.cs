using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterSample;
public class StockInfo
{
    public StockInfo()
    {
        StockKey = "";
        StockName = "";
        Open = 0;
        High = 0;
        Low = 0;
    }
    public StockInfo(string key, string name, double open, double high, double low)
    {
        StockKey = key;
        StockName = name;
        Open = open;
        High = high;
        Low = low;
    }

    public string StockKey { get; set; }
    public string StockName { get; set; }
    public double Open { get; set; }
    public double High { get; set; }
    public double Low { get; set; }
}