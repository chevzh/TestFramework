using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Pages;
using OpenQA.Selenium;
using System.Threading;
using log4net;
using log4net.Config;

//git/cmd в качестве имени версия программы
namespace TestFramework
{
    public class Steps
    {
        IWebDriver driver;
        public void InitBrowser()
        {
            driver = DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            //DriverInstance.CloseBrowser();
        }

        //!
        public void LoginKanobu(string username, string password)
        {
            
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            IWebElement LoginBtn = driver.FindElement(By.ClassName("loginItem"));
            LoginBtn.Click();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            driver.SwitchTo().Frame("iFrameResizer0");
            mainPage.Login(username, password);
        }


        //!
        public bool IsLoggedIn(string username)
        {
            MainPage mainPage = new MainPage(driver);
            return (mainPage.GetLoggedInUserName().Trim().Equals(username));
        }

        //!
        public bool ProfileNameCheck(string username)
        {
            ProfilePage profilePage = new ProfilePage(driver);
            return (profilePage.GetProfileName().Trim().Equals(username));
        }

        


        //!
        public void LogOut()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.OpenPage();
            mainPage.OpenMenu();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            mainPage.LogOut();
            
        }

        //!
        public void PostShout(string shoutText)
        {
            IWebElement shoutLink = driver.FindElement(By.CssSelector("#navigation-scroller-12321 > ul > li:nth-child(7) > a"));
            shoutLink.Click();
            ShoutsPage shoutsPage = new ShoutsPage(driver);
            shoutsPage.Shout(shoutText);
        }

        //!
        //public void PasswordChange()
        //{
        //    MainPage mainPage = new MainPage(driver);
        //    mainPage.OpenProfile();
        //}

       
        //!
        public void OpenProfile()
        {
            ProfilePage profilePage = new ProfilePage(driver);
            profilePage.OpenPage();
            
        }

        //!
        public void SearchGame(string game)
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.SearchGame(game);
        }
       
        //!
        public bool CheckGameName(string game)
        {
            GamePage gamePage = new GamePage(driver);
            return (gamePage.GetGameName().Trim().Equals(game));
        }

        //!
        public void LikeGame()
        {
            GamePage gamePage = new GamePage(driver);
            gamePage.LikeGame();
        }

        public bool CheckLikesNum(string num) {
            GamePage profilePage = new GamePage(driver);
            return (profilePage.GetNum().Trim().Equals(num));
        }

        public void GoToNews()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.GoToNews();
        }

        public void GoToArticles()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.GoToArticles();
        }




        public bool CheckNews(string news_header)
        {
            
            NewsPage newsPage = new NewsPage(driver);
            return (newsPage.GetHeaderName().Trim().Equals(news_header));
        }

        public bool CheckArticles(string articles_header)
        {

            ArticlesPage articlesPage = new ArticlesPage(driver);
            return (articlesPage.GetHeaderName().Trim().Equals(articles_header));
        }

        public void PostArticle()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.GoToArticles();

        }


        public void GoToPub()
        {
            MainPage mainPage = new MainPage(driver);
            mainPage.GoToPub();
            

        }

        public void PubPost(string title, string text)
        {
            PubPage pubPage = new PubPage(driver);
            pubPage.PostArticle(title,text);
        }

    }
}
