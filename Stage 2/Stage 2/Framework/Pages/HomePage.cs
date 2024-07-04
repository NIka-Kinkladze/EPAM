using OpenQA.Selenium;

namespace MyFramework.Pages
{
    public class HomePage
    {
        private IWebDriver Webdriver;

        public HomePage(IWebDriver driver)
        {
            Webdriver = driver;
        }

        public void ClickSearchButton()
        {
            // Click on search button
            IWebElement searchButton = Webdriver.FindElement(By.CssSelector(".YSM5S"));
            searchButton.Click();
        }
        public void EnterSearch(string Searchitem)
        {
            // Enter "Google Cloud Platform Pricing Calculator"
            IWebElement searchField = Webdriver.FindElement(By.Id("i5"));
            searchField.SendKeys("Google Cloud Platform Pricing Calculator");
            searchField.SendKeys(Keys.Enter);
        }
        public void ClickCalculatorPage()
        {
            // Click on "Google Cloud Platform Pricing Calculator"
            IWebElement calculatorButton = Webdriver.FindElement(By.ClassName("K5hUy"));
            calculatorButton.Click();
            Thread.Sleep(5000);
        }

        public void ClickAddToEstimate()
        {
            // Click on "Add to estimate"
            IWebElement addToEstimate = Webdriver.FindElement(By.CssSelector(".UywwFc-vQzf8d"));
            addToEstimate.Click();
        }

        public void ComputeEngine()
        {
            // Click on "Compute engine"
            IWebElement computeEngine = Webdriver.FindElement(By.CssSelector(".aHij0b-aGsRMb [data-service-form='8']"));
            computeEngine.Click();
        }
    }
}
