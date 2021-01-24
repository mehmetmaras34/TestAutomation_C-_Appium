using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_AppiumSample.Utilities
{
    public class BrowserUtilities
    {
        public AppiumDriver<IWebElement> appiumDriver;
        public AppiumDriver<IWebElement> SetupAppiumDriver()
        {
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("platformName", "Android");
            appiumOptions.AddAdditionalCapability("deviceName", "emulator-5554");
            appiumOptions.AddAdditionalCapability("version", "5.1.1");
            appiumOptions.AddAdditionalCapability("appPackage", "com.getir.casestudy.dev");
            appiumOptions.AddAdditionalCapability("appActivity", "com.getir.casestudy.modules.login.ui.LoginActivity");

            appiumDriver = new AndroidDriver<IWebElement>(new Uri("http://localhost:4723/wd/hub"), appiumOptions);
            return appiumDriver;
        }
        public void TearDown()
        {
            appiumDriver.Quit();
        }
    }
}
