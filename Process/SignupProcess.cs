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
            // 
        }
    }
}
