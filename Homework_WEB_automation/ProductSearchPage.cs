using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Homework_WEB_automation
{
    class ProductSearchPage: WebDriver
    {
        private IWebElement SearchField() { return Driver.FindElement(By.Id("search_query_top")); }
        private IWebElement SearchBtn() { return Driver.FindElement(By.Name("submit_search")); }
        public void DoSearchProcess()
        {
            SearchField().SendKeys("blouse");
            SearchBtn().Click();
        }

    }
}


