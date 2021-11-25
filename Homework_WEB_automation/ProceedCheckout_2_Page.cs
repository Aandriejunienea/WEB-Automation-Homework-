using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Homework_WEB_automation
{
    class ProceedCheckout_2_Page : WebDriver
    {
        private IWebElement proceedCheckout2() { return Driver.FindElement(By.CssSelector("#center_column > form > p > button > span")); }
        public void ProceedCheckout_2_Process()
        {
            proceedCheckout2().Click();
        }
    }
}
