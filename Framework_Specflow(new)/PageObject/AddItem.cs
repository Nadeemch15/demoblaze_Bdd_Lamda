using Framework_Specflow_new_.BasePage;
using Framework_Specflow_new_.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace Framework_Specflow_new_.PageObject
{
    public class AddItem : PageBase

    {
        IWebDriver driver;
        public AddItem(IWebDriver driver): base (driver)
        {
            this.driver = driver;
        }

        IWebElement MonitorLink => ObjectRepository.Driver.FindElement(By.LinkText("Monitors"));
        IWebElement AppleMonitorLink => ObjectRepository.Driver.FindElement(By.XPath("//a[contains(text(),'Apple monitor 24')]"));
        IWebElement Addtocart => ObjectRepository.Driver.FindElement(By.LinkText("Add to cart"));

        // Assert
        IWebElement CartTab => ObjectRepository.Driver.FindElement(By.LinkText("Cart"));
        IWebElement VerifiyMonitor => ObjectRepository.Driver.FindElement(By.XPath("//td[contains(text(),'Apple monitor 24')]"));

        public void AddMonitor()
        {
            MonitorLink.Click();
            //Actions action = new Actions(ObjectRepository.Driver);
            //action.MoveToElement(AppleMonitorLink).Perform();
            ImplicitWait();
            AppleMonitorLink.Click();
            Addtocart.Click();
        }

        public void MonitorDisplayed()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            //var text = alert.Text;
            Console.WriteLine(alert.Text);
            alert.Accept();
        }
        public void verifiyItem()
        {
            CartTab.Click();
            Assert.AreEqual(VerifiyMonitor.Text, "Apple monitor 24");
            Console.WriteLine("Monitor displayed : " + VerifiyMonitor.Text);
        }
    }
}
