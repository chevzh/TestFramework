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
    class NewsPage : AbstractPage
    {

        [FindsBy(How = How.CssSelector, Using = "body > div.main > div.container > div > div.wrapContent > div.newsListPage.clearfix > div > div.page-head > h1")]
        private IWebElement header;

        public NewsPage(IWebDriver driver) : base(driver) { }


        public  string GetHeaderName()
        {
            return header.Text;
        }

    }
}
