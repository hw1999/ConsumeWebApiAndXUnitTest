using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestStockPriceController
    {
        [TestMethod]
        public async Task TestGetStockPriceByIdAsync()
        {   
            Stock testStock = await ConsoleApp.Controllers.StockPriceController.GetStockPriceByIdAsync(3) as Stock;
            Assert.AreEqual(testStock.Id, 3);
            Assert.AreEqual(testStock.Symbol, "SPY");
        }

        [TestMethod]
        public async Task TestGetAllStockPriceAsync()
        {
            List<Stock> testStocks = await ConsoleApp.Controllers.StockPriceController.GetAllStockPriceAsync() as List<Stock>;
            Assert.AreEqual(testStocks.Count, 3);
            Assert.AreEqual(testStocks[0].Symbol, "FB");
            Assert.AreEqual(testStocks[1].Symbol, "SPY");
            Assert.AreEqual(testStocks[2].Symbol, "JPM");
        }
    }
}
