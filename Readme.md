# MusiMe

####
This is a Music application backend .net version 8 project. This application will have the music and the user management data (To store the artist and music data). For database postgerSQL have been used.
####

Initial steps:

First create the database migration. To do that, go to the MusiMe.Infrastructure and run the following command.

In VSCode: open terminal and route to the MusiMe.Infrastructure directory. and run the command.
```bash
dotnet ef migration add <Migration name> --startup-project ../MusiMe/MusiMe.csproj
```
To create the tables in the database run the command
```bash
dotnet ef database update --startup-project ../MusiMe/MusiMe.csproj
```
In Visual Studio: Open the Package Manager terminal and run the command.
```bash
Add-Migration NewMigration -Project ../Musime.Infrastructure/MusiMe.Infrastructure.csproj
```
To create the tables in the database run the command
```bash
Update-Database
```