using OpenQA.Selenium;
using SeleniumTranslation_MSTestEdition.Phase2;

namespace SeleniumTranslation_MSTestEdition.Phase2
{
    public class HTML_ActionControls 
    {
        private IWebDriver driver;
        TestResultsHandler MyTest;

        // Constructor
        public HTML_ActionControls(IWebDriver webDriver, TestResultsHandler resultsHandler)
        {
            driver = webDriver;
            MyTest = resultsHandler;

        } //end of constructor

        public bool ClickSearchBar(By by)
        {

            try
            {
                driver.FindElement(by).Click();
            }
            catch (Exception ex)
            {
                MyTest.RecordFailure($"HTML ACTION: Automated end user failed to click on the search bar: {ex.Message}");
                return false;
            }
            MyTest.RecordSuccess();
            return true;
        }

        public bool SendKeysToField(By by, string text)
        {
            try
            {
                driver.FindElement(by).SendKeys(text);
            }
            catch (Exception ex)
            {
                MyTest.RecordFailure($"HTML ACTION: Automated end user failed to send keys to the field: {ex.Message}");
                return false;
            }
            MyTest.RecordSuccess();
            return true;
        }
    } //end of class
} //end of namespace
