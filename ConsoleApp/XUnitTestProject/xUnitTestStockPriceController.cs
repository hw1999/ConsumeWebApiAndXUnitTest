using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using ConsoleApp.Models;

namespace XUnitTestProject
{
    public class xUnitTestStockPriceController
    {
        [Fact]
        public async Task xTestGetStockPriceByIdAsync()
        {
            Stock testStock = await ConsoleApp.Controllers.StockPriceController.GetStockPriceByIdAsync(3) as Stock;
            Assert.Equal(testStock.Id, 3);
            Assert.Equal(testStock.Symbol, "SPY");
        }

        [Fact]
        public async Task xTestGetAllStockPriceAsync()
        {
            List<Stock> testStocks = await ConsoleApp.Controllers.StockPriceController.GetAllStockPriceAsync() as List<Stock>;
            Assert.Equal(testStocks.Count, 3);
            Assert.Equal(testStocks[0].Symbol, "FB");
            Assert.Equal(testStocks[1].Symbol, "SPY");
            Assert.Equal(testStocks[2].Symbol, "JPM");
        }
    }
}
