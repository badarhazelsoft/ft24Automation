using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;
namespace FT24_Automate
{

    class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/app-login/div/main/div/div/div[2]/div/div/div/form/div[2]/input")]
        public IWebElement Uname { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-login/div/main/div/div/div[2]/div/div/div/form/div[3]/input")]
        public IWebElement Upassword { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/app-login/div/main/div/div/div[2]/div/div/div/form/div[4]/select")]
        public IWebElement UserType { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/app-login/div/main/div/div/div[2]/div/div/div/form/div[5]/div[1]/button")]
        public IWebElement loginbtn { get; set; }


        public DashboardPageObject login(string username, string password, string utype)
        {
            Uname.SendKeys(username);
            Upassword.SendKeys(password);
            DropDown(UserType, utype);
            System.Threading.Thread.Sleep(2000);
            loginbtn.Submit();

            return new DashboardPageObject();

        }
        public void DropDown(IWebElement a, string txt)
        {
            SelectElement drop = new SelectElement(a);
            drop.SelectByText(txt);
        }

    }
}


