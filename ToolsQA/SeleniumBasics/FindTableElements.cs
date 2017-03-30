using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Collections.Generic;
using NUnit.Framework;

namespace ToolsQA.SeleniumBasics
{
    class FindTableElements
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Programming_languages_used_in_most_popular_websites");
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));

            var elementTable = driver.FindElement(By.XPath("//div[@id='mw-content-text']//table[1]"));

            List<IWebElement> listTrElement = new List<IWebElement>(elementTable.FindElements(By.TagName("tr")));
            string strRowData = "";

            foreach (var elementTr in listTrElement)
            {
                List<IWebElement> listTdElement = new List<IWebElement>(elementTr.FindElements(By.TagName("td")));
                if (listTdElement.Count > 0)
                {
                    foreach (var elementTd in listTdElement)
                    {
                        strRowData = strRowData + elementTd.Text + "\t\t";
                    }
                }
                else
                {
                    Console.WriteLine("This is header row");
                    Console.WriteLine(listTrElement[0].Text.Replace(" ", "\t\t"));
                }
                Console.WriteLine(strRowData);
                strRowData = String.Empty;
            }
            Console.WriteLine("");
            driver.Quit();
        }
    }
}

