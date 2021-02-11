using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace FT24_Automate
{
    class DashboardScreen
    {

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Manage().Window.Maximize();
            PropertiesCollection.Driver.Navigate().GoToUrl("http://localhost:4200/#/");

        }
        [Test]

        public void SideNav()
        {
            LoginPageObject login = new LoginPageObject();
            DashboardPageObject dp = login.login("admin@gmail.com", "admin", "Agent");
            System.Threading.Thread.Sleep(3000);
            dp.NewSR.Click();
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(PropertiesCollection.Validateurl("http://localhost:4200/#/service/create"));
            dp.SR.Click();
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(PropertiesCollection.Validateurl("http://localhost:4200/#/service/newservicerequestlist"));
            dp.Equipments.Click();
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(PropertiesCollection.Validateurl("http://localhost:4200/#/customers/all/equipment"));
            dp.Locations.Click();
            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(PropertiesCollection.Validateurl("http://localhost:4200/#/locations"));
            PropertiesCollection.Driver.Quit();
        }
    }
}
