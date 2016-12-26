using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace TestFramework.Pages
{
    class ArticlesPage : AbstractPage
    {

        [FindsBy(How = How.CssSelector, Using = "body > div.main > div.container > div > div.wrapContent > div:nth-child(2) > div > div > div.page-head > h1")]
        private IWebElement header;

        public ArticlesPage(IWebDriver driver) : base(driver) { }


        public string GetHeaderName()
        {
            return header.Text;
        }

    }
}
