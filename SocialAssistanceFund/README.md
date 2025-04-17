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
