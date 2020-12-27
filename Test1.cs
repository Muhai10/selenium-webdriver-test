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

namespace Integration_testing
{
    class Test1
    {
        IWebDriver driver;


        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();                      
        }
        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));
            element1.SendKeys("bangladesh");                        

            IWebElement element2 = driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[3]/center/input[1]"));
            element2.Click();                                  
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();                                   
        }
    }
}
