using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_AppiumSample.PageModel
{
    public class BasePage
    {
        private AppiumDriver<IWebElement> appiumDriver;
        public BasePage(AppiumDriver<IWebElement> appiumDriver)
        {
            this.appiumDriver = appiumDriver;
            PageFactory.InitElements(this.appiumDriver, this);
        }
        public void Wait(int wait)
        {
            appiumDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(wait);           
        }
        public void ClickElement(IWebElement element){
            element.Click();
        }
        public void SetText(IWebElement element,string text){
            element.SendKeys(text);
        }
    }
}
