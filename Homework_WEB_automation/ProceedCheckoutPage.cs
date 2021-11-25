using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Homework_WEB_automation
{
    class ProceedCheckoutPage : WebDriver
    {
        private IWebElement proceedCheckout() { return Driver.FindElement(By.CssSelector("#center_column > p.cart_navigation.clearfix > a.button.btn.btn-default.standard-checkout.button-medium > span")); }
        public void ProceedCheckoutProcess()
        {
            proceedCheckout().Click();
        }
    }
}

