# Intitial Configuration

1) First of all, check if your Visual Studio has the following 
packages installed in `Visual Studio Installer`:
```
ASP.NET and web development (for using Entity Framework)
Data storage and processing (for connecting with SQL Server)
.NET cross-platform development
```
If you don't have any of them, install them and then continue.

2) Make sure in the _appsettings.json_ file the `Server` property of 
the `DefaultConnection` string works for your machine and connects correctly
with __SQL Server__.

3) If the application starts properly, you can skip this step.
Else, you could try creating the database manually in __SQL Server__
(just create a new database with name _LearnIt_), if it's not created, and open the 
`Package Manager Console` in VS and run the following commands one after another:
```
add-migration InitializeDatabaseFix
update-database
```

4) Go to _Controllers/HomeController.cs_
and in the method `Index` uncomment: `DatabasePopulator.Populate(_context);`
to populate the database with courses and lectures, then comment it again.
![HomeController before change](./wwwroot/images/doc/db-before.png)
![HomeController after change](./wwwroot/images/doc/db-after.png)

5) Launch the project in Visual Studio and when the main page has loaded, 
close the webpage and undo Step 4).

6) Go to _Areas/Identity/Pages/Acount/Register.cshtml/Register.cshtml.cs_
and in the `OnPostAsync` method change the last property (`!isTeacher`)
of the `user` object  to `false` to be able to create one teacher 
at the start, then change it back to `isTeacher`.
![Register before change](./wwwroot/images/doc/account-before.png)
![Register after change](./wwwroot/images/doc/account-after.png)

7) Launch the project in Visual Studio, go to the _Register_ page, register a teacher, 
close the webpage and undo Step 6) and the project is ready to use.