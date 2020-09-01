using ClassicSelenium.FrameworkCore.Configurations;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace ClassicSelenium.Hooks
{
    [Binding]
    class BeforeAfterTestRun
    {
        [BeforeTestRun]
        public static void Setup()
        {
            Debug.WriteLine(SettingsManager.Browser);
            Debug.WriteLine(SettingsManager.Device);
            Debug.WriteLine(SettingsManager.Environment);
        }
    }
}
