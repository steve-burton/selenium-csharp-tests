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
    class FindElementCommands
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = ("http://toolsqa.wpengine.com/Automation-practice-form/");

            driver.FindElement(By.Name("firstname")).SendKeys("Lakshay");

            driver.FindElement(By.Name("lastname")).SendKeys("Sharma");

            driver.FindElement(By.Id("submit")).Click();
        }
    }
}
