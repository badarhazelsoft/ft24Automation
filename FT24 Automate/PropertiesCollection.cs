using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FT24_Automate
{
    //enum PropertyType
    //{
    //    Id,
    //    Name,
    //    LinktText,
    //    CssName,
    //    ClassName,
    //    XPath
    //}
    class PropertiesCollection
    {
        public static IWebDriver Driver { get; set; }


        public static Boolean Validateurl(string exp)
        {
            if (Driver.Url == exp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean Validatemessage(String msg, string element)
        {
            if (Driver.FindElement(By.CssSelector(element)).Text == msg)
            {
                return true;

            }
            else
                return false;
        }
    }
}

