using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace ICProjectTrial.Pages
{
    internal class TM_Tests
    {
        static void Main(string[] args)
        {


            //open the browser  
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //login page object initialiaztion and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
            //home pageobject initialiaztion and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
            //TMPage object initialization nd defintn
            TMPage tMPageObj = new TMPage();
            //create tmpage object initialiaztion and definition
            tMPageObj.CreateTMPage(driver);
            //delete tmpage object initialiaztion and definitio
            tMPageObj.EditTM(driver);
            //create tmpage object initialiaztion and definition
            tMPageObj.DeleteTM(driver);



        }
    }
}
