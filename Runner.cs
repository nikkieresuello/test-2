using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace test.Runner
{
    class Run
    {
        private IWebDriver driver;
        Utilities _utils;
        String tagname = "tag-main-tab";

        public Run()
        {
            _utils = new Utilities();
        }

        public void ClickElementWithShadowRootUsingLink()
        {
            var links = _utils.GetRoot(driver, tagname).FindElements(By.CssSelector("a"));
            util.jsClickelement(links[0],driver);
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
