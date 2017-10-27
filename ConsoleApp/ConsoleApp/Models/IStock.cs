using System;


namespace ConsoleApp.Models
{
    interface IStock
    {
        long Id { get; set; }
        string Symbol { get; set; }
        DateTime Date { get; set; }
        string Time { get; set; }
        double Last { get; set; }
        string Change { get; set; }
        string Bid { get; set; }
        string Ask { get; set; }
        long Volume { get; set; }
        string High { get; set; }
        string Low { get; set; }
    }
}
