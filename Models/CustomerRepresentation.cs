namespace EnhancingSwagger.Models;

public class CustomerRepresentation
{
    public CustomerRepresentation(CustomerRequest request, List<CustomerResult> results)
    {
        Request = request;
        Results = results;
    }

    public CustomerRequest Request { get; set; }
    public List<CustomerResult> Results { get; set; }
}

/// <summary>
/// Customer results from data
/// </summary>
public class CustomerResult
{
    /// <summary>
    /// (From XML comments) Unique Customer Identifier
    /// </summary>
    public int CustomerId { get; set; }
    /// <summary>
    /// (From XML comments) Customer's First Name
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// (From XML comments) Customer's Last Name
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// (From XML comments) Customer's Email
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// (From XML comments) Customer's Status
    /// </summary>
    public string Status { get; set; }
}