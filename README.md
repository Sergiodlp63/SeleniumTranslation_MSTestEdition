There is a linear parent child relationship between 
1) P - TestResultsHandler
2) C - HTMLActionControls
3) C - HomePage

The 'TestBuilder_RegressionTC001' class should be decoupled by design from that linear relationship for the sake of reusability and TDD objectives/requirements. 

For the purposes of this test suite, the 3 phases to automation are as follows.


1) Phase 1: Navigate to URL 

2) Phase 2: Click and send keys to the Nth degree.
Note: Once an 'expected behavior' has occured by completing step 2 a 'ensure' type method needs to be implemented. 

3) Phase 3: Implement: Assertion to complete the test. 
