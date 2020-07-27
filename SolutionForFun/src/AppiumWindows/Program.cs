using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Linq;

namespace AppiumWindows
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Before run: C:\Program Files (x86)\Windows Application Driver run WinAppDriver.exe
            WindowsDriver<WindowsElement> driver;

            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            appOptions.AddAdditionalCapability("deviceName", "WindowsPC");
            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            var genView = new GeneralView(driver);

            genView.Number_1.Click();
            genView.PlusButton.Click();
            genView.Number_2.Click();
            genView.PlusButton.Click();
            genView.Number_3.Click();
            genView.EqualButton.Click();

            Assert.AreEqual("6", genView.ResultTextLabel.Text.Split(':').Last().Trim());

            driver.Close();
        }
    }
}
