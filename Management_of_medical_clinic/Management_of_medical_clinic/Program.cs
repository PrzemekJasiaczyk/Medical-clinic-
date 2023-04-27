using Console_Management_of_medical_clinic.Data;
using Console_Management_of_medical_clinic.Data.Enums;
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

static List<int> GetDoctorId()
{
    List<int> doctorsId = new List<int>();
    List<EmployeeModel> employees = GetEmployeesData();

    foreach (EmployeeModel employee in employees)
    {
        if (employee.Role == EnumEmployeeRoles.MedicalDoctor)
        {
            doctorsId.Add(employee.IdEmployee);
        }
    }
    foreach (int doctor in doctorsId)
    {
        Console.WriteLine(doctor);
    }
    return doctorsId;
}

GetDoctorId();


