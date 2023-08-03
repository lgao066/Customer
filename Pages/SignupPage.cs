using Customer.TestData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

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
            Industry_dropdown.SendKeys(cust.IndustryType);
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
                UseDifferentAddressForBilling_tick.Click();
                BillingAddressLine1_text.SendKeys("");
                BillingAddressLine2_text.SendKeys("");
                BillingAddressLine3_text.SendKeys("");
                BillingCity_text.SendKeys("");
                BillingState_text.SendKeys("");
                BillingCountry_dropdown.SendKeys("");
                BillingPostcode_text.SendKeys("");
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
            Thread.Sleep(5000);
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
            UsageReportContactFirstName_text.SendKeys("121212");
            UsageReportContactLastName_text.SendKeys("");
            UsageReportContactJobTitle_text.SendKeys("");
            UsageReportContactDirectPhone_text.SendKeys("");
            UsageReportContactEmail_text.SendKeys("");
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
            SalesContactFirstName_text.SendKeys("121212");
            SalesContactLastName_text.SendKeys("");
            SalesContactJobTitle_text.SendKeys("");
            SalesContactDirectPhone_text.SendKeys("");
            SalesContactEmail_text.SendKeys("");
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
            AccountsContactFirstName_text.SendKeys("121212");
            AccountsContactLastName_text.SendKeys("");
            AccountsContactJobTitle_text.SendKeys("");
            AccountsContactDirectPhone_text.SendKeys("");
            AccountsContactEmail_text.SendKeys("");
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
            StatementContactFirstName_text.SendKeys("121212");
            StatementContactLastName_text.SendKeys("");
            StatementContactJobTitle_text.SendKeys("");
            StatementContactDirectPhone_text.SendKeys("");
            StatementContactEmail_text.SendKeys("");
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
            TechnicalContactFirstName_text.SendKeys("121212");
            TechnicalContactLastName_text.SendKeys("");
            TechnicalContactJobTitle_text.SendKeys("");
            TechnicalContactDirectPhone_text.SendKeys("");
            TechnicalContactEmail_text.SendKeys("");
        }

        #endregion

        #region Other methods
        // Add methods to interact with the sign-up form
        public void SubmitForm()
        {
            //SubmitButton.Click();
        }
        #endregion
    }
}
