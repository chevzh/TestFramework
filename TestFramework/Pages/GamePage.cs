using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
#pragma warning disable 649

namespace TestFramework.Pages
{
    public class GamePage : AbstractPage
    {

        [FindsBy(How = How.CssSelector, Using = "body > div.main > div.container > div > div.wrapContent > div.game > div > h1")]
        private IWebElement game_name;

        [FindsBy(How = How.CssSelector, Using = "body > div.main > div.container > div > div.wrapContent > div.game > div > div.wrapGameContent.clearfix > div.gameContent > div > div.cardOfGame > div.likes-info > a")]
        private IWebElement like_button;

        [FindsBy(How = How.ClassName, Using = "likes-qty js-like-text")]
        private IWebElement num;

        public GamePage(IWebDriver driver) : base(driver){}
        

        public string GetGameName()
        {
            return game_name.Text;
        }

        public void LikeGame()
        {
            like_button.Click();
        }


        public string GetNum()
        {
            return num.Text;
        }

    }
}
