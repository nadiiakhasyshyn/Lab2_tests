using OpenQA.Selenium;

namespace ObjectPages
{
    public class LoginUserPage : BasePage
    {
        public LoginUserPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        private IWebElement btnLogin => driver.FindElement(By.Name("login-button"));
        private IWebElement userName => driver.FindElement(By.Name("user-name"));
        private IWebElement password => driver.FindElement(By.Name("password"));
        public void ClickButtonLogin() => btnLogin.Click();
        public void ClickUserName() => userName.Click();
        public void ClickPassword() => password.Click();
        public void EnterUserName() => userName.SendKeys("locked_out_user");
        public void EnterPassword() => password.SendKeys("secret_sauce");
       
    }
}
