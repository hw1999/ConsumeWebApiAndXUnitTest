using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Models;

namespace ConsoleApp.Controllers
{
    public static class StockPriceController
    {        
        //get the stock price by id
        // web api: http://hongwei2008getstockpricewithwebapi.azurewebsites.net/api/StockPrice/3
        public static async Task<Stock> GetStockPriceByIdAsync(int id)
        {
            string path = @"http://hongwei2008getstockpricewithwebapi.azurewebsites.net/api/StockPrice/" + id.ToString();
            Stock stock = null;

            using (HttpClient client = new HttpClient())
            { 
                string result = await client.GetStringAsync(path);
                stock = Newtonsoft.Json.JsonConvert.DeserializeObject<Stock>(result);
            }

            return stock;
        }

        // get all the stock prices 
        // web api: http://hongwei2008getstockpricewithwebapi.azurewebsites.net/api/StockPrice/GetAllStocks
        public static async Task<List<Stock>> GetAllStockPriceAsync()
        {
            string path = @"http://hongwei2008getstockpricewithwebapi.azurewebsites.net/api/StockPrice/GetAllStocks";
            List<Stock> stocks = null;

            using (HttpClient client = new HttpClient())
            { 
                string result = await client.GetStringAsync(path);
                stocks = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Stock>>(result);
            }
            return stocks;
        }
    }
}
