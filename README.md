# College Management System

Welcome to the College Management Services project, an MVC web application designed to manage various aspects of a college environment including staff tasks, student duties, and a gaming platform.

## Installation

To install and run this project locally, follow these steps:

1. Clone this repository to your local machine.
2. Ensure you have [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0) installed on your machine.
3. Navigate to the project directory using the command line.
4. Apply database migrations by running `update data-base` in the command line.
5. Start the application.
6. Access the application in your web browser.

This process ensures that the project is set up correctly on your local machine and is ready to run using .NET 8. If you encounter any issues during the installation process, refer to the project documentation or seek assistance from the project contributor.

## Features

### Staff Management

- Staff members can create new accounts or authenticate existing ones.
- Staff IDs must follow a specific format.
- Tasks are displayed in a table with task code, description, location, and status.
- Staff can perform CRUD operations on tasks.

### Student Management

- Students can create new accounts or authenticate existing ones.
- Student IDs must follow a specific format.
- Duties are displayed in a table with duty code, description, and status.
- Students can perform CRUD operations on duties.

### Gamer Platform

- Gamers can create new accounts or authenticate existing ones.
- Gamer IDs must follow a specific format.
- A single-page Tic Tac Toe game is available.
- Gameplay includes marking cells, displaying whose turn it is, and determining the winner or a tie.
- Option to start a new game.

### General

- Each user has the option to log out and return to the homepage.

## Usage

1. Navigate to the homepage of the College Management Services application.
2. Choose between Staff, Student, or Gamer tabs.
3. Follow the prompts to create a new account or log in with existing credentials.
4. Access the respective portal and utilize the available features.
5. Log out when done to return to the homepage.

## Technologies Used

- .NET 8
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server 
- HTML
- CSS
- JavaScript

### Deployment

This application is also deployed on Microsoft Azure. You can visit the deployed version of the app [here](https://collegemanagementsystem.azurewebsites.net/)

Feel free to explore the deployed version to see the application in action!
