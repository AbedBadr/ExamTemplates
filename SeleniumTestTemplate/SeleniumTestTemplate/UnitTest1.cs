using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestTemplate
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver = new ChromeDriver(/*sti til chromedriver.exe*/);

        [TestInitialize]
        public void TestSetup()
        {
            driver.Navigate().GoToUrl("/*hjemmesidens url*/");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Thread.Sleep(3000);
            IWebElement priceElement = driver.FindElement(By.Id("carPrice"));
            priceElement.Clear();
            priceElement.SendKeys("200000");
            Thread.Sleep(2000);

            SelectElement selectElement = new SelectElement(driver.FindElement(By.Id("carTypeSelect")));
            //selectElement.DeselectAll();
            selectElement.SelectByText("Personbil");
            Thread.Sleep(2000);

            IWebElement calculateButton = driver.FindElement(By.Id("calculateFee"));
            calculateButton.Click();
            Thread.Sleep(2000);

            IWebElement resultElement = driver.FindElement(By.Id("resultSpan"));
            double expectedValue = 200000 * 0.85;
            int actualValue = Int32.Parse(resultElement.Text);

            Assert.AreEqual((int)expectedValue, actualValue);
        }

        [TestCleanup]
        public void TestTeardown()
        {
            driver.Quit();
        }
    }
}
