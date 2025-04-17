# Social Assistance Fund Application

This is a Blazor Server web application designed to manage social assistance applicants, their geographic data, and the social programs they apply for. It features form submission, location-based cascading dropdowns, and program tracking.

## 🏗️ Project Structure

- **Models/** – Contains all the entity models (e.g., `Applicant`, `County`, `SubCounty`, etc.).
- **Services/** – Contains business logic and service interfaces (e.g., `IApplicantService`, `IGeoService`).
- **Pages/** – Razor pages for user interaction, especially `ApplicantForm.razor`.
- **Data/** – Contains the `ApplicationDbContext` class for Entity Framework Core.
- **wwwroot/** – Static files and assets.

## ✅ Features

- Applicant registration form with:
  - Full name, sex, age, marital status
  - Identity details and contact info
  - Cascading geo-location fields: County → SubCounty → Location → SubLocation → Village
- EF Core database integration with migration support
- Dropdowns populated dynamically from reference tables
- Program selection support (many-to-many)
- Clean UI with validation and error handling

---

## 🔧 Technologies Used

- .NET 7 / 8 (Blazor Server)
- Entity Framework Core
- SQL Server
- Bootstrap (optional)
- C#

---

## 🛠️ Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/SocialAssistanceFund.git
cd SocialAssistanceFund
```

### 2. Install Required Software

#### Install .NET SDK

Download and install the .NET SDK from the official website: https://dotnet.microsoft.com/download

#### Install SQL Server

Download and install SQL Server from the official website: https://www.microsoft.com/en-us/sql-server/sql-server-downloads

#### Install Visual Studio

Download and install Visual Studio from the official website: https://visualstudio.microsoft.com/

### 3. Configure the Database Connection String

Open the `SocialAssistanceFund/appsettings.json` file and update the `DefaultConnection` string with your SQL Server instance details:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=YOUR_SQL_SERVER_INSTANCE;Initial Catalog=SocialAssistance1;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
  }
}
```

### 4. Run Database Migrations

Open a terminal or command prompt in the project directory and run the following commands to apply the database migrations:

```bash
dotnet ef database update
```

### 5. Run the Application

#### Using Visual Studio

1. Open the `SocialAssistanceFund.sln` solution file in Visual Studio.
2. Set `SocialAssistanceFund` as the startup project.
3. Press `F5` to build and run the application.

#### Using .NET CLI

Open a terminal or command prompt in the project directory and run the following command:

```bash
dotnet run
```

The application will start, and you can access it in your web browser at `https://localhost:7049` or `http://localhost:5039`.
