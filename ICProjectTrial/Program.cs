using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace ICProjectTrial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open the browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //open the turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username enter valid user name
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
           
         //identify password and enter valid password
         IWebElement passwordTextbox= driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            //login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            //check if user is logged in successfully
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            {
                if (hellohari.Text == "Hello hari!")
                {
                    Console.WriteLine("passed");

                }
                else
                {
                    Console.WriteLine("not passed");
                }


            }
            //Create time and material
            //click on administration dropdown
            IWebElement administrationDropDown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropDown.Click();
            //click on time and material from dropdown
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            //click create new
            IWebElement createNew= driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNew.Click();
            //select material from typecode dropdown
            IWebElement typecodeDropdown= driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropdown.Click();
            IWebElement selectMaterial= driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
            //type coode
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("123");
            //type description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("hai");
            //price
            IWebElement pricePerunit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pricePerunit.Click();
            IWebElement priceBox = driver.FindElement(By.Id("Price"));
            priceBox.SendKeys("12");
            //click save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1000);
            //clickon gotolast page
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(1000);

            // check if created data in table
            IWebElement lastData = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            {
                if(lastData.Text=="123")
                {
                    Console.WriteLine("last data created pass");
                }

            else
                {
                    Console.WriteLine("last data created fail");
                }
            }
        }
    }
}
