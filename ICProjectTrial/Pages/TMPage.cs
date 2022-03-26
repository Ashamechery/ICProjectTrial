using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ICProjectTrial.Pages
{
    internal class TMPage
    {
        public void CreateTMPage(IWebDriver driver)
        {
            //Create time and material

            //click create new
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNew.Click();
            //select material from typecode dropdown
            IWebElement typecodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeDropdown.Click();
            IWebElement selectMaterial = driver.FindElement(By.XPath("//*[@id='TypeCode_option_selected']"));
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
            wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);

            //clickon gotolast page
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPage.Click();
            wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);

            // check if created data in table
            IWebElement lastData = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            {
                if (lastData.Text == "123")
                {
                    Console.WriteLine("last data created pass");
                }

                else
                {
                    Console.WriteLine("last data created fail");
                }
            }
        }
        public void EditTM(IWebDriver driver)
        {

        }
        public void DeleteTM(IWebDriver driver)
        {

        }
    }
}
