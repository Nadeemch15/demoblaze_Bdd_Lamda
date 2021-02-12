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
    public class Login :PageBase
        
    {

        IWebDriver driver; // not used yet
        public Login(IWebDriver _driver): base (_driver)
        {
            this.driver = _driver;  // not used yet
        }
        
        #region Elements

        IWebElement LinkButton => ObjectRepository.Driver.FindElement(By.Id("login2"));

        IWebElement Username => ObjectRepository.Driver.FindElement(By.Id("loginusername"));

        IWebElement Password => ObjectRepository.Driver.FindElement(By.Id("loginpassword"));

        IWebElement LoginButton => ObjectRepository.Driver.FindElement(By.XPath("//button[contains(text(),'Log in')]"));

        IWebElement CloseBtn => ObjectRepository.Driver.FindElement(By.XPath("//body/div[@id='logInModal']/div[1]/div[1]/div[3]/button[1]"));
      
 #endregion

        #region Actions
        public void LoginLink()
        {
            LinkButton.Click();
        }

        public void EnterLoginDetail(string name, string pword)
        {
            Username.SendKeys(name);
            Password.SendKeys(pword);
            LoginButton.Click();
        }     
        #endregion
    }
}
