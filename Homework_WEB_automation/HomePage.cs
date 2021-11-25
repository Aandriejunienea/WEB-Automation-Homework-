using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Homework_WEB_automation
{
    class HomePage : WebDriver
    {
        private IWebElement GetLoginButton() { return Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div.header_user_info > a")); }
        public void ClickLoginButton()
        {
            GetLoginButton().Click();
        }
    }
}
