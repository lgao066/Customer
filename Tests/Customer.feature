Feature: Customer
  As a program officer
  In order to sign up a customer successfully
  I want to be able to fill the sign-up form with details

@ui @smoke
Scenario: Filling the sign-up form with details
  Given I am on the sign-up page as a "program officer"
  And I want to sign up a customer
  When I enter the following details:
    | Field                   | Value                   |
    | BusinessEntityName      | Rhipe Limited           |
    | LegalEntityId           | Doe                     |
    | AddrLine1               | Unit 1                  |
    | AddrLine2               | 23 abc Road             |
    | AddrLine3               | xyz                     |
    | City                    | Melbourne               |
    | State                   | VIC                     |
    | Country                 | Australia               |
    | PostCode                | 1234                    |
    | MainPhone               | 0472000000              |
    | Fax                     | 0472000000              |
    | Website                 | www.crayon.com          |
    | Email                   | abc.xyz@crayon.com      |
    | Source                  | Others (Please Specify) |
    | OtherSource             | Google                  |
    | IndustryType            | IT Consultants          |
    | DiffBillingAddr         | No                      |
    | PrimaryContactFirstName | Li                      |
    | PrimaryContactLastName  | Gao                     |
    | PrimaryDirectPhone      | 0471000000              |
    | PrimaryJobTitle         | SDET                    |
    | PrimaryEmail            | li.gao@crayon.com       |
    | UseSameContact          | Yes                     |
  Then I should sign up a customer successfully
