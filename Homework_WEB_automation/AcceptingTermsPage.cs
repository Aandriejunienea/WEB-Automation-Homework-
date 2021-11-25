using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;


namespace Homework_WEB_automation
{
    class AcceptingTermsPage : WebDriver
    {
        private IWebElement AcceptTerms() { return Driver.FindElement(By.Id("cgv")); }
        private IWebElement proceedCheckout3() { return Driver.FindElement(By.CssSelector("#form > p > button > span")); }
        public void DoAcceptTerms()
        {
            AcceptTerms().Click();
            proceedCheckout3().Click();
        }

    }
}


