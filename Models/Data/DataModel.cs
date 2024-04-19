namespace EnhancingSwagger.Models.Data;

public class Customer
{
    public int CustomerId { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string Email { get; init; }
    public string Status { get; init; }
}

public class SampleData
{
    public List<Customer> Seed()
    {
        var customers = new List<Customer>
        {
            new()
            {
                CustomerId = 1, FirstName = "Abraham", LastName = "Lincoln", Email = "abe@email.com", Status="Active" 
            },
            new()
            {
                CustomerId = 2, FirstName = "Thomas", LastName = "Jefferson", Email = "thomas@email.com",
                Status="Active" 
            },
            new()
            {
                CustomerId = 3, FirstName = "Andrew", LastName = "Jackson", Email = "andrew@email.com",
                Status="Inactive"
            },
            new()
            {
                CustomerId = 4, FirstName = "John", LastName = "Adams", Email = "john@email.com",
                Status="Inactive"
            }
        };

        return customers;
    }
}