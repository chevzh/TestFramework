using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using log4net;
using log4net.Config;

namespace TestFramework
{
    [TestFixture]
    public class Tests
    {
        private const string login_first = "testchevzh1";
        private const string email_first = "testchevzh1@mail.ru";
        private const string password_first = "rIVTjMBJ";
        private const string game_name = "Max Payne";
        private const string news_header = "Новости";
        private const string articles_header = "Статьи";
        private const string likes_string = "Оценили 2325 человек";
        private const string shout = "Test";
        private const string title = "Test Title";
        private const string text = "Test Text";
        private const string comment = "Test Comment";



        private Steps steps;
        [SetUp]
        public void Init()
        {
            steps = new Steps();
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }


        [Test]
        public void LoginTest()
        {

            steps.LoginKanobu(email_first, password_first);
            Assert.IsTrue(steps.IsLoggedIn(login_first));
            steps.LogOut();

        }



        [Test]
        public void ShoutTest()
        {
            steps.LoginKanobu(email_first, password_first);

            steps.PostShout(shout);
            steps.LogOut();
        }


        [Test]
        public void ProfileCheck()
        {
            steps.LoginKanobu(email_first, password_first);
            steps.OpenProfile();
            steps.ProfileNameCheck(login_first);
            steps.LogOut();

        }


        [Test]
        public void SearchGameTest()
        {
            steps.LoginKanobu(email_first, password_first);
            steps.SearchGame(game_name);
            steps.CheckGameName(game_name);
            steps.LogOut();
        }



        [Test]
        public void LikeGameTest()
        {
            steps.LoginKanobu(email_first, password_first);
            steps.SearchGame(game_name);
            steps.LikeGame();
            steps.CheckLikesNum(likes_string);
            steps.LikeGame();
            steps.LogOut();
        }


        [Test]
        public void NewsTest()
        {
            steps.LoginKanobu(email_first, password_first);
            steps.GoToNews();
            steps.CheckNews(news_header);
            steps.LogOut();
        }



        Протестить статьи+, написать в паб+, рецензии, оставить комментарий, работу с меню пофиксить

        [Test]
        public void ArticleTest()
        {

            steps.LoginKanobu(email_first, password_first);
            steps.GoToArticles();
            steps.CheckArticles(articles_header);
        }


        [Test]
        public void PubPostTest()
        {
            steps.LoginKanobu(email_first, password_first);
            steps.GoToPub();
            steps.PubPost(title, text);
        }




    }
}
