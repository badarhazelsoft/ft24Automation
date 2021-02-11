using FT24_Automate.pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace FT24_Automate
{
    class NewServiceRequestScreen
    {

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.Driver = new ChromeDriver();
            PropertiesCollection.Driver.Manage().Window.Maximize();
            PropertiesCollection.Driver.Navigate().GoToUrl("http://localhost:4200/#/");
        }

        [Test]

        public void NewRequest()
        {
            LoginPageObject loginpage = new LoginPageObject();
            loginpage.login("admin@gmail.com", "admin", "Agent");
            System.Threading.Thread.Sleep(3000);
            PropertiesCollection.Driver.Navigate().GoToUrl("http://localhost:4200/#/service/create");
            NewServiceRequestObject SR = new NewServiceRequestObject();
            //Select customer
            SR.DropDown(SR.Customer);
            //Details
            SR.AssetNo.SendKeys("1234");
            SR.SerialNo.SendKeys("34515");
            SR.OwnerCode.SendKeys("qwzz123");
            SR.Firm.SendKeys("1232s4");
            SR.Address.SendKeys("qaswee");
            SR.Area.SendKeys("a12ssd12");
            SR.City.SendKeys("qa12sa");
            SR.Phone.SendKeys("2312333");
            SR.Latitude.SendKeys("70.45");
            SR.Longitude.SendKeys("32.45");
            SR.VatNo.SendKeys("121234");
            SR.DropDown(SR.StoreTypedrpdown);
            SR.DropDown(SR.Prefecturedrpdown);

            //ServiceTYPES
            SR.DropDown(SR.STdrpdown);
            SR.PCategorydrpdown.Click();
            System.Threading.Thread.Sleep(2000);
            SR.Categories.Click();
            SR.DropDown(SR.PConditiondrpdown);
            SR.PD.SendKeys("te12st");
            SR.DropDown(SR.ResponseTimedrpdown);
            SR.Comments.SendKeys("tes12t");
            //ReportedBY

            SR.RName.SendKeys("as12as");
            SR.RRole.SendKeys("teasst");
            SR.RPhone.SendKeys("12121234");
            SR.REmail.SendKeys("teasst@gmail.com");
            SR.DropDown(SR.RAssignedTodrpdown);
            //SAVE
            SR.Savebtn.Click();
            System.Threading.Thread.Sleep(5000);
            Assert.IsTrue(PropertiesCollection.Validateurl("http://localhost:4200/#/service/newservicerequestlist"));
            PropertiesCollection.Driver.Quit();

        }
    }
}
