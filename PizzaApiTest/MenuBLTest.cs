using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using PizzaApi;

namespace PizzaApiTest
{
    [TestClass]
    public class MenuBLTest
    {
        [TestMethod]
        public void GetFullMenu_ReturnsValidJsonMenu()
        {
            var testFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\menu.json";
            var expectedTestMenu = File.ReadAllText(testFilePath);

            var menuBL = new MenuBL();

            var menu = menuBL.GetMenu();

        }
    }
}
