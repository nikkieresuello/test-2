using OpenQA.Selenium;

namespace test.Helpers
{
    class Utilities
    {
        public IWebElement GetRoot(IWebDriver driver, params string[] selectors)
        {
            var root = (IWebElement)((IJavaScriptExecutor)driver).ExecuteScript("return document");
            foreach (var selector in selectors)
            {
                root = (IWebElement)((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].querySelector(arguments[1]).shadowRoot", root, selector);
            }
            return root;
        }

        public void jsClickelement(IWebElement element, IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);
        }
    }
}
