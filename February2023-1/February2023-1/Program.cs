
//open chrome browser
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
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
//check user has succesfully logged in
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (helloHari.Text == "Hello hari!")
    {
    Console.WriteLine("logged in sucessfull");
}
else 
{
    Console.WriteLine("login failed");
}

