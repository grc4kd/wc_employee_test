# wc_employee_test
Simple Employee model/controller ASP.Net Core 6.0 API using TDD

The controller will have three endpoints/routes:

/employees - 
returns all employees as a projection of the Employee type - only return Last Name, First Name and Department, sorted by Last Name then First Name

/employees/{id} - 
returns a full employee resource by Id

/employees - 
adds a new employee resource


One is able to test the endpoints from Swagger endpoint


---------------------------------------------------------------


Employee Resource Type:
Id 
Last Name 
First Name
Department 
Hire Date


Existing Employee Data:

- Id = 1, LastName = "Jackson", FirstName = "Alberta", Department = "Finance", HireDate = 6/5/2007
- Id = 2, LastName = "Bennett", FirstName = "Alicia", Department = "Human Resources", HireDate = 4/15/2001
- Id = 3, LastName = "Avent", FirstName = "Donna", Department = "Revenue", HireDate = 4/20/2009
- Id = 4, LastName = "Holder", FirstName = "Duane", Department = "Human Services", HireDate = 8/15/2020


