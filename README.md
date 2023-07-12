# Secret_Squirrel_Password_Manager

#### By Amanda Guan, Billy Lee, and Brandon Spear

#### Brief Description of Application

Application allows users to create an account, and store sensitive emails and passwords within.


## Technologies Used

* _C#_
* _.NET6_
* _HTML_
* _CSS_
* _MySQLWorkbench_
* _SQL Database_
* _AspNetCore.Mvc_
* _AspNetCore_
* _EntityFrameworkCore_
* _Linq_
* _AspNetCore.Mvc.Rendering_
* _AspNetCore.Mvc.Identity_

## Description

Users will be able to create, edit, delete, and maintain main account and stored information using a direct database relationship.

## Setup/Installation Requirements

- Clone this repository to your desktop:

```
    $ git clone https://github.com/BillyLee1/PasswordManager.Solution.git
```

- Navigate to the PasswordManager directory on your desktop and open the cloned directory with your favorite text editor (Visual Studio Code was used when setting this project up).

- Navigate into the PasswordManager production directory and run the code:

```
    $ dotnet restore
```

- Within the production directory, create a new file called `appsettings.json`.

- Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL Workbench. Please install MySQL Workbench if not already installed on your local machine.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR_DATABASE_NAME];uid=[YOUR_ID];pwd=[YOUR_PASSWORD];"
  }
}
```

#### To add a migration and development server:_
* _Navigate to 'PasswordManager.Solution' in your command line_
* _From there navigate to 'PasswordManager'_
* _Run the command "dotnet build"_
* _Run the command "dotnet tool install --global dotnet-ef --version 6.0.0"_
* _Run the command "dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0"_
* _Run the command dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0_
* _Run the command "dotnet ef migrations add Initial"_
* _Run "dotnet ef database update" in your command line._
* _Then run the command "dotnet watch run"_

- To launch the project, run the following codes in the production directory:

```
    $ dotnet build
```

```
    $ dotnet watch run
```

## Known Bugs

- Special characters(~`!@#$%^&*()-_+={}[]|\;:"<>,./?) break password generator if used.
- Buttons giving problems and breaking one after another. *fixed*
- Accounts, emails, and passwords being saved in all users accounts. *fixed by making an async function*

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _2023_ _Amanda Guan_ _Billy Lee_ _Brandon Spear_
