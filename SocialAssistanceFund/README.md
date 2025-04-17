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

### 2. Set Up the Database

Update the connection string in `appsettings.json` to point to your SQL Server instance.

```json
"ConnectionStrings": {
  "DefaultConnection": "YourConnectionStringHere"
}
```

Run the following commands to apply the migrations and create the database:

```bash
dotnet ef database update
```

### 3. Run the Application

Execute the following command to run the application:

```bash
dotnet run
```

Open your browser and navigate to `https://localhost:7049` to access the application.

---

## 📂 Folder Structure

- **Models/**: Contains all the entity models (e.g., `Applicant`, `County`, `SubCounty`, etc.).
- **Services/**: Contains business logic and service interfaces (e.g., `IApplicantService`, `IGeoService`).
- **Pages/**: Razor pages for user interaction, especially `ApplicantForm.razor`.
- **Data/**: Contains the `ApplicationDbContext` class for Entity Framework Core.
- **wwwroot/**: Static files and assets.

---

## 📋 Additional Details for New Developers

### Prerequisites

- .NET SDK 7.0 or later
- SQL Server or SQL Server Express
- Visual Studio 2022 or Visual Studio Code

### Setting Up the Development Environment

1. **Install .NET SDK**: Download and install the .NET SDK from the official .NET website.
2. **Install SQL Server**: Download and install SQL Server or SQL Server Express.
3. **Clone the Repository**: Clone the repository to your local machine using the command provided above.
4. **Open the Project**: Open the project in Visual Studio 2022 or Visual Studio Code.
5. **Restore NuGet Packages**: Restore the NuGet packages by building the solution or using the NuGet Package Manager.
6. **Update Database Connection**: Update the connection string in `appsettings.json` to point to your SQL Server instance.
7. **Apply Migrations**: Apply the migrations to create the database using the command provided above.
8. **Run the Application**: Run the application using the command provided above.

### Running the Application

1. **Start the Application**: Start the application by running the `dotnet run` command or by pressing F5 in Visual Studio.
2. **Access the Application**: Open your browser and navigate to `https://localhost:7049` to access the application.

### Troubleshooting

- **Database Connection Issues**: Ensure that your SQL Server instance is running and that the connection string in `appsettings.json` is correct.
- **NuGet Package Issues**: Restore the NuGet packages by building the solution or using the NuGet Package Manager.
- **Migration Issues**: Ensure that the migrations have been applied correctly by running the `dotnet ef database update` command.

### Contributing

1. **Fork the Repository**: Fork the repository to your GitHub account.
2. **Create a Branch**: Create a new branch for your feature or bug fix.
3. **Commit Your Changes**: Commit your changes with a descriptive commit message.
4. **Push to the Branch**: Push your changes to the branch on your forked repository.
5. **Create a Pull Request**: Create a pull request to merge your changes into the main repository.

### Code of Conduct

Please adhere to the project's code of conduct when contributing to this project.

### License

This project is licensed under the MIT License. See the `LICENSE` file for more information.

### 📂 Folder Structure Details

### Models

The `Models` folder contains all the entity models used in the application. These models represent the data structure and are used by Entity Framework Core to create and manage the database schema. Some of the key models include:

- `Applicant`: Represents an applicant for social assistance.
- `County`: Represents a county in the geographic hierarchy.
- `SubCounty`: Represents a sub-county within a county.
- `Location`: Represents a location within a sub-county.
- `SubLocation`: Represents a sub-location within a location.
- `Village`: Represents a village within a sub-location.
- `Sex`: Represents the sex of an applicant.
- `MaritalStatus`: Represents the marital status of an applicant.
- `SocialProgram`: Represents a social program that applicants can apply for.
- `ApplicantProgram`: Represents the many-to-many relationship between applicants and social programs.
- `Officer`: Represents an officer who collects applicant data.

### Services

The `Services` folder contains the business logic and service interfaces used in the application. These services are responsible for handling data operations and business rules. Some of the key services include:

- `IApplicantService`: Interface for managing applicants.
- `ApplicantService`: Implementation of `IApplicantService`.
- `IGeoService`: Interface for managing geographic data.
- `GeoService`: Implementation of `IGeoService`.

### Pages

The `Pages` folder contains the Razor pages used for user interaction. These pages are responsible for rendering the UI and handling user input. Some of the key pages include:

- `ApplicantForm.razor`: Page for submitting applicant information.
- `ApplicantList.razor`: Page for displaying a list of applicants.

### Data

The `Data` folder contains the `ApplicationDbContext` class, which is used by Entity Framework Core to interact with the database. This class defines the DbSet properties for each entity model and configures the database schema.

### wwwroot

The `wwwroot` folder contains static files and assets, such as CSS, JavaScript, and images. These files are served directly to the client by the web server.

---

## 🛠️ Setup Instructions (Simplified for Non-Technical Users)

### 1. Clone the Repository

1. Open a terminal or command prompt.
2. Run the following commands:

```bash
git clone https://github.com/yourusername/SocialAssistanceFund.git
cd SocialAssistanceFund
```

### 2. Set Up the Database

1. Open the `appsettings.json` file in a text editor.
2. Find the `ConnectionStrings` section and update the `DefaultConnection` value to point to your SQL Server instance. It should look something like this:

```json
"ConnectionStrings": {
  "DefaultConnection": "YourConnectionStringHere"
}
```

3. Save the file.

4. Open a terminal or command prompt and navigate to the project directory (if not already there).

5. Run the following command to apply the migrations and create the database:

```bash
dotnet ef database update
```

### 3. Run the Application

1. Open a terminal or command prompt and navigate to the project directory (if not already there).

2. Run the following command to start the application:

```bash
dotnet run
```

3. Open your web browser and go to `https://localhost:7049` to access the application.

---

## 📋 Additional Details for New Developers (Simplified for Non-Technical Users)

### Prerequisites

- .NET SDK 7.0 or later: Download and install from the official .NET website.
- SQL Server or SQL Server Express: Download and install from the official Microsoft website.
- Visual Studio 2022 or Visual Studio Code: Download and install from the official Microsoft website.

### Setting Up the Development Environment

1. **Install .NET SDK**: Download and install the .NET SDK from the official .NET website.
2. **Install SQL Server**: Download and install SQL Server or SQL Server Express.
3. **Clone the Repository**: Follow the steps provided above to clone the repository.
4. **Open the Project**: Open the project in Visual Studio 2022 or Visual Studio Code.
5. **Restore NuGet Packages**: Restore the NuGet packages by building the solution or using the NuGet Package Manager.
6. **Update Database Connection**: Update the connection string in `appsettings.json` to point to your SQL Server instance.
7. **Apply Migrations**: Apply the migrations to create the database using the command provided above.
8. **Run the Application**: Run the application using the command provided above.

### Running the Application

1. **Start the Application**: Start the application by running the `dotnet run` command or by pressing F5 in Visual Studio.
2. **Access the Application**: Open your browser and navigate to `https://localhost:7049` to access the application.

### Troubleshooting

- **Database Connection Issues**: Ensure that your SQL Server instance is running and that the connection string in `appsettings.json` is correct.
- **NuGet Package Issues**: Restore the NuGet packages by building the solution or using the NuGet Package Manager.
- **Migration Issues**: Ensure that the migrations have been applied correctly by running the `dotnet ef database update` command.

### Contributing

1. **Fork the Repository**: Fork the repository to your GitHub account.
2. **Create a Branch**: Create a new branch for your feature or bug fix.
3. **Commit Your Changes**: Commit your changes with a descriptive commit message.
4. **Push to the Branch**: Push your changes to the branch on your forked repository.
5. **Create a Pull Request**: Create a pull request to merge your changes into the main repository.

### Code of Conduct

Please adhere to the project's code of conduct when contributing to this project.

### License

This project is licensed under the MIT License. See the `LICENSE` file for more information.
