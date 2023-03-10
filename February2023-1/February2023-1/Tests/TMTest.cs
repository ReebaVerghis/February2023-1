using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using February2023_1.Pages;
//open browser
IWebDriver driver = new ChromeDriver();
//login page object initialization and definition
Loginpage loginpageObj = new Loginpage();
loginpageObj.LoginActions(driver);
//Home page object initialization and definition
Homepage homepageObj = new Homepage();
homepageObj.GoToTMPage(driver);
//TMPage page object initialization and definition
TMPage tmpageobj = new TMPage();
tmpageobj.CreateTM(driver);
//Edit TM
tmpageobj.EditTM(driver);
//Delete TM
tmpageobj.DeleteTM(driver); 












