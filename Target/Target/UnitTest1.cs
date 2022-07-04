using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Target.PageObjects;
using System.Threading.Tasks;
using System;
using System.Threading;
namespace Target
{
    public class Tests 
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            driver = new ChromeDriver("C:\\SeleniumDrivers\\");
            driver.Navigate().GoToUrl("https://www.target.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            var execu = 
                         "var document = window.document;"
                         + "var head = document.getElementByTagName(\"head\").item(0);"
                         + "var script = document.createElement(\"script\");"
                         + "script.setAttribute(\"type\", \"text/javascript\");"
                         + "script.setAttribute(\"src\", \"https://go.playerzero.ai/record/6274691b00fbad01561df689\");"
                         + "head.appendChild(script);";
            try
            {
                js.ExecuteScript(execu);

            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e);
            }
        }

        [Test]
        public void Target()
        {
           
            IWebElement searchBar = driver.FindElement(By.Id("search"));
            IWebElement searchButton = driver.FindElement(By.CssSelector("button[aria-label=\"go\"]"));
            searchBar.SendKeys("Toilet Paper");
            searchButton.Click();
            //IWebElement charmin = driver.FindElement(By.XPath("//*[contains(., 'Charmin')]"));
            //charmin.Click();
            
        }

        [TearDown]
        public void TearDown()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            TestContext.Out.WriteLine(driver.WindowHandles.Last());
            IWebElement allLinks = driver.FindElement(By.TagName("a"));
            TestContext.Out.WriteLine("This is a test");
            TestContext.Out.WriteLine(allLinks.Text);
            driver.Close();
            driver.Quit();
        }

        
    }
}