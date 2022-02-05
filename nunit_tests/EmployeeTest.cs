using NUnit.Framework;
using System;

namespace nunit_tests;

public class EmployeeTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void NewEmployeeTest()
    {
        // expected data
        var id = 1;
        var lastName = "Hill";
        var firstName = "Hank";
        var department = "Sales";
        var hireDate = new DateTime(1971, 8, 1);

        // create Employee object
        var _employee = new Employee()
        {
            Id = id,
            LastName = lastName,
            FirstName = firstName,
            Department = department,
            HireDate = hireDate
        };

        // test object against expected
        Assert.AreEqual(id, _employee.Id);
        Assert.AreEqual(lastName, _employee.LastName);
        Assert.AreEqual(firstName, _employee.FirstName);
        Assert.AreEqual(department, _employee.Department);
        Assert.AreEqual(hireDate, _employee.HireDate);
    }
}