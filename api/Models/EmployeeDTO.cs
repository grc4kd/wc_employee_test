namespace api.Models
{
    // per requirements, return only LastName, FirstName, and Department fields
    public class EmployeeDTO
    {
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Department { get; set; }
    }
}
