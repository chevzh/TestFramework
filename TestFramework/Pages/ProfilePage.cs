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
    class ProfilePage : AbstractPage
    {

        private const string BASE_URL = "http://kanobu.ru/accounts/1004691/";

        [FindsBy(How = How.CssSelector, Using = "body > div.main > div.container > div > div.profileCover.space > div.profileCoverContent > div.userpic > div.username > span")]
        private IWebElement user_name;


        public ProfilePage(IWebDriver driver) : base(driver){ }


        public void OpenPage()
        {
            driver.Navigate().GoToUrl(BASE_URL);
        }

        public string GetProfileName()
        {
            
            return user_name.Text;
        }

    }
}
