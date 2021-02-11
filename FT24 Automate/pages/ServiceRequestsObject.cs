using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace FT24_Automate.pages
{
    class ServiceRequestsObject
    {
        public ServiceRequestsObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-new-service-request-list/div/div/div/div/div[1]/div/div[2]/app-toolbar/div/div[1]/div[2]/button")]
        public IWebElement Filterbutton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='status']/div[3]/div/div/select")]
        public IWebElement Statusdrpdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='condition']/select")]
        public IWebElement Gatesdrpdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='formarray']/div[2]/div[1]/div[1]/select")]
        public IWebElement clmdrpdown { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='formarray']/div[2]/div[1]/div[3]/div/div[1]/select")]
        public IWebElement conditiondrpdown { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='value']/select")]
        public IWebElement conditionvaluedrpdown { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-new-service-request-list/div/div/div/div/div[2]/app-filter/form/div/div[5]/div[1]/input")]
        public IWebElement Searchbtn { get; set; }

        //EDITTTTTTTTTTTTTTTTTT

        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-new-service-request-list/div/div/div/div/app-generic-list/div[1]/div/table/tbody/tr[1]")]
        public IWebElement row { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-new-service-request-list/div/div/div/div/div[1]/div/div[2]/app-toolbar/div/div[2]/div[1]/button")]
        public IWebElement Actionsbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-dashboard/div/main/div/app-new-service-request-list/div/div/div/div/div[1]/div/div[2]/app-toolbar/div/div[2]/div[1]/ul/li[1]/a")]
        public IWebElement Editbtn { get; set; }



        public void DropDown(IWebElement a, string index)
        {
            SelectElement drop = new SelectElement(a);
            drop.SelectByText(index);
        }
        public void Filtercrt(string gate, string clm, string condition, string value)
        {
            DropDown(Gatesdrpdown, gate);
            DropDown(clmdrpdown, clm);
            DropDown(conditiondrpdown, condition);
            System.Threading.Thread.Sleep(2000);
            DropDown(conditionvaluedrpdown, value);
        }






    }
}
