using Microsoft.AspNetCore.Mvc;
using EnhancingSwagger.Models;
using EnhancingSwagger.Models.Data;

namespace EnhancingSwagger.Controllers;

[ApiController]
[Route("customers")]
[Produces("application/json")]
public class HomeController : Controller
{
    private readonly List<Customer> _customerData; 
    public HomeController()
    {
        var dataModel = new SampleData();
        _customerData = dataModel.Seed();
    }

    /// <summary>
    /// Get customers
    /// </summary>
    /// <param name="request">A CustomerRequest object</param>
    /// <returns>A CustomerSummaryRepresentation object</returns>
    /// <remarks>
    ///    <i>Example GET:</i><br /> /customers?Status=Active
    /// </remarks>  
    /// <response code="200">Returns a CustomerSummaryRepresentation object. You are seeing this text because of the response tag on the endpoint controller method. You see the Media type and Schema below because of the ProducesResponseType attribute on the endpoint controller method.</response>
    /// <response code="404">No customer records found.</response>
    /// <response code="400">Request validation failed.</response>
    [HttpGet]
    [Route("", Name="Customers.Get")]
    [ProducesResponseType(typeof(CustomerRepresentation),StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails),StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Get([FromQuery] CustomerRequest request)
    {
        var results = _customerData
            .Where(x => x.Status == request.Status)
            .Where(x => x.FirstName == request.FirstName || string.IsNullOrEmpty(request.FirstName))
            .Where(x => x.FirstName == request.LastName || string.IsNullOrEmpty(request.LastName))
            .Select(x=>new CustomerResult
            {
                CustomerId = x.CustomerId,
                Email = x.Email,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Status = x.Status
            }).ToList();

        if (!results.Any())
            return NotFound();
        
        var representation = new CustomerRepresentation(request, results);

        return Ok(representation);
    }
}