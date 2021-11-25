using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Homework_WEB_automation
{
    class PayByBankPage :WebDriver
    {
        private IWebElement payByBank() { return Driver.FindElement(By.CssSelector("#HOOK_PAYMENT > div:nth-child(1) > div > p > a")); }
        public void PayByBankProcess()
        {
            payByBank().Click();
        }
    }
}

