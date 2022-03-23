using System;
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
        }
    }
}
