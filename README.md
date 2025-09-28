[README (4).md](https://github.com/user-attachments/files/22583159/README.4.md)

# Hospital Management System :
The Hospital Management System is a comprehensive software solution designed to streamline and automate various administrative and clinical operations within a healthcare facility. This system aims to improve efficiency, reduce paperwork, and enhance the overall quality of patient care.


## System Architecture
The system is built using object-oriented programming principles with over 20 class files, ensuring modularity, maintainability, and scalability. The application features a role-based access control system with two distinct user types: 
## Used By


* Platform: Microsoft .NET Framework
* Programming Language: C#    
* Development Environment: Visual Studio 2022
* Architecture: Desktop Application (Windows Forms/WPF)
* Project Structure: 20+ Class Files for modular design
* Database: SQL Server 2012 (LocalDB/Express)

## User Roles & Access Control
1. Administrator - Complete system control and management
2. Receptionist - Patient care and operational management
## Key Features :
### Administrator Functions
 * **Staff Management:** Add and manage doctors, nurses, and employees
 *  **Payroll System:** Set and manage staff salaries and working hours
 * **Facility Management:** Configure hospital room types, quantities, and daily rates
 * **Laboratory Management:** Define medical tests and set pricing
 * **Financial Management:**
    * Complete balance sheet oversight
    * Income and expense tracking
    * Profit/loss analysis and reporting
### Receptionist Functions
 * **Patient Management:** Complete patient   registration and profile maintenance
 * **Appointment Scheduling:** Book and manage doctor-patient appointments
 * **Room Booking System:** Assign and manage patient room allocations
 * **Test Management:** Schedule and coordinate laboratory tests
* **Billing Operations:** Generate and process patient bills
* **Attendance Tracking:** Monitor and record staff attendance (doctors, nurses, employees)

### ChatBot Integration (Key Feature)
An innovative self-service chatbot system that allows patients to:

* **Self-Admission:** Complete admission process  independently
* **Bill Payment:** Process payments for medical services
* **Medical History:** Access and review personal medical records
* **Test Requests:** Submit requests for laboratory tests
* **Room Booking:** Reserve hospital rooms
* **Appointment Scheduling:** Book appointments with doctors
* **Email notification system :** Payment confirmation 
* **24/7 Availability:** Round-the-clock patient service support



## Target Users
* **Hospital Administrators:** Complete system oversight and management
* **Receptionists:** Patient care coordination and operational management
* **Patients:** Self-service capabilities through integrated chatbot
* **Medical Staff:** Indirect users through scheduling and attendance systems
## Unique Features & Benefits
* **Dual-Role Architecture:** Specialized interfaces for administrators and receptionists
* **Comprehensive Financial Management:** Complete income, expense, and profitability tracking
* **Intelligent ChatBot:** Revolutionary self-service patient portal
* **Modular Design:** 20+ class structure for maintainable and scalable code
* **Complete Hospital Ecosystem:** From staff management to patient billing
* **Real-time Attendance Tracking:** Monitor staff presence and availability
* **Flexible Room & Test Management:** Configurable hospital resources and pricing

## Benefits

* **Operational Excellence:** Streamlined workflows for both administrative and patient-facing operations
* **Financial Transparency:** Complete visibility into hospital finances and profitability
* **Enhanced Patient Experience:** 24/7 self-service capabilities through chatbot integration
* **Staff Efficiency:** Automated attendance tracking and schedule management
* **Reduced Administrative Burden:** Automated billing, room management, and test coordination
* **Data-Driven Decisions:** Comprehensive reporting for better hospital management
* **Cost Management:** Dynamic pricing control for rooms and medical tests
## Project Status
**Completed** - Fully functional system with comprehensive features implemented
## Technical Highlights
* **Object-Oriented Design:** Modular architecture with 20+ specialized classes
* **Role-Based Security:** Secure login system with administrator and receptionist access levels
* **Database Integration:** Robust data management for all hospital operations
* **User-Friendly Interface:** Intuitive design for both staff and patient interactions
* **Real-Time Processing:** Live updates for appointments, billing, and attendance tracking

## Innovation Factor
The integrated **ChatBot** system represents a significant advancement in hospital management technology, providing patients with unprecedented autonomy in managing their healthcare interactions while reducing staff workload and improving service availability.
## Future Enhancements
* Mobile application development for enhanced accessibility
* Integration with external laboratory systems
* Advanced reporting and analytics dashboard
* SMS/Email notification system
* Telemedicine integration capabilities
* Electronic prescription management
* Insurance claim processing automation
##  Data Tabile

CREATE TABLE [dbo].[Admin] (
    [UserID]   INT          NOT NULL,
    [UserType] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [UserNo]   INT          NOT NULL,
    CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED ([UserID] ASC)
);

CREATE TABLE [dbo].[Doctor] (
    [Name]                  VARCHAR (MAX) NOT NULL,
    [DoctorID]              INT           IDENTITY (1, 1) NOT NULL,
    [DoctorLicenseID]       INT           NOT NULL,
    [JoningDate]            VARCHAR (MAX) NOT NULL,
    [WorkingTime]           VARCHAR (50)  NOT NULL,
    [Age]                   INT           NOT NULL,
    [Gender]                VARCHAR (50)  NOT NULL,
    [AppointmentCapability] INT           NOT NULL,
    [Salary]                INT           NOT NULL,
    [Specialization]        VARCHAR (50)  NOT NULL,
    [EmergencyContact]      INT           NOT NULL,
    [Email]                 VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED ([DoctorID] ASC)
);

CREATE TABLE [dbo].[Nurse] (
    [NurseID]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]          VARCHAR (50)  NOT NULL,
    [JoningDate]    VARCHAR (MAX) NOT NULL,
    [LicenseID]     VARCHAR (50)  NOT NULL,
    [Age]           INT           NOT NULL,
    [Gender]        VARCHAR (50)  NOT NULL,
    [Salary]        INT           NOT NULL,
    [Shift]         VARCHAR (50)  NOT NULL,
    [ContactNumber] INT           NOT NULL,
    CONSTRAINT [PK_Nurse] PRIMARY KEY CLUSTERED ([NurseID] ASC)
);

CREATE TABLE [dbo].[Employee] (
    [EmployeeName]  VARCHAR (MAX) NOT NULL,
    [EmployeeID]    INT           IDENTITY (1, 1) NOT NULL,
    [JoiningDate]   VARCHAR (MAX) NOT NULL,
    [Role]          VARCHAR (50)  NOT NULL,
    [Age]           INT           NOT NULL,
    [Gender]        VARCHAR (50)  NOT NULL,
    [Shift]         VARCHAR (50)  NOT NULL,
    [Salary]        INT           NOT NULL,
    [ContactNumber] INT           NOT NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

CREATE TABLE [dbo].[Test] (
    [TestId]   INT          IDENTITY (1, 1) NOT NULL,
    [TestName] VARCHAR (50) NOT NULL,
    [TestCost] INT          NOT NULL,
    CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED ([TestId] ASC)
);

CREATE TABLE [dbo].[Room] (
    [RoomID]       INT          IDENTITY (1, 1) NOT NULL,
    [RoomType]     VARCHAR (50) NOT NULL,
    [CostPerDay]   INT          NOT NULL,
    [RoomQuantity] INT          NOT NULL,
    CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED ([RoomID] ASC)
);

CREATE TABLE [dbo].[Patient] (
    [PatientName] VARCHAR (50)  NOT NULL,
    [PatientID]   INT           IDENTITY (1, 1) NOT NULL,
    [Age]         INT           NOT NULL,
    [BloodGroup]  VARCHAR (50)  NOT NULL,
    [Address]     VARCHAR (MAX) NOT NULL,
    [MajorDeases] VARCHAR (MAX) NOT NULL,
    [ContactNo]   INT           NOT NULL,
    [Email]       VARCHAR (MAX) NOT NULL,
    [Gender]      VARCHAR (50)  NULL,
    CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED ([PatientID] ASC)
);

CREATE TABLE [dbo].[Appointment] (
    [AppointmentID]   INT             IDENTITY (1, 1) NOT NULL,
    [DoctorID]        INT             NOT NULL,
    [PatientID]       INT             NOT NULL,
    [AppointmentDate] DATE            NOT NULL,
    [Cost]            DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED ([AppointmentID] ASC),
    CONSTRAINT [FK_Appointment_Appointment] FOREIGN KEY ([DoctorID]) REFERENCES [dbo].[Doctor] ([DoctorID]),
    CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient] ([PatientID])
);

CREATE TABLE [dbo].[TestOrder] (
    [OrderID]     INT            IDENTITY (1, 1) NOT NULL,
    [PatientID]   INT            NOT NULL,
    [PatientName] VARCHAR (MAX)  NOT NULL,
    [TestNames]   NVARCHAR (MAX) NOT NULL,
    [TotalCost]   INT            NOT NULL,
    [Email]       NVARCHAR (MAX) NULL,
    [Status]      NVARCHAR (50)  NOT NULL,
    [SerialNo]    INT            NULL,
    CONSTRAINT [PK_TestOrder] PRIMARY KEY CLUSTERED ([OrderID] ASC),
    CONSTRAINT [FK_TestOrder_Patient] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient] ([PatientID])
);

CREATE TABLE [dbo].[Booking] (
    [BookingID]  INT             IDENTITY (1, 1) NOT NULL,
    [RoomID]     INT             NOT NULL,
    [PatientID]  INT             NOT NULL,
    [StartDate]  DATE            NOT NULL,
    [EndDate]    DATE            NOT NULL,
    [CostPerDay] DECIMAL (10, 2) NOT NULL,
    [TotalCost]  DECIMAL (10, 2) NOT NULL,
    [Status]     NVARCHAR (50)   NOT NULL,
    CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED ([BookingID] ASC),
    CONSTRAINT [FK_Booking_Patient] FOREIGN KEY ([RoomID]) REFERENCES [dbo].[Room] ([RoomID]),
    CONSTRAINT [FK_Booking_Patient1] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient] ([PatientID])
);
CREATE TABLE [dbo].[Payments] (
    [BillID]      INT             IDENTITY (1, 1) NOT NULL,
    [PatientID]   INT             NOT NULL,
    [PatientName] VARCHAR (MAX)   NOT NULL,
    [TotalAmount] DECIMAL (18, 2) NOT NULL,
    [PaidAmount]  DECIMAL (18, 2) NOT NULL,
    [DueAmount]   DECIMAL (18, 2) NOT NULL,
    [PaymentDate] DATETIME        NULL,
    [Status]      VARCHAR (50)    NULL,
    CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED ([BillID] ASC),
    CONSTRAINT [FK_Payments_Patient] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient] ([PatientID])
);

CREATE TABLE [dbo].[Absence] (
    [AbsenceID] INT          IDENTITY (1, 1) NOT NULL,
    [StaffType] VARCHAR (50) NOT NULL,
    [StaffID]   INT          NOT NULL,
    [Date]      DATETIME     NOT NULL
);

CREATE TABLE [dbo].[BalanceDetails] (
    [BalanceID]   INT             IDENTITY (1, 1) NOT NULL,
    [Type]        VARCHAR (MAX)   NOT NULL,
    [Description] VARCHAR (MAX)   NOT NULL,
    [Amount]      DECIMAL (18, 2) NOT NULL,
    [EntryDate]   DATETIME        NOT NULL,
    [PatientID]   INT             NULL,
    [EmployeeID]  INT             NULL,
    [DoctorID]    INT             NULL,
    [NurseID]     INT             NULL,
    CONSTRAINT [PK_BalanceDetails] PRIMARY KEY CLUSTERED ([BalanceID] ASC),
    CONSTRAINT [FK_BalanceDetails_Doctor] FOREIGN KEY ([DoctorID]) REFERENCES [dbo].[Doctor] ([DoctorID]),
    CONSTRAINT [FK_BalanceDetails_Employee] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([EmployeeID]),
    CONSTRAINT [FK_BalanceDetails_Patient] FOREIGN KEY ([PatientID]) REFERENCES [dbo].[Patient] ([PatientID]),
    CONSTRAINT [FK_BalanceDetails_Nurse] FOREIGN KEY ([NurseID]) REFERENCES [dbo].[Nurse] ([NurseID])
);

CREATE TABLE [dbo].[SalaryDetails] (
    [SalaryID]   INT             IDENTITY (1, 1) NOT NULL,
    [StaffType]  VARCHAR (MAX)   NOT NULL,
    [StaffName]  VARCHAR (MAX)   NOT NULL,
    [Salary]     DECIMAL (18, 2) NOT NULL,
    [MonthYear]  VARCHAR (50)    NULL,
    [EntryDate]  DATETIME        NULL,
    [NurseID]    INT             NULL,
    [DoctorID]   INT             NULL,
    [EmployeeID] INT             NULL,
    CONSTRAINT [PK_SalaryDetails] PRIMARY KEY CLUSTERED ([SalaryID] ASC),
    CONSTRAINT [FK_SalaryDetails_Doctor] FOREIGN KEY ([DoctorID]) REFERENCES [dbo].[Doctor] ([DoctorID]),
    CONSTRAINT [FK_SalaryDetails_Employee] FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employee] ([EmployeeID]),
    CONSTRAINT [FK_SalaryDetails_Nurse] FOREIGN KEY ([NurseID]) REFERENCES [dbo].[Nurse] ([NurseID])
);

![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/c1.png)

![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/c2.png)










## Screenshots
* # Admin

* Login :
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log1.png)

* Deshboard :
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log2.png)

![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log3.png)

* Doctor Management
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log4.png)

* Nurse Management
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log5.png)

* Employee Management
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log6.png)

* Test Management
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log7.png)

* Room Management
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log8.png)

* Hospital Balance
 ![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log9.png)

 * Salary Details
 ![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log10.png)

 * AmountBar,pie Chart
 ![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log11.png)

 ![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log12.png)
 
 * User Control
 ![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/log13.png)

* ### Receptionist

 * Dashboard  
 ![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC1.png)

* Patient Management 
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC2.png)

* Appointment  Management 
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC3.png)

* Booking  
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC4.png)

* Test management 
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC5.png)

* Test to patient 
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/Rc6.png)

* Test B 
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/Rc6.png)

![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC7.png)

* Billing and payment  
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC8.png)

* payment slip
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC9.png)

* Absence
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/RC%2010.png)

* Chat Bot 
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/CH.png)

* ChatBot Workflow 
![App Screenshot](https://github.com/ShoiebAkther/Hospital-Management-System-/blob/main/BotIMAGE.png)

https://drive.google.com/file/d/1NatJPGqJQK8kimMJxGaDHZkAe5RimgSa/view?usp=sharing


