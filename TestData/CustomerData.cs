namespace Customer.TestData
{
    public class CustomerData
    {
        #region General info
        public string BusinessEntityName { get; set; }
        public string LegalEntityId { get; set; }
        public string AddrLine1 { get; set; }
        public string AddrLine2 { get; set; }
        public string AddrLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
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
        #endregion
    }
}