using System;
using Customer.Process;
using Customer.TestData;
using Newtonsoft.Json.Bson;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Customer.Steps
{
    [Binding]
    public class CustomerSteps
    {
        private IWebDriver driver;
        private CustomerData cust;
        private SignupProcess signupProcess;

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Set up the Chrome driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Close the Chrome driver
            driver.Quit();
            driver.Dispose();
        }
        [Given(@"I am on the sign-up page as a ""([^""]*)""")]
        public void GivenIAmOnTheSign_UpPageAsA(string userPermission)
        {
            // Control the accessed page based on user permission
            switch (userPermission.Trim().ToLower()) 
            {
                case "program officer":
                    // Navigate to the sign-up page
                    driver.Navigate().GoToUrl(TestConfigs.Url);
                    break;
                default:
                    break;
            }
            // Navigate to the sign-up page
            driver.Navigate().GoToUrl(TestConfigs.Url);
        }

        [Given(@"I want to sign up a customer")]
        public void GivenIWantToSignUpACustomer()
        {
            // Set up related customer data
            cust = new CustomerData();
            // Set up related business processes
            signupProcess = new SignupProcess(driver);
        }

        [When("I enter the following details:")]
        public void WhenIEnterTheFollowingDetails(Table table)
        {
            MapCustomerData(table);
            signupProcess.FillSignUpForm(cust);
        }

        [Then("I should sign up a customer successfully")]
        public void ThenIShouldBeSuccessfullySignedUp()
        {
            // Assertion to verify successful sign-up (e.g., check for a success message or redirection)
            //var successMessage = driver.FindElement(By.CssSelector(".success-message"));
            //Assert.IsTrue(successMessage.Displayed, "Sign-up was not successful.");
        }

        // Support functions
        private void MapCustomerData(Table table) 
        {
            // Get the table data

            // General info
            cust.BusinessEntityName = table.Rows[0]["Value"];
            cust.LegalEntityId = table.Rows[1]["Value"];
            cust.AddrLine1 = table.Rows[2]["Value"];
            cust.AddrLine2 = table.Rows[3]["Value"];
            cust.AddrLine3 = table.Rows[4]["Value"];
            cust.City = table.Rows[5]["Value"];
            cust.State = table.Rows[6]["Value"];
            cust.Country = table.Rows[7]["Value"];
            cust.PostCode = table.Rows[8]["Value"];
            cust.MainPhone = table.Rows[9]["Value"];
            cust.Fax = table.Rows[10]["Value"];
            cust.Website = table.Rows[11]["Value"];
            cust.Email = table.Rows[12]["Value"];
            cust.Source = table.Rows[13]["Value"];
            cust.OtherSource = table.Rows[14]["Value"];
            cust.IndustryType = table.Rows[15]["Value"];
            // Billing address
            cust.DiffBillingAddr = table.Rows[16]["Value"];
            // Primary contact
            cust.PrimaryContactFirstName = table.Rows[17]["Value"];
            cust.PrimaryContactLastName = table.Rows[18]["Value"];
            cust.PrimaryDirectPhone = table.Rows[19]["Value"];
            cust.PrimaryJobTitle = table.Rows[20]["Value"];
            cust.PrimaryEmail = table.Rows[21]["Value"];
            // Other contact
            cust.UseSameContact = table.Rows[22]["Value"];


        }
    }
}
