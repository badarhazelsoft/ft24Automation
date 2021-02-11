using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace FT24_Automate.pages
{
    class NewServiceRequestObject
    {
        public NewServiceRequestObject()
        {
            // comment add
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        //Select Customer
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[1]/div[2]/div[2]/select")]
        public IWebElement Customer { get; set; }
        //Details

        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[2]/div[2]/div[2]/input")]
        public IWebElement AssetNo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[2]/div[3]/div[2]/input")]
        public IWebElement SerialNo { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[2]/div[2]/input")]
        public IWebElement OwnerCode { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[3]/div[2]/input")]
        public IWebElement Firm { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[4]/div[2]/input")]
        public IWebElement Address { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[5]/div[2]/input")]
        public IWebElement Area { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[6]/div[2]/input")]
        public IWebElement City { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[7]/div[2]/input")]
        public IWebElement Phone { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[8]/div[2]/input")]
        public IWebElement VatNo { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[9]/div[2]/select")]
        public IWebElement StoreTypedrpdown { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[10]/div[2]/input")]
        public IWebElement Longitude { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[11]/div[2]/input")]
        public IWebElement Latitude { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[3]/div[13]/div[2]/select")]
        public IWebElement Prefecturedrpdown { get; set; }

        //
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[4]/div[2]/div[2]/select")]
        public IWebElement STdrpdown { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[4]/div[3]/div[2]/ng-multiselect-dropdown/div/div[1]/span")]
        public IWebElement PCategorydrpdown { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[4]/div[4]/div[2]/select")]
        public IWebElement PConditiondrpdown { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[4]/div[3]/div[2]/ng-multiselect-dropdown/div/div[2]/ul[2]/li[1]")]
        public IWebElement Categories { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[4]/div[5]/div[2]/textarea")]
        public IWebElement PD { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[4]/div[6]/div[2]/textarea")]
        public IWebElement Comments { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[4]/div[7]/div[2]/select")]
        public IWebElement ResponseTimedrpdown { get; set; }

        //ReportedBy
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[5]/div[2]/div[2]/input")]
        public IWebElement RName { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[5]/div[3]/div[2]/input")]
        public IWebElement RRole { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[5]/div[4]/div[2]/input")]
        public IWebElement RPhone { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[5]/div[5]/div[2]/input")]
        public IWebElement REmail { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[5]/div[6]/div[2]/select")]
        public IWebElement RAssignedTodrpdown { get; set; }
        //SAVE
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-service-request-header/div/div/div/div/div[2]/app-new-static-service-request/div/div/form/div[6]/div[1]/input")]
        public IWebElement Savebtn { get; set; }



        public void DropDown(IWebElement a)
        {
            SelectElement drop = new SelectElement(a);
            drop.SelectByIndex(1);
        }
        //public void StoreTypeDropDown()
        //{
        //    SelectElement drop = new SelectElement(Customer);
        //    drop.SelectByIndex(1);
        //}
        //public void CustomerDropDown()
        //{
        //    SelectElement drop = new SelectElement(Customer);
        //    drop.SelectByIndex(1);
        //}
        //public void CustomerDropDown()
        //{
        //    SelectElement drop = new SelectElement(Customer);
        //    drop.SelectByIndex(1);
        //}
        //public void CustomerDropDown()
        //{
        //    SelectElement drop = new SelectElement(Customer);
        //    drop.SelectByIndex(1);
        //}
    }
}
