using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace Target.PageObjects
{
    public class resultsPage
    {
        private IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//*[contains(., 'Charmin')]")]
        public IWebElement charmin;
    }
}
