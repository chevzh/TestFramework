using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

#pragma warning disable 649

namespace TestFramework.Pages
{
    class ShoutsPage: AbstractPage
    {

        [FindsBy(How = How.CssSelector, Using = "#id_cry-text")]
        private IWebElement shout_text_area;




        public ShoutsPage(IWebDriver driver) : base(driver){ }


       
        
        public void Shout(string text) {
            //shout_text_area.Click();
            shout_text_area.SendKeys(text);
            shout_text_area.SendKeys(Keys.Enter);

        }


    }
}
