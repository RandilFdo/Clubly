# Clubly

Clubly is a modern desktop application designed to help users efficiently manage clubs, tasks, and events. With a sleek user interface and robust backend, it provides an intuitive way to organize and track club-related activities.

---

## Features

- **Club Management**: Add, edit, and delete clubs with details like name, category, description, and upcoming events.
- **Task Management**: Create, update, and organize tasks with priorities, due dates, and club associations.
- **Calendar Integration**: View and manage events in a visually appealing calendar interface.
- **Personalization**: Customize the theme color to suit your preferences.
- **Database Integration**: Data is securely stored in a SQL Server LocalDB database.
- **User-Friendly Interface**: Built with Guna UI2 for a modern and intuitive design.

---

## Getting Started

### Prerequisites

- **Visual Studio 2022** (or later)
- **.NET 9 SDK**
- **SQL Server LocalDB** (installed with Visual Studio)

### Installation

1. Clone the repository:

   ```sh
   git clone https://github.com/RandilFdo/Clubly.git
   ```

2. Open the solution in Visual Studio:

   ```sh
   ClubManager.sln
   ```

3. Restore NuGet packages:

   - Go to **Tools** → **NuGet Package Manager** → **Manage NuGet Packages for Solution** → Restore.

4. Build the solution:

   - Press **Ctrl + Shift + B** or go to **Build** → **Build Solution**.

---

## Database Setup

The application uses **Entity Framework Core** with SQL Server LocalDB. Follow these steps to set up the database:

1. Open the **Package Manager Console** in Visual Studio:

   - **Tools** → **NuGet Package Manager** → **Package Manager Console**

2. Run the following commands:

   ```powershell
   Add-Migration InitialCreate
   Update-Database
   ```

   This will create the database and tables.

3. Verify the database:

   - Open **SQL Server Object Explorer** in Visual Studio.
   - Expand **(localdb)\mssqllocaldb** → **Databases** → **ClubManagerDb**.

---

## Usage

### 1. Launch the Application

- Run the application from Visual Studio or the executable file.

### 2. Manage Clubs

- Navigate to the **Clubs** section to add, edit, or delete clubs.

### 3. Manage Tasks

- Go to the **Tasks** section to create tasks, assign them to clubs, and set priorities.

### 4. View Calendar

- Access the **Calendar** to view and manage upcoming events.

### 5. Personalize Your Experience

- Open the **Settings** section to change the theme color.

---

## Screenshots

### Home Page

![Home Page](https://via.placeholder.com/800x400?text=Home+Page+Screenshot)

### Task Management

![Task Management](https://via.placeholder.com/800x400?text=Task+Management+Screenshot)

### Calendar

![Calendar](https://via.placeholder.com/800x400?text=Calendar+Screenshot)

---

## Technologies Used

- **C#**: Core programming language
- **.NET 9**: Framework for building the application
- **Entity Framework Core**: ORM for database management
- **SQL Server LocalDB**: Database for storing application data
- **Guna UI2**: Modern UI components for a sleek design

---

## Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new branch:

   ```sh
   git checkout -b feature/your-feature-name
   ```

3. Commit your changes:

   ```sh
   git commit -m "Add your message here"
   ```

4. Push to the branch:

   ```sh
   git push origin feature/your-feature-name
   ```

5. Open a pull request.

---

## License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

## Contact

For any inquiries or support, feel free to reach out:

- **Author**: Randil Fernando
- **GitHub**: [RandilFdo](https://github.com/RandilFdo)
- **Email**: randil@example.com
