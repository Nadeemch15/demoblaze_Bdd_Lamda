using Framework_Specflow_new_.PageObject;
using Framework_Specflow_new_.Settings;
using System;
using TechTalk.SpecFlow;

namespace Framework_Specflow_new_.StepDefinition
{
    [Binding]
    public class EnterUserDetailSteps
    {
        private Login Login;
        public EnterUserDetailSteps()
        {
            
            this.Login = new Login(ObjectRepository.Driver);
        }
        [Given(@"I am on Website ""(.*)""")]
        public void GivenIAmOnWebsite(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
            ObjectRepository.Driver.Manage().Window.Maximize();

        }
        
        [Given(@"I clicked Login button")]
        public void GivenIClickedLoginButton()
        {
            Login.LoginLink();
        }
        
        [When(@"I entered credentials (.*) (.*)")]
        public void WhenIEnteredCredentials(string username, string password)
        {
            Login.EnterLoginDetail(username, password);
        }

        //[Then(@"I am sussessfully logged in")]
        //public void ThenIAmSussessfullyLoggedIn()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
