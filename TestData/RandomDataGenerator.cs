using System;

public static class RandomDataGenerator
{
    private static Random random = new Random();

    // List of sample names for random generation
    private static string[] firstNames = { "John", "Jane", "Michael", "Emily", "David", "Sarah", "Robert", "Jessica", "Li" };
    private static string[] lastNames = { "Smith", "Johnson", "Brown", "Lee", "Williams", "Miller", "Davis", "Wilson", "Gao" };

    // List of sample cities and states for random generation
    private static string[] cities = { "Sydney", "Melbourne", "Brisbane", "Perth", "Adelaide", "Gold Coast", "Canberra" };
    private static string[] states = { "NSW", "VIC", "QLD", "WA", "SA", "QLD", "ACT" };

    // List of sample job titles for random generation
    private static string[] jobTitles = {
        "Software Engineer", "Data Scientist", "Product Manager", "Web Developer",
        "UI/UX Designer", "Sales Manager", "Marketing Coordinator", "Business Analyst",
        "HR Specialist", "Financial Analyst", "Customer Support Representative",
        "Operations Manager", "Project Manager", "Quality Assurance Analyst",
        "Content Writer", "Graphic Designer", "Network Administrator"
    };

    // Generate a random first name
    public static string GenerateFirstName()
    {
        return firstNames[random.Next(firstNames.Length)];
    }

    // Generate a random last name
    public static string GenerateLastName()
    {
        return lastNames[random.Next(lastNames.Length)];
    }

    // Generate a random phone number in the format XXX-XXX-XXXX
    public static string GeneratePhoneNumber()
    {
        return $"{random.Next(100, 999):000}-{random.Next(100, 999):000}-{random.Next(1000, 9999):0000}";
    }

    // Generate a random email address
    public static string GenerateEmail()
    {
        string[] domains = { "example.com", "test.com", "domain.com", "mail.com", "crayon.com" };
        string firstName = GenerateFirstName().ToLower();
        string lastName = GenerateLastName().ToLower();
        string domain = domains[random.Next(domains.Length)];

        return $"{firstName}.{lastName}@{domain}";
    }

    // Generate a random address line 1
    public static string GenerateAddressLine1()
    {
        string[] streetNames = { "King Street", "Queen Street", "George Street", "Victoria Avenue", "Main Road", "Park Avenue" };
        string streetNumber = random.Next(1, 100).ToString();
        string streetName = streetNames[random.Next(streetNames.Length)];
        return $"{streetNumber} {streetName}";
    }

    // Generate a random address line 2 (optional)
    public static string GenerateAddressLine2()
    {
        string[] addressLine2Options = { "Apartment 101", "Unit 202", "Suite 303", "Floor 4", "Building B" };
        if (random.Next(0, 2) == 1)
        {
            return addressLine2Options[random.Next(addressLine2Options.Length)];
        }
        return string.Empty;
    }

    // Generate a random address line 3 (optional)
    public static string GenerateAddressLine3()
    {
        string[] addressLine3Options = { "Office Park", "Business Center", "Tower 1", "Shop 5" };
        if (random.Next(0, 2) == 1)
        {
            return addressLine3Options[random.Next(addressLine3Options.Length)];
        }
        return string.Empty;
    }

    // Generate a random city
    public static string GenerateCity()
    {
        return cities[random.Next(cities.Length)];
    }

    // Generate a random state in Australia
    public static string GenerateState()
    {
        return states[random.Next(states.Length)];
    }

    // Generate a random postcode in Australia
    public static string GeneratePostcode()
    {
        return $"{random.Next(2000, 9999)}";
    }

    // Generate a random job title
    public static string GenerateJobTitle()
    {
        return jobTitles[random.Next(jobTitles.Length)];
    }
}

