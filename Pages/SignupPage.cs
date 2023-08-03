using Customer.TestData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Customer.Pages
{
    public class SignUpPage
    {
        private readonly IWebDriver driver;
        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region General info
        // Web Elements
        private IWebElement BusinessName_text => driver.FindElement(By.Id("CustomerName"));
        private IWebElement LegalEntityId_text => driver.FindElement(By.Id("RegistrationNumber"));
        private IWebElement AddressLine1_text => driver.FindElement(By.Id("Street1"));
        private IWebElement AddressLine2_text => driver.FindElement(By.Id("Street2"));
        private IWebElement AddressLine3_text => driver.FindElement(By.Id("Street3"));
        private IWebElement City_text => driver.FindElement(By.Id("City"));
        private IWebElement State_text => driver.FindElement(By.Id("State"));
        private IWebElement Country_dropdown => driver.FindElement(By.Id("Country"));
        private IWebElement PostCode_text => driver.FindElement(By.Id("Postcode"));
        private IWebElement MainPhone_text => driver.FindElement(By.Id("MainPhone"));
        private IWebElement Fax_text => driver.FindElement(By.Id("Fax"));
        private IWebElement Website_text => driver.FindElement(By.Id("WebUrl"));
        private IWebElement Email_text => driver.FindElement(By.Id("Email"));
        private IWebElement HearAbtRhipe_dropdown => driver.FindElement(By.Id("Source"));
        private IWebElement HearAbtRhipeOther_text => driver.FindElement(By.Id("OtherSource"));
        private IWebElement Industry_dropdown => driver.FindElement(By.Id("IndustryType"));
        
        // Web Actions
        public void FillGeneralInfo(CustomerData cust)
        {
            BusinessName_text.SendKeys(cust.BusinessEntityName);
            LegalEntityId_text.SendKeys(cust.LegalEntityId);
            AddressLine1_text.SendKeys(cust.AddrLine1);
            AddressLine2_text.SendKeys(cust.AddrLine2);
            AddressLine3_text.SendKeys(cust.AddrLine3);
            City_text.SendKeys(cust.City);
            State_text.SendKeys(cust.State);
            Country_dropdown.SendKeys(cust.Country);
            PostCode_text.SendKeys(cust.PostCode);
            MainPhone_text.SendKeys(cust.MainPhone);
            Fax_text.SendKeys(cust.Fax);
            Website_text.SendKeys(cust.Website);
            Email_text.SendKeys(cust.Email);
            HearAbtRhipe_dropdown.SendKeys(cust.Source);
            if (cust.Source.ToLower().Trim().Contains("others")) 
            {
                HearAbtRhipeOther_text.SendKeys(cust.OtherSource);
            }
            Industry_dropdown.SendKeys(cust.IndustryType);
            PageScroll(Industry_dropdown);
        }

        #endregion

        #region Different billing address info
        // Web Elements
        private IWebElement UseDifferentAddressForBilling_tick => driver.FindElement(By.Id("useanotheraddress"));
        private IWebElement BillingAddressLine1_text => driver.FindElement(By.Id("BillingAddressLine1"));
        private IWebElement BillingAddressLine2_text => driver.FindElement(By.Id("BillingAddressLine2"));
        private IWebElement BillingAddressLine3_text => driver.FindElement(By.Id("BillingAddressLine3"));
        private IWebElement BillingCity_text => driver.FindElement(By.Id("BillingCity"));
        private IWebElement BillingState_text => driver.FindElement(By.Id("BillingState"));
        private IWebElement BillingCountry_dropdown => driver.FindElement(By.Id("BillingCountry"));
        private IWebElement BillingPostcode_text => driver.FindElement(By.Id("BillingPostcode"));

        // Web Actions
        public void FillDifferentBillingAddressInfo(CustomerData cust)
        {

            if (cust.DiffBillingAddr.ToLower().Equals("yes"))
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(ExpectedConditions.ElementToBeClickable(UseDifferentAddressForBilling_tick));

                UseDifferentAddressForBilling_tick.Click();
                BillingAddressLine1_text.SendKeys(cust.BillingAddrLine1);
                BillingAddressLine2_text.SendKeys(cust.BillingAddrLine2);
                BillingAddressLine3_text.SendKeys(cust.BillingAddrLine3);
                BillingCity_text.SendKeys(cust.BillingCity);
                BillingState_text.SendKeys(cust.BillingState);
                BillingCountry_dropdown.SendKeys(cust.BillingCountry);
                BillingPostcode_text.SendKeys(cust.BillingPostCode);
            }
        }
        #endregion

        #region Authorised signatory contact

        // Web Elements
        private IWebElement AuthorisedSignatoryContactFirstName_text => driver.FindElement(By.Id("PrimaryContactFirstName"));
        private IWebElement AuthorisedSignatoryContactLastName_text => driver.FindElement(By.Id("PrimaryContactLastName"));
        private IWebElement AuthorisedSignatoryContactDirectPhone_text => driver.FindElement(By.Id("PrimaryContactPhone"));
        private IWebElement AuthorisedSignatoryContactJobTitle_text => driver.FindElement(By.Id("PrimaryContactJobTitle"));
        private IWebElement AuthorisedSignatoryContactEmail_text => driver.FindElement(By.Id("PrimaryContactEmail"));

        // Web Actions
        public void FillAuthorisedSignatoryContact(CustomerData cust)
        {
            AuthorisedSignatoryContactFirstName_text.SendKeys(cust.PrimaryContactFirstName);
            AuthorisedSignatoryContactLastName_text.SendKeys(cust.PrimaryContactLastName);
            AuthorisedSignatoryContactDirectPhone_text.SendKeys(cust.PrimaryDirectPhone);
            AuthorisedSignatoryContactJobTitle_text.SendKeys(cust.PrimaryJobTitle);
            AuthorisedSignatoryContactEmail_text.SendKeys(cust.PrimaryEmail);
            PageScroll(AuthorisedSignatoryContactEmail_text);
        }
        #endregion

        #region Use other contact info
        // Web Elements
        private IWebElement UseOtherContact_tick => driver.FindElement(By.Id("usesamecontact"));

        // Web Actions
        public void TickUseOtherContact()
        {
            UseOtherContact_tick.Click();
        }
        #endregion

        #region Usage report contact
        // Web Elements
        private IWebElement UsageReportContactFirstName_text => driver.FindElement(By.Id("UsageContactFirstName"));
        private IWebElement UsageReportContactLastName_text => driver.FindElement(By.Id("UsageContactLastName"));
        private IWebElement UsageReportContactJobTitle_text => driver.FindElement(By.Id("UsageContactJobTitle"));
        private IWebElement UsageReportContactDirectPhone_text => driver.FindElement(By.Id("UsageContactPhone"));
        private IWebElement UsageReportContactEmail_text => driver.FindElement(By.Id("UsageContactEmail"));

        // Web Actions
        public void FillUsageReportContact(CustomerData cust)
        {
            UsageReportContactFirstName_text.Clear();
            UsageReportContactLastName_text.Clear();
            UsageReportContactJobTitle_text.Clear();
            UsageReportContactDirectPhone_text.Clear();
            UsageReportContactEmail_text.Clear();

            UsageReportContactFirstName_text.SendKeys(cust.UsageReportFirstName);
            UsageReportContactLastName_text.SendKeys(cust.UsageReportLastName);
            UsageReportContactJobTitle_text.SendKeys(cust.UsageReportJobTitle);
            UsageReportContactDirectPhone_text.SendKeys(cust.UsageReportPhone);
            UsageReportContactEmail_text.SendKeys(cust.UsageReportEmail);
            PageScroll(UsageReportContactEmail_text);
        }
        #endregion

        #region Sales comms contact
        // Web Elements
        private IWebElement SalesContactFirstName_text => driver.FindElement(By.Id("SalesContactFirstName"));
        private IWebElement SalesContactLastName_text => driver.FindElement(By.Id("SalesContactLastName"));
        private IWebElement SalesContactJobTitle_text => driver.FindElement(By.Id("SalesContactJobTitle"));
        private IWebElement SalesContactDirectPhone_text => driver.FindElement(By.Id("SalesContactPhone"));
        private IWebElement SalesContactEmail_text => driver.FindElement(By.Id("SalesContactEmail"));

        // Web Actions
        public void FillSalesCommsContact(CustomerData cust)
        {
            SalesContactFirstName_text.Clear();
            SalesContactLastName_text.Clear();
            SalesContactJobTitle_text.Clear();
            SalesContactDirectPhone_text.Clear();
            SalesContactEmail_text.Clear();

            SalesContactFirstName_text.SendKeys(cust.SalesFirstName);
            SalesContactLastName_text.SendKeys(cust.SalesLastName);
            SalesContactJobTitle_text.SendKeys(cust.SalesJobTitle);
            SalesContactDirectPhone_text.SendKeys(cust.SalesPhone);
            SalesContactEmail_text.SendKeys(cust.SalesEmail);
            PageScroll(SalesContactEmail_text);
        }
        #endregion

        #region Accounts contact
        // Web Elements
        private IWebElement AccountsContactFirstName_text => driver.FindElement(By.Id("AccountsContactFirstName"));
        private IWebElement AccountsContactLastName_text => driver.FindElement(By.Id("AccountsContactLastName"));
        private IWebElement AccountsContactJobTitle_text => driver.FindElement(By.Id("AccountsContactJobTitle"));
        private IWebElement AccountsContactDirectPhone_text => driver.FindElement(By.Id("AccountsContactPhone"));
        private IWebElement AccountsContactEmail_text => driver.FindElement(By.Id("AccountsContactEmail"));

        // Web Actions
        public void FillAccountsContact(CustomerData cust)
        {
            AccountsContactFirstName_text.Clear();
            AccountsContactLastName_text.Clear();
            AccountsContactJobTitle_text.Clear();
            AccountsContactDirectPhone_text.Clear();
            AccountsContactEmail_text.Clear();

            AccountsContactFirstName_text.SendKeys(cust.AccountsFirstName);
            AccountsContactLastName_text.SendKeys(cust.AccountsLastName);
            AccountsContactJobTitle_text.SendKeys(cust.AccountsJobTitle);
            AccountsContactDirectPhone_text.SendKeys(cust.AccountsPhone);
            AccountsContactEmail_text.SendKeys(cust.AccountsEmail);
            PageScroll(AccountsContactEmail_text);
        }
        #endregion

        #region Statement contact
        // Web Elements
        private IWebElement StatementContactFirstName_text => driver.FindElement(By.Id("StatementContactFirstName"));
        private IWebElement StatementContactLastName_text => driver.FindElement(By.Id("StatementContactLastName"));
        private IWebElement StatementContactJobTitle_text => driver.FindElement(By.Id("StatementContactJobTitle"));
        private IWebElement StatementContactDirectPhone_text => driver.FindElement(By.Id("StatementContactPhone"));
        private IWebElement StatementContactEmail_text => driver.FindElement(By.Id("StatementContactEmail"));

        // Web Actions
        public void FillStatementContact(CustomerData cust)
        {
            StatementContactFirstName_text.Clear();
            StatementContactLastName_text.Clear();
            StatementContactJobTitle_text.Clear();
            StatementContactDirectPhone_text.Clear();
            StatementContactEmail_text.Clear();

            StatementContactFirstName_text.SendKeys(cust.StatementFirstName);
            StatementContactLastName_text.SendKeys(cust.StatementLastName);
            StatementContactJobTitle_text.SendKeys(cust.StatementJobTitle);
            StatementContactDirectPhone_text.SendKeys(cust.StatementPhone);
            StatementContactEmail_text.SendKeys(cust.StatementEmail);
            PageScroll(StatementContactEmail_text);
        }
        #endregion

        #region Technical contact
        // Web Elements
        private IWebElement TechnicalContactFirstName_text => driver.FindElement(By.Id("TechnicalContactFirstName"));
        private IWebElement TechnicalContactLastName_text => driver.FindElement(By.Id("TechnicalContactLastName"));
        private IWebElement TechnicalContactJobTitle_text => driver.FindElement(By.Id("TechnicalContactJobTitle"));
        private IWebElement TechnicalContactDirectPhone_text => driver.FindElement(By.Id("TechnicalContactPhone"));
        private IWebElement TechnicalContactEmail_text => driver.FindElement(By.Id("TechnicalContactEmail"));

        // Web Actions
        public void FillTechnicalContact(CustomerData cust)
        {
            TechnicalContactFirstName_text.Clear();
            TechnicalContactLastName_text.Clear();
            TechnicalContactJobTitle_text.Clear();
            TechnicalContactDirectPhone_text.Clear();
            TechnicalContactEmail_text.Clear();

            TechnicalContactFirstName_text.SendKeys(cust.TechnicalFirstName);
            TechnicalContactLastName_text.SendKeys(cust.TechnicalLastName);
            TechnicalContactJobTitle_text.SendKeys(cust.TechnicalJobTitle);
            TechnicalContactDirectPhone_text.SendKeys(cust.TechnicalPhone);
            TechnicalContactEmail_text.SendKeys(cust.TechnicalEmail);
        }

        #endregion

        #region Other methods

        private void PageScroll(IWebElement element) 
        {
            // Use JavaScriptExecutor to scroll to the element
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        // Add methods to interact with the sign-up form
        public void SubmitForm()
        {
            //SubmitButton.Click();
        }
        #endregion
    }
}
