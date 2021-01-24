using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestAutomation_AppiumSample.PageModel;
using TestAutomation_AppiumSample.Utilities;

namespace TestAutomation_AppiumSample.Test
{
    [Binding, Scope(Feature = "TestAutomationAppium")]
    public class TestSteps
    {
        public static AppiumDriver<IWebElement> appiumDriver { get; set; }
        public LoginPage loginPage;
        public BasketPage basketPage;

        public BrowserUtilities browserUtilities;

        public TestSteps()
        {
            browserUtilities = new BrowserUtilities();
        }
        [AfterScenario]
        public void AfterSecenario()
        {
            browserUtilities.TearDown();
        }
        [StepDefinition("Getir uygulamasının giriş sayfası açılır")]
        public void OpenBrowser(){
            appiumDriver=browserUtilities.SetupAppiumDriver();
            loginPage = new LoginPage(appiumDriver);
            basketPage = new BasketPage(appiumDriver);
        }
        [StepDefinition("Kullanıcı adı '(.*)' olarak girilir")]
        public void SetUserName(string userName)
        {
            loginPage.SetUserName(userName);
        }
        [StepDefinition("Şifre '(.*)' olarak girilir")]
        public void SetPassword(string password)
        {
            loginPage.SetPassword(password);
        }
        [StepDefinition("Submit butonuna tıklanır")]
        public void ClickToSubmit()
        {            
            loginPage.ClickSubmit();            
        }
        [StepDefinition("'(.*)' Kategorisine tıklanır")]
        public void ClickCatogories(string categoryName)
        {
            basketPage.ClickCategory(categoryName);
        }
        [StepDefinition("Anasayfa butonuna tıklanır")]
        public void ClickToHomePage()
        {
            basketPage.ClickToHomePage();
        }
        [StepDefinition("İki farklı ürün eklenir")]
        public void ClickToTwoProduct()
        {
            basketPage.ClickToTwoProduct();
        }
        [StepDefinition("Bir ürün eklenir")]
        public void ClickToOneProduct()
        {
            basketPage.ClickToOneProduct();
        }
        [StepDefinition("Sepete gidilir")]
        public void ClickToBasket()
        {
            basketPage.ClickToBasket();
        }
        [StepDefinition("Sepetteki ürünler silinir")]
        public void ClickToDeleteBasketButton()
        {
            basketPage.ClickToDeleteBasketButton();
        }
        [StepDefinition("Sepet kontrol edilir")]
        public void CheckBasket()
        {
            basketPage.CheckBasket();
        }
        [StepDefinition("Kategori sayısı kontrol edilir")]
        public void CheckCategory()
        {
            basketPage.CheckCategory();
        }
        [StepDefinition("Atıştırmalık Kategorisinde iki farklı üründen ikişer tane eklenir")]
        public void ClickSnackProduct()
        {
            basketPage.ClickSnackProduct();
        }
        [StepDefinition("Yiyecek Kategorisinde bir üründen 3 adet eklenir")]
        public void ClickFoodProduct()
        {
            basketPage.ClickFoodProduct();
        }
        [StepDefinition("Sepetteki ürünler bir adet arttırılır")]
        public void ClickAddProductBasket()
        {
            basketPage.ClickAddProductBasket();
        }
        [StepDefinition("Sepetteki ürünlerin arttığı kontrol edilir")]
        public void CheckProductCount()
        {
            basketPage.CheckProductCount();
        }
    }
}