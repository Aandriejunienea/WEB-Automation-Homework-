using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Homework_WEB_automation
{
    class ConfirmPage : WebDriver
    {
        private IWebElement confirmOrder() { return Driver.FindElement(By.CssSelector("#cart_navigation > button > span")); }
        public void ConfirmProcess()
        {
            confirmOrder().Click();
        }
    }
}
