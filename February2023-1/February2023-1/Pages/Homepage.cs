using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023_1.Pages
{
    public class Homepage

    {
        public void GoToTMPage(IWebDriver driver)
        {


            //create new time record

            //click on create new button
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            //select timecode option from dropdown list
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }
    }
}
