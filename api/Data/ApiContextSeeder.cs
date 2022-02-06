using api.Model;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApiContextSeeder : ISeeder
    {
        private readonly ApiContext _context;

        public ApiContextSeeder(ApiContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void SeedData()
        {
            _context.Database.EnsureCreated();

            // only seed data when Employee table has not been populated
            if (_context.Employee.Any() == false)
            {
                _context.Employee.AddRange(new Employee
                {
                    Id = 1,
                    LastName = "Jackson",
                    FirstName = "Alberta",
                    Department = "Finance",
                    HireDate = new DateTime(2007, 6, 5)
                },
                new Employee
                {
                    Id = 2,
                    LastName = "Bennett",
                    FirstName = "Alicia",
                    Department = "Human Resources",
                    HireDate = new DateTime(2001, 4, 15)
                },
                new Employee
                {
                    Id = 3,
                    LastName = "Avent",
                    FirstName = "Donna",
                    Department = "Revenue",
                    HireDate = new DateTime(2009, 4, 20)
                },
                new Employee
                {
                    Id = 4,
                    LastName = "Holder",
                    FirstName = "Duane",
                    Department = "Human Services",
                    HireDate = new DateTime(2020, 8, 15)
                });

                _context.SaveChanges();
            }
        }
    }
}
