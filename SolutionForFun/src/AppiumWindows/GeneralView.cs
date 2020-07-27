using OpenQA.Selenium.Appium.Windows;

namespace AppiumWindows
{
    public class GeneralView
    {
        private readonly WindowsDriver<WindowsElement> driver;

        public GeneralView(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public WindowsElement Number_0 => this.driver.FindElementByAccessibilityId("num0Button");
        public WindowsElement Number_1 => this.driver.FindElementByAccessibilityId("num1Button");
        public WindowsElement Number_2 => this.driver.FindElementByAccessibilityId("num2Button");
        public WindowsElement Number_3 => this.driver.FindElementByAccessibilityId("num3Button");
        public WindowsElement Number_4 => this.driver.FindElementByAccessibilityId("num4Button");
        public WindowsElement Number_5 => this.driver.FindElementByAccessibilityId("num5Button");
        public WindowsElement Number_6 => this.driver.FindElementByAccessibilityId("num6Button");
        public WindowsElement Number_7 => this.driver.FindElementByAccessibilityId("num7Button");
        public WindowsElement Number_8 => this.driver.FindElementByAccessibilityId("num8Button");
        public WindowsElement Number_9 => this.driver.FindElementByAccessibilityId("num9Button");
        public WindowsElement PlusButton => this.driver.FindElementByAccessibilityId("plusButton");
        public WindowsElement EqualButton => this.driver.FindElementByAccessibilityId("equalButton");
        public WindowsElement ResultTextLabel => this.driver.FindElementByAccessibilityId("CalculatorResults");


    }
}
