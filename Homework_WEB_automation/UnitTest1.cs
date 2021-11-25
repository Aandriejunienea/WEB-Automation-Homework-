

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System;
using System.Threading;

namespace Homework_WEB_automation
{
    public class Tests : WebDriver
    {
        private HomePage homePage = new HomePage();
        private LoginPage loginPage = new LoginPage();
        private ProductSearchPage productSearchPage = new ProductSearchPage();
        private AcceptingTermsPage acceptingTermsPage = new AcceptingTermsPage();
        private AddToCartPage addToCartPage = new AddToCartPage();
        private ProceedCheckoutPage proceedCheckoutPage = new ProceedCheckoutPage();
        private ProceedCheckout_2_Page proceedCheckout_2_Page = new ProceedCheckout_2_Page();
        private PayByBankPage payByBankPage = new PayByBankPage();
        private ConfirmPage confirmPage = new ConfirmPage();

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(); //
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [Test]
        public void TestLoginPage()
        {
            DoLogin();
        }

        [Test]
        public void LoginTest()
        {
            DoLogin();
            IWebElement AgnaAgna = Driver.FindElement(By.LinkText("Agna Agna"));
            Assert.AreEqual("Agna Agna", AgnaAgna.Text, "Error message: this button is not visible on the page");
            //Assert.AreEqual(EXPECTED, ACTUAL RESULT, "Error message: this button is not visible on the page");
        }

        [Test]
        public void search_blouse()
        {
            DoLogin();
            ProductSearch();    
        }

        [Test]
        public void validate_searched_item()
        {
            DoLogin();
            ProductSearch();

            var picBlouse = Driver.FindElement(By.CssSelector("#center_column > ul > li > div > div.left-block > div > a.product_img_link > img"));
            Assert.That(picBlouse.Displayed, Is.True);
        }


        [Test]
        public void complete_order()
        {
            DoLogin();
            ProductSearch();
            Add_to_cart();

            IWebElement proceed = Driver.FindElement(By.CssSelector("#layer_cart > div.clearfix > div.layer_cart_cart.col-xs-12.col-md-6 > div.button-container > a"));
            Injection(proceed);
            Thread.Sleep(9000);

            Checkout();
            Checkout_2();
            Accepting();
            Pay();
            Confirm();   
        }

        [Test]
        public void validate_complete_order()
        {
            DoLogin();

            IWebElement Account = Driver.FindElement(By.CssSelector("#header > div.nav > div > div > nav > div:nth-child(1) > a"));
            Account.Click();

            IWebElement Order_History = Driver.FindElement(By.CssSelector("#center_column > div > div:nth-child(1) > ul > li:nth-child(1) > a > i"));
            Order_History.Click();
                           
            var complete = Driver.FindElement(By.CssSelector("#block-history > p"));
            Assert.That(complete.Displayed, Is.False);
        }


            public void DoLogin()
        {
            homePage.ClickLoginButton();
            loginPage.DoLoginProcess();
        }

        public void Injection(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public void ProductSearch()
        {
            productSearchPage.DoSearchProcess();
        }

        public void Accepting()
        {
            acceptingTermsPage.DoAcceptTerms();
        }
        
        public void Add_to_cart()
        {
            addToCartPage.AddToCartProcess();
        }

        public void Checkout()
        {
            proceedCheckoutPage.ProceedCheckoutProcess();
        }

        public void Checkout_2()
        {
            proceedCheckout_2_Page.ProceedCheckout_2_Process();
        }

        public void Pay()
        {
            payByBankPage.PayByBankProcess();
        }

        public void Confirm()
        {
            confirmPage.ConfirmProcess();
        }
    }


}