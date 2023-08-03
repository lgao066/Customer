namespace Customer.TestData
{
    public class CustomerData
    {
        #region General info
        public string BusinessEntityName { get; set; }
        public string LegalEntityId { get; set; }

        #region Main address
        public string AddrLine1 { get; set; }
        public string AddrLine2 { get; set; }
        public string AddrLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        #endregion

        public string MainPhone { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Source { get; set; }
        public string OtherSource { get; set; }
        public string IndustryType { get; set; }
        #endregion

        #region Billing address
        public string DiffBillingAddr { get; set; }

        public string BillingAddrLine1 { get; set; }
        public string BillingAddrLine2 { get; set; }
        public string BillingAddrLine3 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string BillingPostCode { get; set; }
        #endregion

        #region Authorised Signatory Contact
        public string PrimaryContactFirstName { get; set; }
        public string PrimaryContactLastName { get; set; }
        public string PrimaryDirectPhone { get; set; }
        public string PrimaryJobTitle { get; set; }
        public string PrimaryEmail { get; set; }
        #endregion

        #region Other contacts
        public string UseSameContact { get; set; }

        // Usage Report
        public string UsageReportFirstName { get; set; }
        public string UsageReportLastName { get; set; }
        public string UsageReportPhone { get; set; }
        public string UsageReportJobTitle { get; set; }
        public string UsageReportEmail { get; set; }

        // Sales
        public string SalesFirstName { get; set; }
        public string SalesLastName { get; set; }
        public string SalesPhone { get; set; }
        public string SalesJobTitle { get; set; }
        public string SalesEmail { get; set; }

        // Accounts
        public string AccountsFirstName { get; set; }
        public string AccountsLastName { get; set; }
        public string AccountsPhone { get; set; }
        public string AccountsJobTitle { get; set; }
        public string AccountsEmail { get; set; }

        // Statement
        public string StatementFirstName { get; set; }
        public string StatementLastName { get; set; }
        public string StatementPhone { get; set; }
        public string StatementJobTitle { get; set; }
        public string StatementEmail { get; set; }

        // Technical
        public string TechnicalFirstName { get; set; }
        public string TechnicalLastName { get; set; }
        public string TechnicalPhone { get; set; }
        public string TechnicalJobTitle { get; set; }
        public string TechnicalEmail { get; set; }
        #endregion
    }
}