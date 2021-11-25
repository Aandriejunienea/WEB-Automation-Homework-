using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Homework_WEB_automation
{
    class AddToCartPage : WebDriver
    {
        private IWebElement addToCart() { return Driver.FindElement(By.CssSelector("#center_column > ul > li > div > div.right-block > div.button-container > a.button.ajax_add_to_cart_button.btn.btn-default > span")); }
        public void AddToCartProcess()
        {
            addToCart().Click();
        }
    }
}

