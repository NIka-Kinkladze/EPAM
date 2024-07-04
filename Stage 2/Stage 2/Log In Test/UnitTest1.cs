using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Log_in_test
{
    public class Tests
    {
        private IWebDriver Webdriver { get; set; }
        private string BaseUrl1 { get; set; } = "https://proton.me/";
        private string BaseUrl2 { get; set; } = "https://www.yahoo.com/";

        

        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            Webdriver = new ChromeDriver();
            Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void LogInToProtonmail()
        {
            Webdriver.Navigate().GoToUrl(BaseUrl1);

            // Navigate and click on Sign in button
            IWebElement element = Webdriver.FindElement(By.XPath("//a[contains(@href, 'https://account.proton.me/login')]"));
            element.Click();

            // Empty input and verification
            var mailinput = Webdriver.FindElement(By.Id("username"));
            mailinput.SendKeys("");
            var signinbutton = Webdriver.FindElement(By.XPath("//button[contains(text(), 'Sign in')]"));
            signinbutton.Click();
            var errorMessage = Webdriver.FindElement(By.Id("id-3"));
            Assert.AreEqual("This field is required", errorMessage.Text);
            var passwordinput = Webdriver.FindElement(By.Id("password"));
            passwordinput.SendKeys("");
            errorMessage = Webdriver.FindElement(By.Id("id-4"));
            Assert.AreEqual("This field is required", errorMessage.Text);

            // Correct Input 
            mailinput = Webdriver.FindElement(By.Id("username"));
            mailinput.SendKeys("testsepam@proton.me");
            passwordinput = Webdriver.FindElement(By.Id("password"));
            passwordinput.SendKeys("testforepam");
            mailinput = Webdriver.FindElement(By.XPath("//button[contains(text(), 'Sign in')]"));
            signinbutton.Click();
            Thread.Sleep(10000);
        }

        [Test]
        public void YahooMail()
        {
            Webdriver.Navigate().GoToUrl(BaseUrl2);

            //Click on sign in button
            IWebElement submitBtn = Webdriver.FindElement(By.CssSelector("a[data-ylk='sec:ybar;slk:sign-in;elm:signin;subsec:settings;itc:0;tar:login.yahoo.com']"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Enter empty E-mail
            var input = Webdriver.FindElement(By.Id("login-username"));
            input.Clear();
            input.SendKeys("");

            //Click next
            submitBtn = Webdriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Validate login failure
            var errorMsg = Webdriver.FindElement(By.Id("username-error")).Text;
            Assert.AreEqual("Sorry, we don't recognize this email.", errorMsg);

            //Enter wrong E-mail
            input = Webdriver.FindElement(By.Id("login-username"));
            input.Clear();
            input.SendKeys("wrong mail");

            //Click next
            submitBtn = Webdriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Validate login failure
            errorMsg = Webdriver.FindElement(By.Id("username-error")).Text;
            Assert.AreEqual("Sorry, we don't recognize this account.", errorMsg);

            //Enter E-mail
            input = Webdriver.FindElement(By.Id("login-username"));
            input.Clear();
            input.SendKeys("epam.t@yahoo.com");

            //Click next
            submitBtn = Webdriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Enter password
            input = Webdriver.FindElement(By.Id("login-passwd"));
            input.Clear();
            input.SendKeys("wrongpassword");

            //click next
            submitBtn = Webdriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Validate login failure
            errorMsg = Webdriver.FindElement(By.CssSelector(".error-msg")).Text;
            Assert.AreEqual("Invalid password. Please try again", errorMsg);

            //Enter wrong password
            input = Webdriver.FindElement(By.Id("login-passwd"));
            input.Clear();
            input.SendKeys("");

            //click next
            submitBtn = Webdriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);

            //Validate login failure
            errorMsg = Webdriver.FindElement(By.CssSelector(".error-msg")).Text;
            Assert.AreEqual("Please provide password.", errorMsg);

            //Enter Correct password
            input = Webdriver.FindElement(By.Id("login-passwd"));
            input.Clear();
            input.SendKeys("secondtestmail");

            //click next
            submitBtn = Webdriver.FindElement(By.Id("login-signin"));
            submitBtn.Click();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
            Webdriver.Quit();
        }
    }
}