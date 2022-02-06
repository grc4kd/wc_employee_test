using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using api.Data;
using api.Model;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace nunit_tests
{
    public class EmployeeDataTest
    {
        private ApiContext? _context;
        
        [TearDown]
        public void TearDown()
        {
            // remove context object and...
            if (_context != null)
            {
                // ...update garbage collector between tests
                _context.Dispose();
            }            
        }

        [Test]
        public async Task TestExistingEmployeeData()
        {
            var options = new DbContextOptionsBuilder<ApiContext>()
                                .UseInMemoryDatabase("employeeDB")
                                .Options;

            _context = new ApiContext(options);
            var _seeder = new ApiContextSeeder(_context);
            _seeder.SeedData();

            var employee1 = await _context.FindAsync<Employee>(1);
            if (employee1 == null)
            {
                Assert.IsNotNull(employee1);
            }
            else
            {
                Assert.AreEqual(1, employee1.Id);
                Assert.AreEqual("Jackson", employee1.LastName);
                Assert.AreEqual("Alberta", employee1.FirstName);
                Assert.AreEqual("Finance", employee1.Department);
                Assert.AreEqual(new DateTime(2007, 6, 5), employee1.HireDate);
            }

            var employee2 = await _context.FindAsync<Employee>(2);
            if (employee2 == null)
            {
                Assert.IsNotNull(employee2);
            }
            else
            {
                Assert.AreEqual(2, employee2.Id);
                Assert.AreEqual("Bennett", employee2.LastName);
                Assert.AreEqual("Alicia", employee2.FirstName);
                Assert.AreEqual("Human Resources", employee2.Department);
                Assert.AreEqual(new DateTime(2001, 4, 15), employee2.HireDate);
            }

            var employee3 = await _context.FindAsync<Employee>(3);
            if (employee3 == null)
            {
                Assert.IsNotNull(employee3);
            }
            else
            {
                Assert.AreEqual(3, employee3.Id);
                Assert.AreEqual("Avent", employee3.LastName);
                Assert.AreEqual("Donna", employee3.FirstName);
                Assert.AreEqual("Revenue", employee3.Department);
                Assert.AreEqual(new DateTime(2009, 4, 20), employee3.HireDate);
            }

            var employee4 = await _context.FindAsync<Employee>(4);
            if (employee4 == null)
            {
                Assert.IsNotNull(employee4);
            }
            else
            {
                Assert.AreEqual(4, employee4.Id);
                Assert.AreEqual("Holder", employee4.LastName);
                Assert.AreEqual("Duane", employee4.FirstName);
                Assert.AreEqual("Human Services", employee4.Department);
                Assert.AreEqual(new DateTime(2020, 8, 15), employee4.HireDate);
            }
        }

        [Test]
        public void TestEmployeeDataOrder()
        {
            var options = new DbContextOptionsBuilder<ApiContext>()
                                .UseInMemoryDatabase("employeeDB")
                                .Options;

            var _context = new ApiContext(options);
            var _seeder = new ApiContextSeeder(_context);
            _seeder.SeedData();

            Assert.AreEqual("Avent", _context.Employee.First().LastName);
        }
    }
}
