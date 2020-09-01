using ClassicSelenium.FrameworkCore.Configurations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;

namespace ClassicSelenium.FrameworkCore.WebDriver
{
    class DriverSingleton
    {
        private static IWebDriver driver;

        private static string useBrowser = "Chrome";

        private DriverSingleton()
        {

        }

        public void SetBrowserUsage(Browser brower)
        {
            useBrowser = brower switch
            {
                Browser.Chrome => "FireFox",
                Browser.FireFox => "FireFox",
                Browser.Remote => "Remote",
                Browser.Phantom => "Phantom",
                _ => "Chrome",
            };
        }


        public static IWebDriver Driver
        {
            //Use Selenium Grid
            //get { return driver ?? (driver = new RemoteWebDriver(new Uri("http://192.168.134.247:4444/wd/hub"), DesiredCapabilities.Chrome())); }

            //Use CRS Selenium Grid
            //get { return driver ?? (driver = new RemoteWebDriver(new Uri("http://192.168.225.127:4444/wd/hub"), DesiredCapabilities.Chrome())); }

            //Use local browser
            //get { return driver ?? (driver = new ChromeDriver()); }

            //get { return driver ?? (driver = new PhantomJSDriver()); }
            get { return driver ??= GetDriverFromConfig(); }

            set { driver = value; }
        }

        private static IWebDriver GetDriverFromConfig()
        {
            IWebDriver baseDriver;
            try
            {
                Console.WriteLine("From properties we will use WebDriver: " + useBrowser);

                if (string.IsNullOrEmpty(useBrowser))
                {
                    Console.WriteLine("driverProperty is Empty we will use CRS Grid by defautl");
                    useBrowser = "crsgrid";
                }

                baseDriver = (useBrowser.ToLower()) switch
                {
                    //Use local browser
                    "local" => new ChromeDriver(),
                    //Use CRS Selenium Grid
                    "crsgrid" => new RemoteWebDriver(new Uri("http://192.168.225.127:4444/wd/hub"),
                                                new ChromeOptions()),
                    //Use Selenium Grid
                    "betssongrid" => new RemoteWebDriver(new Uri("http://192.168.134.247:4444/wd/hub"),
                                                new ChromeOptions()),
                    //Use PhantomJS browser
                    /*case "phantomjs":
                                            baseDriver = new PhantomJSDriver();
                                            break;*/
                    _ => new ChromeDriver(),
                };
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                baseDriver = new ChromeDriver();
            }

            return baseDriver;

        }
    }
}
