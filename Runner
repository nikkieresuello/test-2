using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace test.Runner
{
    class Run
    {
        private IWebDriver driver;
        Helpers.Utilities _utils;
        String tagname = "tag-main-tab";

        public Run()
        {
            _utils = new Helpers.Utilities();
        }

        public void ClickElementWithShadowRootUsingLink()
        {
            var links = _utils.GetRoot(driver, tagname).FindElements(By.CssSelector("a"));
        }

        public void Setup()
        {
            driver = new ChromeDriver();
        }
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
