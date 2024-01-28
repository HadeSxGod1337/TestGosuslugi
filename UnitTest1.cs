using NuGet.Frameworks;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;


namespace TestGosuslugi
{
    [TestFixture]
    public class ChangePasswordTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        }
        
        public IWebElement WaitFindElement(By by, bool clicked = false)
        {

            IWebElement element = wait.Until(driver => driver.FindElement(by));
            if (clicked) element.Click();
            return element;
        } 


        [Test]
        public void OpenChangePasswordFormTest()
        {
            driver.Navigate().GoToUrl("https://www.gosuslugi.ru");
            WaitFindElement(By.ClassName("login-button"), true);
            WaitFindElement(By.XPath("//button[text()=\" Не удаётся войти? \"]"), true);
            WaitFindElement(By.XPath("//button[text()=\" восстановления пароля \"]"), true); 
            Assert.IsTrue(WaitFindElement(By.TagName("esia-recovery")).Displayed);
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}