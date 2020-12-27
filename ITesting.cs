using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Integration_Testing
{
    class ITesting
    {
        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();         //starting the chrome             
        }
        [Test]
        public void test()
        {
            driver.Url = "http://elp.duetbd.org";          //Url 

            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='header']/div/ul/li[2]/div/span/a"));
            element1.Click();             //clicking on the username field                     

            IWebElement element = driver.FindElement(By.Name("username"));
            element.SendKeys("170042010");         //giving id input          
            IWebElement password = driver.FindElement(By.Name("password"));
            password.SendKeys("Abc.1234");          // password in the field     
            driver.FindElement(By.Id("loginbtn")).Click();    
            String at = driver.Title;
            String et = "Dashboard";              //dashboard page           
            if (at == et)
            {
                Console.WriteLine("Test Successful");      // if logged in to the system
            }
            else
            {
                Console.WriteLine("Unsuccessful");          //if wrong user id and password   
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();                   //Closing chrome           
        }
    }
}