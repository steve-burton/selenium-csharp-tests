using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace ToolsQA.SeleniumBasics
{
    class MultiSelectList
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form";

            SelectElement optionSelection = new SelectElement(driver.FindElement(By.Name("selenium_commands")));

            optionSelection.SelectByIndex(0);
            Thread.Sleep(2000);
            optionSelection.DeselectByIndex(0);

            optionSelection.SelectByText("Navigation Commands");
            Thread.Sleep(2000);

            optionSelection.DeselectByText("Navigation Commands");

            IList<IWebElement> optionSize = optionSelection.Options;
            int iListSize = optionSize.Count;

            for (int i = 0; i < iListSize; i++)
            {
                string selectValue = optionSelection.Options.ElementAt(i).Text;
                Console.WriteLine("Value of the item is: " + selectValue);
                optionSelection.SelectByIndex(i);

                Thread.Sleep(2000);
            }

            optionSelection.DeselectAll();

            driver.Close();
        }
    }
}
