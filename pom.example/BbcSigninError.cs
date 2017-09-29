using NUnit.Framework;
using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using pom.example.pages;
namespace pom.example
{
    [TestFixture()]
    public class BbcSigninError
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test()]
        public void BbcSignInErrorFirst()
        {
            BbcHomepage bbchomepage = new BbcHomepage(driver);
            BbcSigninPage bbcSigninPage = new BbcSigninPage(driver);
            bbchomepage.GoToPage();
            bbchomepage.ClickSignInLink();
            bbcSigninPage.FillUsernameField("username@username.com");
			bbcSigninPage.ClickSubmitButton();
            string error = bbcSigninPage.GetErrorFieldTest();
            StringAssert.Contains(error, "Sorry, those details don't match. Check you've typed them correctly.");
		}

        [TearDown]
        public void TearDown()
        {
            //driver.Close();
        }
    }
}

