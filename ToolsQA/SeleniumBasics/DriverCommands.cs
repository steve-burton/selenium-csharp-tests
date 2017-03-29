using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA.SeleniumBasics
{
    class DriverCommands
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.demoqa.com";

            string Title = driver.Title;

            int TitleLength = driver.Title.Length;

            Console.WriteLine("Title of hte page is: " + Title);

            Console.WriteLine("Length of the Title is: " + TitleLength);

            string PageURL = driver.Url;

            int URLLength = PageURL.Length;

            Console.WriteLine("URL of the page is: " + PageURL);

            Console.WriteLine("Length of the URL is: " + URLLength);

            string PageSource = driver.PageSource;

            int PageSourceLength = driver.PageSource.Length;

            Console.WriteLine("Page Source of the page is: " + PageSource);

            Console.WriteLine("Length of the Page Source is: " + PageSourceLength);

            driver.Close();
            Console.ReadLine();
        }

        [Test]
        public void NavigateTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.demoqa.com");

            driver.FindElement(By.XPath(".//*[@id='menu-item-374']/a")).Click();
            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
            driver.Close();
        }
    }
}
