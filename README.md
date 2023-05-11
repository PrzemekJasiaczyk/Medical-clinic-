# Clinic staff's module
## TODO List
For now:
- [ ] Unit Tests (Appointments)
  - [ ] AppointmentService
    - [ ] CanReschedule
  - [ ] CalendarAppointmentService
    - [ ] GetPatientDataByIdPatient
    - [ ] GetAppointmentsWithPatients
    - [ ] GetLastNameAndNameOfEmployeeByAppointment
    - [ ] GetAppointmentsData
    - [ ] appointmentInSelectedDate
    - [ ] SortByDoctor
    - [ ] SortByTerm
  - [ ] CalendarService
    - [ ] Filter
    - [ ] Sort
    - [ ] GetDateByIdCalendar
    - [ ] GetIdFromDate
- [ ] Improve forms
- [ ] Improve analysis for appointments
  
Soon:
- [ ] Rescheluding an appointment
- [ ] Issuing a confirmation
- [ ] Cleaning calendar from outdated and past visits

---
Done:
- [x] View list of appointments
  - [x] Forms
  - [x] Filtering
  - [x] Sorting
- [x] Registering a new appointment
  - [x] Forms
  - [x] Validation
- [x] Analysis
  - [x] Analysis for visit registration and calendar view for clinic staff
- [x] Functional tests for clinic staff module
- [x] Appointment details
- [x] Cancelling an appointment
- [X] Help Administratior module team with their stuff
- [X] Solve problems and repair mistakes with validation logic
- [x] Functional Tests (Patient management)
  - [x] Test scenarios
  - [x] Test cases
- [x] Refactor Patient class
- [x] Improve View form
- [x] Improve Login form
- [x] Check out merge-branch
- [x] Unit Tests (Patient management)
  - [x] Patient class
    - [x] ChangePatientStatus
    - [x] FindPatient
    - [x] RemovePatient
    - [x] AddPatient
    - [X] More...
  - [x] PatientService class
    - [x] GetPatientData
    - [x] IsValidName
    - [x] IsValidDate
    - [x] IsValidPESEL
    - [X] More..
- [x] Forms (Patient management)
  - [x] View patients' list form
    - [x] View
    - [x] Filter
    - [x] Sort
  - [x] Add patient form
  - [x] Edit patient form
  - [x] Remove patient form
- [x] Update Database Model (Patient management)
- [x] Analysis
  - [x] Diagrams
  - [x] Use Case descriptions
- [x] Patient class
- [x] Modification of EF Core Model
- [x] More...


## About

Module for medical clinic staff.

Medical clinic personnel responsible for registration patients and doctor appointments use tool described in this chapter.

System supports following processes:
- Managements of clinic patients and their data
- Management of doctor appointments
  
List of actors using he system:
- Clinic registration office staff

Privileges:
- Access to patient management module - this right allows access to the patient management module (the module is available to users with this right) and the realization of all functionalities of this module
- Access to patient visits management module - this right allows access to the patient visits management module (the module is available to users with this right) and the realization of all functionalities of this module

An employee who acts as an employee of the Clinic's registration office must have at least one of the above-mentioned Permissions  
