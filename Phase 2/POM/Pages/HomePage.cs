using OpenQA.Selenium;
using SeleniumTranslation_MSTestEdition.Phase2;

namespace SeleniumTranslation_MSTestEdition.Phase2
{
    public class HomePage
    {
        private TestResultsHandler ThisTest;
        private HTML_ActionControls MyTest;
        private IWebDriver driver;

        public HomePage(IWebDriver webDriver, TestResultsHandler UseThisTest, HTML_ActionControls UseMyTest)
        {
            this.driver = webDriver;
            this.ThisTest = UseThisTest;
            this.MyTest = UseMyTest;

        } //end of constructor


        public bool UseMainSearchBar(string MyKeysSent)
        {


            if (MyTest.ClickSearchBar(By.Id("twotabsearchtextbox")) == false ||
                MyTest.SendKeysToField(By.Id("twotabsearchtextbox"), MyKeysSent) == false ||
                MyTest.SendKeysToField(By.Id("twotabsearchtextbox"), Keys.Enter) == false)
            {
                ThisTest.RecordFailure("POM UseCase: Could not find MainSearchBar. ");
                return false;
            }
            ThisTest.RecordSuccess();
            return true;
        }

        public bool EnsureReturnedTextDisplays(string expectedText1, string expectedText2)
        {
            string MyPageBody = driver.PageSource;


            if (MyPageBody.Contains(expectedText1) && MyPageBody.Contains(expectedText2) == true)
            {
                ThisTest.RecordSuccess();
                return true;
            }
            else
            {
                ThisTest.RecordFailure("Expected text not found in the page source.");
                return false;
            }
        }

    } //end of class 
} //end of namespace
