using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace pom.example.pages
{
    public class BbcSigninPage
    {
        private IWebDriver driver;

        public BbcSigninPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "submit-button")]
        private IWebElement SubmitButton;


		[FindsBy(How = How.Id, Using = "username-input")]
        private IWebElement UsernameField;


        [FindsBy(How = How.ClassName, Using = "form-message__text")]
        private IWebElement ErrorField;

		public void GoToPage()
        {
            driver.Navigate().GoToUrl("https://account.bbc.com/signin");
        }

        public void ClickSubmitButton()
        {
            SubmitButton.Click();
        }

        public void FillUsernameField(string username)
        {
            UsernameField.SendKeys(username);
        }

        public string GetErrorFieldTest()
        {
            return ErrorField.Text;
        }
    }
}
