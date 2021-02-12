using Framework_Specflow_new_.BasePage;
using Framework_Specflow_new_.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_.PageObject
{
    public class ContactUs : PageBase
    {
        IWebDriver Driver;
        public ContactUs(IWebDriver Driver) :base (Driver)
        {
            this.Driver = Driver;
        }

        IWebElement ContactLink => Driver.FindElement(By.XPath("//a[text()='Contact']"));
        IWebElement ContactEmail => Driver.FindElement(By.Id("recipient-email"));
        IWebElement ContactName => Driver.FindElement(By.Id("recipient-name"));
        IWebElement MessageBtn => Driver.FindElement(By.XPath("//button[contains(text(),'Send message')]"));
        IWebElement Message => Driver.FindElement(By.Id("message-text"));
        IWebElement CloseBtn => Driver.FindElement(By.Id("recipient-name"));
                             
        public void ClickContactLink()
        {
            ContactLink.Click();
        }
        public void MessageDetail(string email, string name)
        {
            ContactEmail.SendKeys(email);
            ContactName.SendKeys(name);
            Message.SendKeys("This is master branch");
            ImplicitWait();           

            MessageBtn.Click();

        }

        public void MessageSent()
        {
            IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            var text = alert.Text;
            Console.WriteLine(text);
            alert.Accept();
        }

    }
}
