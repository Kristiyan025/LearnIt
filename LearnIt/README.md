# Intitial Configuration

1)First of all, check if your Visual Studio has thee following 
packages installed in `Visual Studio Installer`:
```
ASP.NET and web development (for using Entity Framework)
Data storage and processing (for connecting with SQL Server)
.NET cross-platform development
```
If you don't have any of them, install them and then continue.

2) Make sure in the _appsettings.json_ file the `Server` property of 
the `DefaultConnection` string works for your machine and connects correctly
with __SQL Server__

3)If the application starts properly, you can skip this step.
Else, you could try creating the database manually in __SQL Server__
(just create a new database with name _LearnIt_), if it's not created, and open the 
`Package Manager Console` in VS and run the following commands one after another:
```
add-migration InitializeDatabaseFix
update-database
```

4) Go to _Controllers/HomeController.cs_
and in the method `Index` uncomment: `DatabasePopulator.Populate(_context);`
to populate the database with courses and lectures, then comment it again

5) Go to _Areas/Identity/Pages/Acount/Register.cshtml/Register.cshtml.cs_
and in the `OnPostAsync` method change the last property (`!isTeacher`)
of the `user` object  to `false` to be able to create one teacher 
at the start, then change it back to `isTeacher`

6) Launch the project in Visual Studio and when the main page has loaded
undo Steps 3) and 4) and the project is ready to use