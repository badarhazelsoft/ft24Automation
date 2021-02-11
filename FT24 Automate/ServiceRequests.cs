using System;
using System.Collections.Generic;
using System.Text;
using FT24_Automate.pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace FT24_Automate
{
    class ServiceRequests
    {

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Manage().Window.Maximize();
            PropertiesCollection.Driver.Navigate().GoToUrl("http://localhost:4200/#/");
        }
        [Test]
        public void FilterRequest()
        {
            LoginPageObject loginpage = new LoginPageObject();
            loginpage.login("admin@gmail.com", "admin", "Agent");
            System.Threading.Thread.Sleep(3000);
            PropertiesCollection.Driver.Navigate().GoToUrl("http://localhost:4200/#/service/newservicerequestlist");
            ServiceRequestsObject sr = new ServiceRequestsObject();
            System.Threading.Thread.Sleep(2000);
            sr.Filterbutton.Click();
            System.Threading.Thread.Sleep(1000);
            sr.DropDown(sr.Statusdrpdown, "Active");
            sr.Filtercrt("AND", "Request Status", "Equals To", "Open");
            System.Threading.Thread.Sleep(2000);
            sr.Searchbtn.Click();
            Console.WriteLine("Active Passed");
            System.Threading.Thread.Sleep(2000);
            //////Editttt
            sr.row.Click();
            sr.Actionsbtn.Click();
            sr.Editbtn.Click();

            // PropertiesCollection.Driver.Quit();
        }
    }
}
