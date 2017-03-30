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
    class DropDownAndSelectOperations
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form";

            SelectElement optionSelection = new SelectElement(driver.FindElement(By.Id("continents")));

            optionSelection.SelectByText("Europe");

            Thread.Sleep(2000);

            optionSelection.SelectByIndex(2);
            Thread.Sleep(2000);

            IList<IWebElement> optionSize = optionSelection.Options;

            int iListSize = optionSize.Count;

            for (int i = 0; i < iListSize; i++)
            {
                string selectValue = optionSelection.Options.ElementAt(i).Text;
                Console.WriteLine("Value of hte select item is: " + selectValue);

                if (selectValue.Equals("Africa"))
                {
                    optionSelection.SelectByIndex(i);
                    break;
                }
            }

            driver.Close();
        }
    }
}
