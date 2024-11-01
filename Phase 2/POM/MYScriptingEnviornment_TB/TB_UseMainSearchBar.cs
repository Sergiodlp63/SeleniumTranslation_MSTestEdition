using OpenQA.Selenium;
using SeleniumTranslation_MSTestEdition.Phase2;


namespace SeleniumTranslation_MSTestEdition.Phase2
{
    public class TB_UseMainSearchBar
    {
        private IWebDriver driver;
        private TestResultsHandler testResultsHandler;
        private HomePage homePage;

        public TB_UseMainSearchBar(IWebDriver webDriver, TestResultsHandler testResultsHandler)
        {
            this.driver = webDriver;
            this.testResultsHandler = new TestResultsHandler();
            this.homePage = new HomePage(driver, testResultsHandler, new HTML_ActionControls(driver, testResultsHandler));
        }

        public void TB_SanityTest01_HomePage(TestResultsHandler ThisTest)
        {
            if (homePage.UseMainSearchBar("spoons") == false)
            {
                testResultsHandler.RecordFailure("TB UseCase: Could not validate the end user actions on the Main Search Bar.");
                return;
            }
            testResultsHandler.RecordSuccess();

            if (homePage.EnsureReturnedTextDisplays("Popular Shopping Ideas", "Cooking") == false)
            {
                testResultsHandler.RecordFailure("TB UseCase: Could not ensure the returned text displayed on the page.");
            }
            testResultsHandler.RecordSuccess();
        }

        public void TB_SanityTest02_HomePage(TestResultsHandler ThisTest)
        {
            if (homePage.UseMainSearchBar("ruffwear treat pouch") == false)
            {
                testResultsHandler.RecordFailure("TB UseCase: Could not validate the end user actions on the Main Search Bar.");
                return;
            }
            testResultsHandler.RecordSuccess();

            if (homePage.EnsureReturnedTextDisplays("Pet Supplies", "Dog Treat Pouches") == false)
            {
                testResultsHandler.RecordFailure("TB UseCase: Could not ensure the returned text displayed on the page.");
            }
            testResultsHandler.RecordSuccess();
        }


        public void TB_SanityTest03_HomePage(TestResultsHandler ThisTest)
        {
            if (homePage.UseMainSearchBar("couch") == false)
            {
                testResultsHandler.RecordFailure("TB UseCase: Could not validate the end user actions on the Main Search Bar.");
                return;
            }
            testResultsHandler.RecordSuccess();

            if (homePage.EnsureReturnedTextDisplays("Living Room", "Sectional") == false)
            {
                testResultsHandler.RecordFailure("TB UseCase: Could not ensure the returned text displayed on the page.");
            }
            testResultsHandler.RecordSuccess();
        }

    } //end of class
} //end of namespace