# Secret Squirrel Password Manager

#### By Amanda Guan, Billy Lee, and Brandon Spear

#### A Highly Secure, Reliable, and User-friendly Password Management Application

Secret Squirrel is a password management application designed to provide users with a secure platform to store and manage sensitive information, such as email credentials and passwords. With a direct database relationship, the application offers users the capability to create, edit, delete, and maintain their main accounts as well as the stored information.

## Key Features

- Robust User Account System: Create an account and manage sensitive data securely.
- Interactive User Interface: Intuitive design makes it easy to manage your sensitive information.
- Secure Database: Direct database relationship allows for secure and efficient data storage and retrieval.
- User Operations: Create, edit, delete, and maintain your account and stored information.

## Technologies Used

* C#
* .NET6
* HTML, CSS
* MySQL Workbench
* SQL Database
* AspNetCore.Mvc
* AspNetCore
* EntityFrameworkCore
* Linq
* AspNetCore.Mvc.Rendering
* AspNetCore.Mvc.Identity

## Setup/Installation Requirements

1. Clone this repository to your desktop:
    ```
    $ git clone https://github.com/BillyLee1/PasswordManager.Solution.git
    ```
2. Navigate into the 'PasswordManager' directory and run the following commands:
    ```
    $ dotnet restore
    $ dotnet build
    $ dotnet watch run
    ```
3. In the production directory, create a new file called `appsettings.json` and input your MySQL username and password. 

#### To add a migration and development server:
1. Navigate to 'PasswordManager.Solution' in your command line.
2. Run the following commands to add migration and update the database:
    ```
    $ dotnet ef migrations add Initial
    $ dotnet ef database update
    ```
3. Run `dotnet watch run` to launch the development server.

## Known Bugs

- Special characters(~`!@#$%^&*()-_+={}[]|\;:"<>,./?) break password generator if used.
- Solved Bugs: Previously encountered issues with buttons and user data storage have been fixed.

## License

Distributed under the MIT License. See `LICENSE` for more information.

Copyright (c) _2023_ _Amanda Guan_ _Billy Lee_ _Brandon Spear_
