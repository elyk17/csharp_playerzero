using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Target.PageObjects
{
    public class homePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "search")]
        public IWebElement searchBar { get; set; }

        [FindsBy(How = How.ClassName, Using = "styles__SearchButton - sc - 17dxxwu - 24 hfLkTW")]
        public IWebElement searchButton { get; set; }
    }
}
