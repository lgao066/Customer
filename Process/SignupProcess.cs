using Customer.Pages;
using Customer.TestData;
using OpenQA.Selenium;

namespace Customer.Process
{
    public class SignupProcess
    {
        private SignUpPage signupPage;

        public SignupProcess(IWebDriver driver)
        {
            signupPage = new SignUpPage(driver);
        }

        public void FillSignUpForm(CustomerData cust)
        {
            signupPage.FillGeneralInfo(cust);
            signupPage.FillDifferentBillingAddressInfo(cust);
            signupPage.FillAuthorisedSignatoryContact(cust);
            if (!cust.UseSameContact.ToLower().Trim().Equals("yes")) 
            {
                signupPage.TickUseOtherContact();
                signupPage.FillUsageReportContact(cust);
                signupPage.FillSalesCommsContact(cust);
                signupPage.FillAccountsContact(cust);
                signupPage.FillStatementContact(cust);
                signupPage.FillTechnicalContact(cust);
            }

            // For testing only
            Thread.Sleep(5000);
        }
    }
}
