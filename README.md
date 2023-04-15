# Clinic staff's module
## TODO List
- [ ] Functional Tests
  - [ ] Test scenarios
  - [ ] Test cases
- [ ] Refactor Patient class
- [ ] Improve View form
- [ ] Improve Login form
- [ ] Check out merge-branch
- [ ] Unit Tests
  - [ ] Patient class
    - [ ] ChangePatientStatus
    - [ ] FindPatient
    - [ ] RemovePatient
    - [ ] AddPatient
    - [X] More...
  - [ ] PatientService class
    - [ ] GetPatientData
    - [ ] IsValidName
    - [ ] IsValidDate
    - [ ] IsValidPESEL
    - [X] More..
- [ ] Forms
  - [ ] View patients' list form
    - [x] View
    - [ ] Filter
    - [x] Sort
  - [x] Add patient form
  - [x] Edit patient form
  - [x] Remove patient form
- [x] Update Database Model
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
