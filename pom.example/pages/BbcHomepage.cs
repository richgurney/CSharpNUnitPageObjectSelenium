using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace pom.example.pages
{
    public class BbcHomepage
    {

        private IWebDriver driver;

        public BbcHomepage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "idcta-link")]
        private IWebElement SignInLink;


        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://www.bbc.co.uk");
        }

        public void ClickSignInLink(){
            SignInLink.Click();
        }
    }
}
