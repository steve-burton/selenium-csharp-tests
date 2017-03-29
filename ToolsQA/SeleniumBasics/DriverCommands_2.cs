using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ToolsQA.SeleniumBasics
{
    class DriverCommands_2
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://demoqa.com/frames-and-windows/";

            driver.FindElement(By.XPath(".//*[@id='tabs-1']/div/p/a")).Click();
            driver.Quit();
        }
    }
}
