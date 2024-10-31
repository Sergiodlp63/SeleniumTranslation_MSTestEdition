using System.Collections.Specialized;


namespace SeleniumTranslation_MSTestEdition.Phase2
{

    /// <summary>
    /// This class is the parent function of phase 2. 'TestResultsHandler' handles and logs all of the HTML Actions that are implemented into 
    /// business use cases in the POM classes. 
    /// </summary>
    public class TestResultsHandler
    {
        // Private fields for keeping track of results and errors
        private int successCount;
        private int failureCount;
        private StringCollection errorLog;

        // Constructor
        public TestResultsHandler()
        {
            errorLog = new StringCollection();
        }

        // Method to record a successful test
        public void RecordSuccess()
        {
            successCount++;
        }

        // Method to record a failed test with an error message
        public void RecordFailure(string errorMessage)
        {
            failureCount++;
            errorLog.Add(errorMessage);
        }

        // Property to get the count of successful tests
        public int MySuccessCount
        {
            get
            {
                return successCount;
            }
        }

        // Property to generate the final results message
        public string MyResultsSummary
        {
            get
            {
                if (failureCount == 0)
                {
                    return null;
                }

                string summaryMessage = $"\r\n\r\n\r\n{failureCount} test(s) failed.";

                if (failureCount > 1) //just keep it this way sergio. you need to capture the entire context of the failed test and not just the inception point. 
                {
                    summaryMessage += " ";
                }

                summaryMessage += $"\r\n\r\n{successCount} test(s) passed. \r\n\r\n";

                summaryMessage += "\r\n\r\nThis Specific Set (of tests) Requires Further QA Inspection: \r\n\r\n\r\n";
                foreach (string errorMessage in errorLog)
                {
                    summaryMessage += errorMessage + "\r\n\r\n";
                }

                return summaryMessage;
            }
        }
    }




} //end of namespace
