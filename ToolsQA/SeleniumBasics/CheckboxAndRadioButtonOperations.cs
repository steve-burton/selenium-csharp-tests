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
    class CheckboxAndRadioButtonOperations
    {
        [Test]
        public void Test()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.Url = "http://toolsqa.wpengine.com/automation-practice-form";

            IList<IWebElement> rdBtn_Sex = driver.FindElements(By.Name("sex"));

            bool bValue = false;

            bValue = rdBtn_Sex.ElementAt(0).Selected;

            if (bValue == true)
            {
                rdBtn_Sex.ElementAt(1).Click();
            }
            else
            {
                rdBtn_Sex.ElementAt(0).Click();
            }

            IWebElement rdBtn_Exp = driver.FindElement(By.Id("exp-2"));
            rdBtn_Exp.Click();

            IList<IWebElement> chkBx_Profession = driver.FindElements(By.Name("profession"));

            int iSize = chkBx_Profession.Count;

            for (int i = 0; i< iSize; i++)
            {
                string Value = chkBx_Profession.ElementAt(i).GetAttribute("value");

                if (Value.Equals("Automation Tester"))
                {
                    chkBx_Profession.ElementAt(i).Click();
                    break;
                }
            }

            IWebElement oCheckBox = driver.FindElement(By.CssSelector("input[value='Selenium Webdriver']"));
            oCheckBox.Click();
            driver.Close();
        }
    }
}
