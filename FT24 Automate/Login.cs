using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FT24_Automate
{

    class Login
    {



        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Manage().Window.Maximize();
            PropertiesCollection.Driver.Navigate().GoToUrl("http://localhost:4200/#/");

        }

        [Test]

        public void validLogin()
        {
            LoginPageObject loginpage = new LoginPageObject();
            loginpage.login("admin@gmail.com", "admin", "Agent");
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(PropertiesCollection.Validateurl("http://localhost:4200/#/dashboard"));
            Console.WriteLine("Valid Login testcase passed");
            PropertiesCollection.Driver.Quit();

        }
        [Test]

        public void invalidlogin()
        {
            LoginPageObject loginpage = new LoginPageObject();
            loginpage.login("ad", "admin", "Agent");
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(PropertiesCollection.Validatemessage("NOT AUTHORIZED", "#toast-container > div > div.toast-title.ng-star-inserted"));
            Console.WriteLine("Invalid Login testcase passed");
            PropertiesCollection.Driver.Quit();

        }





    }
}
