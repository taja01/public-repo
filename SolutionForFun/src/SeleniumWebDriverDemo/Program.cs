using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebDriverDemo.PageObjects.Google;
using System;
using System.Linq;

namespace SeleniumWebDriverDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--allow-running-insecure-content");
            chromeOptions.AddArgument("--ignore-gpu-blacklist");
            chromeOptions.AcceptInsecureCertificates = true;
            // Disable automation info-bar message
            chromeOptions.AddExcludedArgument("enable-automation");
            // Disable pop up 'Disable developer mode extensions'
            // Disable chrome save your password pop up
            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.SetLoggingPreference("performance", LogLevel.Info);
            var driver = new ChromeDriver(chromeOptions);
            driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            driver.Manage().Window.Maximize();
            var mainPage = new GoogleMainPage(driver);

            driver.Url = "https://www.betsafe.com/en/configuration";
            var performanceLogs = driver.Manage().Logs.GetLog("performance");
            var responseReeivedLog = performanceLogs.Where(log => log.Message.Contains("Network.responseReceived\"")).ToList();

            string jsonFormatted = JValue.Parse(responseReeivedLog.First().Message).ToString(Formatting.Indented);
            Console.WriteLine(jsonFormatted);
            driver.Quit();

            //var driver = new ChromeDriver();
            //driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 10);
            //driver.Manage().Window.Maximize();

            //var mainPage = new GoogleMainPage(driver);
            //mainPage.Load();
            //mainPage.SearchField.SendKeys("42");
            //mainPage.SearchButton.Click();

            //var googleResultPage = new GoogleResultPage(driver);
            //Assert.IsTrue(googleResultPage.IsLoaded(), "Result page not loaded");
            //googleResultPage.Results.First(x => x.GetAttribute("href").Contains("Phrases_from_The_Hitchhiker")).Click();

            //var wikiPage = new WikiPage(driver);

            //StringAssert.Contains("Phrases from The Hitchhiker's Guide to the Galaxy", wikiPage.Header.Text);
            //Assert.Greater(wikiPage.HeadLines_2.Count, 0);
            //Assert.Greater(wikiPage.HeadLines_3.Count, 0);

            //driver.Quit();
        }
    }
}
