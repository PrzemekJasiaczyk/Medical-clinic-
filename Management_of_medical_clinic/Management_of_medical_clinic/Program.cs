using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Model;

static List<EmployeeModel> GetEmployeesData()
{
    List<EmployeeModel> employees = new List<EmployeeModel>();
    using (var db = new AppDbContext())
    {
        employees = db.DbEmployees.ToList();
    }

    return employees;
}

static EmployeeModel GetEmployeeByUserId(UserModel user)
{
    List<EmployeeModel> employees = GetEmployeesData();

    foreach (EmployeeModel employee in employees)
    {
        //if (employee.IdUser == user)
        //{
         //   return employee;
        //}
    }
    return null;
}


