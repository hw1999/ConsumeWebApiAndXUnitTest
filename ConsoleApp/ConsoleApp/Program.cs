using System;
using System.Collections.Generic;
using ConsoleApp.Models;

/// <summary>
/// Senior Developer:   Hongwei Li
/// Date:               2017-10-26
/// Decription:         I. Web Apis
///                     Hongwei Li developed Web Apis about fetching stock prices with Microsoft .net Core 2017 
///                     and deployed them at Microsoft Azure cloud.
///                     Web Api:
///                         post:   http://hongwei2008getstockpricewithwebapi.azurewebsites.net/api/StockPrice/FB,SPY,GE,JPM
///                         get:    http://hongwei2008getstockpricewithwebapi.azurewebsites.net/api/StockPrice/GetAllStocks
///                         get:    http://hongwei2008getstockpricewithwebapi.azurewebsites.net/api/StockPrice/3
///                         delete: http://hongwei2008getstockpricewithwebapi.azurewebsites.net/api/StockPrice/1
/// 
///                     II. Console application
///                     Hongwei Li developed this console application with Microsoft .net Core 2017
///                     a.  create the stock model
///                     b.  consume the Web Apis in the controllers via http client
///                     c.  show the results on the console screen
///                     d.  create the Unit tests and the xUnit tests
/// </summary>

namespace ConsoleApp
{
    class Program
    {       
        static void Main(string[] args)
        {
            try
            { 
                Console.WriteLine("Hello World!");

                Stock stock = Controllers.StockPriceController.GetStockPriceById(3).Result;

                Console.WriteLine("---------------- Get single stock price and show it ---------------------------");

                Console.WriteLine("Id       = {0}", stock.Id);
                Console.WriteLine("Symbol   = {0}", stock.Symbol);
                Console.WriteLine("Date     = {0}", stock.Date);
                Console.WriteLine("Time     = {0}", stock.Time);
                Console.WriteLine("Last     = {0}", stock.Last);
                Console.WriteLine("Volume   = {0}", stock.Volume);
                Console.WriteLine("Change   = {0}", stock.Change);
                Console.WriteLine("Bid      = {0}", stock.Bid);
                Console.WriteLine("Ask      = {0}", stock.Ask);            
                Console.WriteLine("High     = {0}", stock.High);
                Console.WriteLine("Low      = {0}", stock.Low);

                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("---------------- Get all stock prices and show them ---------------------------");

                List<Stock> stocks = Controllers.StockPriceController.GetAllStockPrice().Result;
                foreach (IStock item in stocks)
                {
                    Console.WriteLine("Id       = {0}", item.Id);
                    Console.WriteLine("Symbol   = {0}", item.Symbol);
                    Console.WriteLine("Date     = {0}", item.Date);
                    Console.WriteLine("Time     = {0}", item.Time);
                    Console.WriteLine("Last     = {0}", item.Last);
                    Console.WriteLine("Volume   = {0}", item.Volume);
                    Console.WriteLine("Change   = {0}", item.Change);
                    Console.WriteLine("Bid      = {0}", item.Bid);
                    Console.WriteLine("Ask      = {0}", item.Ask);
                    Console.WriteLine("High     = {0}", item.High);
                    Console.WriteLine("Low      = {0}", item.Low);
                    Console.WriteLine("*******************************************************************************");
                }
            }
            catch(Exception error)
            {
                Console.Write(error.ToString());
                Console.WriteLine("");
            }

            Console.ReadKey();
        }

    }
}
