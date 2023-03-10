
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
//create new time record

//click on create new button
IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationDropdown.Click();

//select timecode option from dropdown list
IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();
//click on create new button
IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNew.Click();
Thread.Sleep(1000);
//input code into code textbox
IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typeCodeDropdown.Click();
Thread.Sleep(1000);
IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();
//input code into code textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("February2023");
//input descriptionin into description textbox
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("February2023");
//input price into price per unit box
IWebElement pricetextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
pricetextbox.SendKeys("12");
// click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(2000);
//go to lastpage
IWebElement gotoLastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotoLastpage.Click();
Thread.Sleep(2000);

//check new code is created
IWebElement  newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if ( newCode.Text == "February2023")
{
    Console.WriteLine(("new code created"));
}
else
{
    Console.WriteLine("new code not created");
}
//Edit time record
IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPage.Click();
Thread .Sleep(500);
IWebElement edit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
edit.Click(); 
Thread .Sleep(500);
IWebElement editCode = driver.FindElement(By.Id("Code"));
editCode.Clear();
editCode.SendKeys("March2023");
//New edit code save
IWebElement editCodeSave = driver.FindElement(By.Id("SaveButton"));
editCodeSave.Click();
Thread .Sleep(1000);
//check new code is modified
//go to last page
IWebElement gotoLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotoLastPage.Click();
Thread.Sleep(2000);
//check test code edited
IWebElement testEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (testEdit.Text == "March2023")  
{
    Console.WriteLine("test code is edited sucessfully");
}
else
{
    Console.WriteLine("test code not edited");
}
//Delete code
// Go to last page
IWebElement lastPage1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastPage1.Click();
Thread.Sleep(500);
//delete code
IWebElement deleteCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteCode.Click();
Thread.Sleep(1000);
//click ok to the popup delete button
IAlert aL = driver.SwitchTo().Alert();
aL.Accept();
Thread.Sleep(2000);
IWebElement testDelete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if(testDelete.Text != "March2023")
{
    Console.WriteLine("Record is deleted");
}
else
{
    Console.WriteLine("record is not deletrd");
}


