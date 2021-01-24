using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_AppiumSample.PageModel
{
    public class LoginPage:BasePage
    {
        private AppiumDriver<IWebElement> appiumDriver;
        public LoginPage(AppiumDriver<IWebElement> appiumDriver):base(appiumDriver) { 
            this.appiumDriver = appiumDriver;
        }

        [FindsBy(How = How.Id, Using = "com.getir.casestudy.dev:id/usernameEditText")]
        public IWebElement txtUserName;

        [FindsBy(How = How.Id, Using = "com.getir.casestudy.dev:id/passwordEditText")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "com.getir.casestudy.dev:id/loginButton")]
        public IWebElement btnSubmit;

        public void SetUserName(string userName)
        {
            SetText(txtUserName, userName);
        }
        public void SetPassword(string password)
        {
            SetText(txtPassword, password);
        }
        public void ClickSubmit()
        {
            ClickElement(btnSubmit);
        }
    }
}
