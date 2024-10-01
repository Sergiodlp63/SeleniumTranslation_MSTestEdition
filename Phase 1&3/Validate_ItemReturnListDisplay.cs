using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTranslation_MSTestEdition.Phase2;

namespace SeleniumTranslation_MSTestEdition
{
    [TestClass]
    public class Validate_ItemReturnListDisplay
    {

        // Declare WebDriver as a private field
        private IWebDriver Mydriver;

        [TestInitialize]
        public void Setup()
        {
            // Initialize the ChromeDriver
            Mydriver = new ChromeDriver();

        }
        
        [TestMethod]
        public void IRLDisplays_Parameter001()
        {
            // Navigate to the desired URL
            Mydriver.Navigate().GoToUrl("https://www.amazon.com/"); // This is the application under test

            // Initialize test result handler and test case objects
            var MyTestHandler = new TestResultsHandler();
            var LocalTestInstance = new TB_UseMainSearchBar(Mydriver, MyTestHandler);

            // Run test actions
            LocalTestInstance.TB_SanityTest01_HomePage(MyTestHandler);

            // Check test results and assert(s) if needed
            if (MyTestHandler.MyResultsSummary != null)
            {
                Assert.Fail(MyTestHandler.MyResultsSummary);
            }
            else
            {
                TestContext.WriteLine(
                    $"{MyTestHandler.MySuccessCount} successful testable actions!"
                );
            }
        }

        [TestMethod]
        public void IRLDisplays_Parameter002()
        {
            // Navigate to the desired URL
            Mydriver.Navigate().GoToUrl("https://www.amazon.com/"); // This is the application under test

            // Initialize test result handler and test case objects
            var MyTestHandler = new TestResultsHandler();
            var LocalTestInstance = new TB_UseMainSearchBar(Mydriver, MyTestHandler);

            // Run test actions
            LocalTestInstance.TB_SanityTest02_HomePage(MyTestHandler);

            // Check test results and assert(s) if needed
            if (MyTestHandler.MyResultsSummary != null)
            {
                Assert.Fail(MyTestHandler.MyResultsSummary);
            }
            else
            {
                TestContext.WriteLine(
                    $"{MyTestHandler.MySuccessCount} successful testable actions!"
                );
            }
        }

        [TestMethod]
        public void IRLDisplays_Parameter003()
        {
            // Navigate to the desired URL
            Mydriver.Navigate().GoToUrl("https://www.amazon.com/"); // This is the application under test

            // Initialize test result handler and test case objects
            var MyTestHandler = new TestResultsHandler();
            var LocalTestInstance = new TB_UseMainSearchBar(Mydriver, MyTestHandler);

            // Run test actions
            LocalTestInstance.TB_SanityTest03_HomePage(MyTestHandler);

            // Check test results and assert(s) if needed
            if (MyTestHandler.MyResultsSummary != null)
            {
                Assert.Fail(MyTestHandler.MyResultsSummary);
            }
            else
            {
                TestContext.WriteLine(
                    $"{MyTestHandler.MySuccessCount} successful testable actions confirmed.!"
                );
            }
        }

        public TestContext TestContext { get; set; }

        [TestCleanup]
        public void Teardown()
        { 
            Mydriver.Quit();
        }

    } //end of class
}// end of namespace