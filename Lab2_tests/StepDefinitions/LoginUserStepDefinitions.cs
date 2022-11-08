using NUnit.Framework;
using ObjectPages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class LoginUserStepDefinitions : BaseSteps
    {
        private LoginUserPage loginUserPage => new LoginUserPage(driver);
       
        [Given("I enter the data")]
        public void GivenIClickOnInputs()
        {
            loginUserPage.ClickUserName();
            loginUserPage.EnterUserName();

            loginUserPage.ClickPassword();
            loginUserPage.EnterPassword();
        }
        [When("I click on login")]
        public void WhenIClickOnLogin()
        {
            loginUserPage.ClickButtonLogin();
        }
        [Then("I should see alert")]
        public void ThenIShouldSeeSuccessAlert()
        {
            Assert.That(driver.FindElement(By.CssSelector("*[data-test='error']")).Text, Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
        }

    }
}
