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
    class PubPage : AbstractPage
    {

        [FindsBy(How = How.CssSelector, Using = "body > div.main > div.container > div > div.wrapContent > div.b-pub-list > div.b-pub-list__header > button")]
        private IWebElement post_button;

        [FindsBy(How = How.Id, Using = "id_title")]
        private IWebElement title;

        [FindsBy(How = How.CssSelector, Using = "body > div.main > div.container > div > div.wrapContent > div.b-pub-list > div.b-pub-list__header > div > div.popup > form > div > div.post-editor > div > div")]
        private IWebElement text_area;


        [FindsBy(How = How.CssSelector, Using = "body > div.main > div.container > div > div.wrapContent > div.b-pub-list > div.b-pub-list__header > div > div.popup > form > footer > button.ui-button-new.mls.js-submit-button")]
        private IWebElement save_button;

       


        public PubPage(IWebDriver driver) : base(driver) { }


        public void PostArticle(string title_text, string text)
        {
            post_button.Click();
            title.SendKeys(title_text);
            text_area.SendKeys(text);
            save_button.Click();
            
        }

    }
}
