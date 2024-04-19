using System.ComponentModel.DataAnnotations;

namespace EnhancingSwagger.Models;

public class CustomerRequest
{
    /// <include file='../Documentation/EnhancingSwagger.xml' path='Docs/RequestMembers/Member[@name="Status"]/*' />
    /// <example>Active</example>
    public string Status { get; set; }
    /// <include file='../Documentation/EnhancingSwagger.xml' path='Docs/RequestMembers/Member[@name="FirstName"]/*' />
    [MaxLength(30)]
    public string FirstName { get; set; }
    /// <include file='../Documentation/EnhancingSwagger.xml' path='Docs/RequestMembers/Member[@name="LastName"]/*' />
    public string LastName { get; set; }
}
