using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace February2023_1.Pages
{
    public class Loginpage
    {
        public void LoginActions(IWebDriver driver)
        {
            {
                driver.Manage().Window.Maximize();

                //Launch turnupportal
                driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

                //identify username textbox and enter valid username
                IWebElement userNameTextbox = driver.FindElement(By.Id("UserName"));
                userNameTextbox.SendKeys("Hari");

                //identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
                passwordTextbox.SendKeys("123123");
                //identify login button and click on it
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
                loginButton.Click();

            }
        }


    }
}
