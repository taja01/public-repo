using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriverDemo.PageObjects.Google;
using SeleniumWebDriverDemo.PageObjects.Wiki;
using System;
using System.Linq;

namespace SeleniumWebDriverDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            driver.Manage().Window.Maximize();

            var mainPage = new GoogleMainPage(driver);
            mainPage.Load();
            mainPage.SearchField.SendKeys("42");
            mainPage.SearchButton.Click();

            var googleResultPage = new GoogleResultPage(driver);
            Assert.IsTrue(googleResultPage.IsLoaded(), "Result page not loaded");
            googleResultPage.Results.First(x => x.GetAttribute("href").Contains("Phrases_from_The_Hitchhiker")).Click();

            var wikiPage = new WikiPage(driver);

            StringAssert.Contains("Phrases from The Hitchhiker's Guide to the Galaxy", wikiPage.Header.Text);
            Assert.Greater(wikiPage.HeadLines_2.Count, 0);
            Assert.Greater(wikiPage.HeadLines_3.Count, 0);

            driver.Quit();
        }
    }
}
