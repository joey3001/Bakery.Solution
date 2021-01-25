# Joe's Bakery Database

#### 1/18/2021

### 📖 Description

This application utilizes the Entity framework to setup and manipulate an SQL database. It also uses the Identity framework to allow users to create accounts, log in, and log off. Certain features, such as creating, editing, & deleting new database entries, are restricted to users with accounts. In particular, this app will allow you to set up a many-to-many relationship between two classes, with both sides of the relationship viewable from either class. All CRUD methods are also implemented for both classes. 

#### By Joseph Nero 

## 🔧 Setup/Installation Requirements
#### If you have difficulty following any of the steps/instructions listed below, please contact me at josephnero111@gmail.com 

1. Git Bash (or another terminal program) & Git.  
    - To clone the repository from Github using git commands in the terminal, you need a terminal program & Git. For Windows OS, I recommend the Git Bash terminal program. Installing Git Bash will also install Git. 

2. VSCode (or another code editor)
    - To view/edit this code, you need a code editor. I recommend VSCode. 

3. For Detailed instructions on how to install Git Bash & VSCode, visit the Setup/Installation Requirements section of the README for [this repo.](https://github.com/joey3001/first-friday-project)

4. C# & .NetCore
    - To run this project you will need C# & .NET Core. You can check if you have these installed by entering the following command into your terminal program :

            dotnet --version 

    - if C# & .NET Core are downloaded, the .NET Core version number will be presented. An example of this is as follows : 

            2.2.203

    - If no version number is presented, visit [this website](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer) to download C# & .NET Core. Once the download is complete, you can execute "dotnet --version" in your terminal again to verify its successful installation. 

5. dotnet script REPL
    - The dotnet script REPL allows you to run compiled code one line at a time. To install dotnet script enter the following command into your terminal program (only do this after completing the above step) : 

            dotnet tool install -g dotnet-script

6. MySQL & MySQL Workbench
    - MySQL is an open-source relational database management system. MySQL Workbench is a visual database design tool for the MySQL database system.You can download them both [here.](https://dev.mysql.com/downloads/file/?id=484919)

#### To clone this project using git commands in the terminal : 

1. Open your terminal program and use the cd command to navigate to the directory in which you wish to clone this project. 
2. Use [this link](https://github.com/joey3001/Bakery.Solution) go to this project's repository on github. Click on the green button labeled "code" towards the right side of the page's center. Click on the HTTPS option and copy the presented URL. 
3. Use the following command in your terminal program to clone the repo :

            git clone https://github.com/joey3001/Bakery.Solution

#### To set up the Database and run the project using terminal commands, follow the instructions below : 

1. In the "Bakery" directory, update the text in the appsettings.json file to include your MySQL password. You should have made this password when you downloaded/setup MySQL & MySQL workbench. An example is included below : 

            {
              "ConnectionStrings": {
                  "DefaultConnection": "Server=localhost;Port=3306;database=joseph_nero;uid=root;pwd=Your_Password_Here;"
              }
            }

2. Use the following command in your terminal program to restore the dependencies and tools of the project : 

            dotnet restore

3. Use the following command in your terminal program to setup the Database : 

            dotnet ef database update

4. Use the following command in your terminal program to compile the code : 

            dotnet build 

5. Next, use the following command in your terminal program to execute the compiled code : 

            dotnet run 

6. If you update the structure of the database, use the following command in your terminal program to add a migration : 

            dotnet ef migrations add "The title of your migration"

#### To view the code in the VSCode editor using commands in the terminal :  

1. Navigate to the project's root directory with the cd command. 

2. Once you are within the project's root directory, enter the following command into your terminal program to view all of the project's code in VSCode : 

            code . 

#### To download a file containing the contents of this repository to a location of your choice :  

1. Use a web browser to go to the repository webpage at [this link.](https://github.com/joey3001/Bakery.Solution)
2. Click on the green button labeled "code" towards the right side of the page's center. In the drop-down menu that opens, click on the button labeled "Download Zip."
3. Once your download is complete, open the zipped file. Click on the button labeled "Extract All" at the top of your file explorer. 
4. Choose the location in which you want to extract the files, and navigate to that location once this process is complete. 

## 🐛 Known Bugs

No known bugs are present at this time. 

## 📫 Support and contact details

If you have an issue, reach out to me at josephnero111@gmail.com

## 🛠️ Technologies Used

  * C# V7.3
  * MySQL & MySQL Workbench 
  * Entity Framework
  * Identity Framework
  * .NET Core V2.2
  * dotnet script REPL
  * VSCode 
  * Git
  * Github 
  * Git Bash

### 📘 License

[MIT License](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 Joseph Nero 
