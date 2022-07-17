using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

const string Url = @"https://www.target.com";

using var driver = new ChromeDriver();
driver.Navigate().GoToUrl(Url);

var script = @"let script = document.createElement('script');
              script.type = 'text/javascript';
              script.src = 'https://go.playerzero.ai/record/6274691b00fbad01561df689';
              document.head.appendChild(script);
              return script.src;";

var js = (IJavaScriptExecutor)driver;
var src = js.ExecuteScript(script).ToString();
IWebElement searchBar = driver.FindElement(By.Id("search"));
IWebElement searchButton = driver.FindElement(By.CssSelector("button[aria-label='go']"));
searchBar.SendKeys("Toilet Paper");
searchButton.Click();
Thread.Sleep(3000);
IWebElement charmin = driver.FindElement(By.LinkText("Charmin Ultra Strong Toilet Paper"));
charmin.Click();
Console.WriteLine(src);