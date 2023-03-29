using Console_Management_of_medical_clinic.Data.Enums;
using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.UnitTests
{
    internal class EmployeeModelTests
    {
        [Test]
        public void FindEmployee_Returns_Employee_With_Correct_Id()
        {
            
            int employeeId = 1;
            var dbContext = new AppDbContext();
            EmployeeModel employee = new EmployeeModel(2, "John", "Doe", "12345678901", "1990-01-01", "123 Main St", "johndoe@example.com", "555-555-5555", EnumSex.Male, EnumEmployeeRoles.MedicalDoctor, 2, true);
            dbContext.DbEmployees.Add(employee);
            dbContext.SaveChanges();

            
            EmployeeModel result = EmployeeModel.FindEmployee(employeeId);

            
            Assert.IsNotNull(result);
            Assert.AreEqual(employeeId, result.IdEmployee);
            Assert.AreEqual("John", result.FirstName);
            Assert.AreEqual("Doe", result.LastName);
            Assert.AreEqual("12345678901", result.PESEL);
            Assert.AreEqual("1990-01-01", result.DateOfBirth);
            Assert.AreEqual("123 Main St", result.CorrespondenceAddress);
            Assert.AreEqual("johndoe@example.com", result.Email);
            Assert.AreEqual("555-555-5555", result.PhoneNumber);
            Assert.AreEqual(EnumSex.Male, result.Sex);
            Assert.AreEqual(EnumEmployeeRoles.MedicalDoctor, result.Role);
            Assert.AreEqual(1, result.IdSpecialization);
            Assert.IsTrue(result.IsActive);

            
            dbContext.DbEmployees.Remove(employee);
            dbContext.SaveChanges();
        }
    }
}


