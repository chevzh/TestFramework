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
    
    public class MainPage : AbstractPage
    {
        private const string BASE_URL = "http://kanobu.ru/";
        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement login;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement pass;

        [FindsBy(How = How.CssSelector, Using = "#login_form > div.clear.submit-line.clearfix > input")]
        private IWebElement login_button;

        [FindsBy(How = How.ClassName, Using = "userName")]
        private IWebElement userName;

        [FindsBy(How = How.ClassName, Using = "profileItem")]
        private IWebElement menuItem;

        [FindsBy(How = How.ClassName, Using = "nickname")]
        private IWebElement nickname;

        [FindsBy(How = How.CssSelector, Using = "#js-userbar-scroller > div > div.profileControlLinks > a.exitLink.logout-trigger")]
        private IWebElement logout_button;

        [FindsBy(How = How.ClassName, Using = "userBlock")]
        private IWebElement profileItem;

        [FindsBy(How = How.CssSelector, Using = "#navigation-scroller-12321 > ul > li.check.opened > a")]
        private IWebElement shout_link;


        [FindsBy(How = How.CssSelector, Using = "body > div.page.main-page > header > div > div.b-topbar__body > a.search-link.js-search-link")]
        private IWebElement search_item;

        [FindsBy(How = How.Id, Using = "search")]
        private IWebElement search_string;


        [FindsBy(How = How.CssSelector, Using = "#ui-id-6")]
        private IWebElement game_link;

        [FindsBy(How = How.CssSelector, Using = "#navigation-scroller-12321 > ul > li:nth-child(2)")]
        private IWebElement news_link;

        [FindsBy(How = How.CssSelector, Using = "#navigation-scroller-12321 > ul > li:nth-child(4)")]
        private IWebElement articles_link;

        [FindsBy(How = How.CssSelector, Using = "#navigation-scroller-12321 > ul > li:nth-child(6)")]
        private IWebElement pub_link;


        [FindsBy(How = How.Id, Using = "nav_search_submit_button")]
        private IWebElement search_game_button;

        private IWebElement profile_button;

        private string profile_btn_locator = "//ul[@id='nav_welcome_box']/li[1]/a";

        private string error_message_locator = "//h1[@id='lightboxlogin_message']";


        public MainPage(IWebDriver driver) : base(driver) { }
        public void OpenPage()
        {
            Log.For(this).Info("Main page open");
            driver.Navigate().GoToUrl(BASE_URL);
        }
        public void Login(string name, string password)
        {
            login.SendKeys(name);
            pass.SendKeys(password);
            login_button.Click();
        }

        public void OpenProfile()
        {
            menuItem.Click();
            profileItem.Click();
                                   
        }

       

        public string GetLoggedInUserName()
        {
            OpenProfile();
           
            return userName.Text;
        }

        public void shoutLinkClick()
        {
            shout_link.Click();
        }

        public void OpenMenu()
        {
             menuItem.Click();
        }

        public void LogOut()
        {
           
            
         //   driver.Navigate().GoToUrl(BASE_URL + "/");
            
          //  driver.FindElement(By.CssSelector("span.menuIcon")).Click();
            
            driver.FindElement(By.CssSelector("a.exitLink.logout-trigger > span")).Click();
        }

        public void SearchGame(string game)
        {
            search_item.Click();
            search_string.SendKeys(game);
            game_link.Click();

        }

        public void GoToNews()
        {
            news_link.Click();
        }


        public void GoToArticles()
        {
            articles_link.Click();
        }


        public void GoToPub()
        {
            pub_link.Click();
        }


        //public SearchPage FindGame(string name)
        //{
        //    search_game_field.SendKeys(name);
        //    search_game_button.Click();
        //    return new SearchPage(driver);
        //}
    }
}
