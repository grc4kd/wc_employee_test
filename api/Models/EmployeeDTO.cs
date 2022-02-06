namespace api.Model
{
    /// <summary>
    /// Data Transfer Object
    /// per requirements, return only last and first name, then department
    /// </summary>
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Department { get; set; }
    }
}
