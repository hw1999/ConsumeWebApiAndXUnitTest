using System;

namespace ConsoleApp.Models
{
    public class Stock: IStock
    {
        public long Id { get; set; }
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public double Last { get; set; }
        public string Change { get; set; }
        public string Bid { get; set; }
        public string Ask { get; set; }
        public long Volume { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
    }
}
