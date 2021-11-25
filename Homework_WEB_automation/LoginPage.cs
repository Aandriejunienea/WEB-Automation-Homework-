using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Homework_WEB_automation
{
    class LoginPage : WebDriver
    {
        private IWebElement GetUserNameField() { return Driver.FindElement(By.Name("email")); }
        private IWebElement GetPasswordField() { return Driver.FindElement(By.Name("passwd")); }
        private IWebElement Ge_Login_Button()  { return Driver.FindElement(By.Id("SubmitLogin")); }
        public void DoLoginProcess()
        {
            GetUserNameField().SendKeys("agna1@agna.com");
            GetPasswordField().SendKeys("agna1");
            Ge_Login_Button().Click();
        }
    }

}
