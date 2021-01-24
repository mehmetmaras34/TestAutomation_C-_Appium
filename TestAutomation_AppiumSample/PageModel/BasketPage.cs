using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_AppiumSample.PageModel
{
    public class BasketPage : BasePage
    {
        private AppiumDriver<IWebElement> appiumDriver;

        public BasketPage(AppiumDriver<IWebElement> appiumDriver) : base(appiumDriver)
        {
            this.appiumDriver = appiumDriver;
        }

        [FindsBy(How = How.XPath, Using = "//android.widget.FrameLayout/android.widget.TextView")]
        public IList<IWebElement> categoriList;

        [FindsBy(How = How.Id, Using = "com.getir.casestudy.dev:id/ga_toolbar_leftIconImageView")]
        public IWebElement btnHomePage;

        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout/android.widget.ImageView")]
        public IList<IWebElement> addImageList;

        [FindsBy(How = How.XPath, Using = "//android.widget.FrameLayout/android.widget.TextView[@text='Atıştırmalık']")]
        public IWebElement ClickCategory1;

        [FindsBy(How = How.Id, Using = "com.getir.casestudy.dev:id/ga_toolbar_getir10GABasketButton")]
        public IWebElement btnBasket;

        [FindsBy(How = How.Id, Using = "com.getir.casestudy.dev:id/ga_toolbar_getir10GABasketButton[1]")]
        public IWebElement btnDeleteBasket;

        [FindsBy(How = How.Id, Using = "com.getir.casestudy.dev:id/btnAdd")]
        public IList<IWebElement> btnPlus;

        [FindsBy(How = How.XPath, Using = "//android.widget.LinearLayout/android.widget.TextView")]
        public IList<IWebElement> txtProductCount;

        public void ClickCategory(string categoryName)
        {
            Wait(20);
            TouchAction action = new TouchAction(appiumDriver);
            action.Press(1106, 1756);
            action.MoveTo(1118, 925);
            action.Release();
            action.Perform();
            Wait(20);  
            
            foreach (var i in categoriList)
            {
                Wait(10);
                if (i.Text == categoryName)
                {
                    Wait(2);
                    i.Click();
                }
            }
            Wait(50);
        }
        public void ClickToHomePage()
        {
            ClickElement(btnHomePage);
            Wait(5);
        }

        public void ClickToTwoProduct()
        {
            Wait(5);
            ClickElement(addImageList[1]);
            Wait(5);
            ClickElement(addImageList[2]);
        }
        public void ClickToOneProduct()
        {
            Wait(5);
            ClickElement(addImageList[1]);
        }
        public void ClickToBasket()
        {
            Wait(5);
            ClickElement(btnBasket);
        }
        public void ClickToDeleteBasketButton()
        {
            Wait(5);
            while (btnDeleteBasket.Enabled)
            {
                Wait(5);
                ClickElement(btnDeleteBasket);
            }
        }
        public void CheckBasket()
        {
            Wait(5);
            if (btnDeleteBasket.Enabled)
            {
                Console.WriteLine("Sepette Ürün Var!");
            }
            Wait(2);
        }
        public void ClickSnackProduct()
        {
            Wait(2);
            ClickElement(addImageList[1]);
            Wait(2);
            ClickElement(addImageList[1]);
            Wait(2);
            ClickElement(addImageList[2]);
            Wait(2);
            ClickElement(addImageList[2]);
        }
        public void ClickFoodProduct()
        {
            Wait(5);
            ClickElement(addImageList[1]);
            Wait(2);
            ClickElement(addImageList[1]);
            Wait(2);
            ClickElement(addImageList[1]);
            Wait(6);
        }
        public void CheckCategory()
        {
            Wait(20);
            TouchAction action = new TouchAction(appiumDriver);
            action.Press(1106, 1756);
            action.MoveTo(1118, 925);
            action.Release();
            action.Perform();
            Wait(20);

         
            Console.WriteLine(categoriList.Count() + " sayısı kadar kategori vardır.");
            Wait(2);
        }
        public void ClickAddProductBasket()
        {
            Wait(5);
            ClickElement(addImageList[1]);
            Wait(2);
            ClickElement(addImageList[1]);
            Wait(2);
            ClickElement(addImageList[1]);
            Wait(6);
        }
        public void ClickToPlusProductBasket()
        {
            TouchAction action = new TouchAction(appiumDriver);
            action.Press(1106, 1756);
            action.MoveTo(1118, 925);
            action.Release();
            action.Perform();
            Wait(20);

            for (int i = 0; i < btnPlus.Count; i++)
            {
                Wait(3);
                btnPlus[i].Click();
            }
        }
        public void CheckProductCount()
        {
            Wait(5);
            Assert.IsTrue(!txtProductCount[0].Text.Contains("3"), "Ürün sayısı yanlıştı");
            Assert.IsTrue(!txtProductCount[1].Text.Contains("3"), "Ürün sayısı yanlıştı");
            Assert.IsTrue(!txtProductCount[3].Text.Contains("4"), "Ürün sayısı yanlıştı");
        }

    }
}
