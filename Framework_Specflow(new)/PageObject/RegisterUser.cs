using Framework_Specflow_new_.BasePage;
using Framework_Specflow_new_.Settings;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_Specflow_new_.PageObject
{
    public class RegisterUser :PageBase
    {
        IWebDriver driver;
        public RegisterUser(IWebDriver _driver) : base (_driver)
        {
            this.driver = _driver;
        }
        #region Element

        IWebElement SignUpLink => ObjectRepository.Driver.FindElement(By.LinkText("Sign up"));
        IWebElement UserName => ObjectRepository.Driver.FindElement(By.Id("sign-username"));
        IWebElement Password => ObjectRepository.Driver.FindElement(By.Id("sign-password"));
        IWebElement SignUpBtn => ObjectRepository.Driver.FindElement(By.XPath("//button[contains(text(),'Sign up')]"));
        IWebElement CloseBtn => ObjectRepository.Driver.FindElement(By.ClassName("btn btn-secondary"));
       #endregion

        #region Action
        public void SignUp()
        {
            SignUpLink.Click();
        }
        public void UserDetails(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            SignUpBtn.Click();
        }

        public void verification()
        {
            IAlert alert = ObjectRepository.Driver.SwitchTo().Alert();
            var text = alert.Text;
            Console.WriteLine(text);
            alert.Accept();
        }
        #endregion
    }
}
