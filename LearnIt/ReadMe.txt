

      READ ME


1) Go to Controllers/HomeController.cs
and in the method Index uncomment: DatabasePopulator.Populate(_context);
to populate the database with courses and lectures, then comment it again

2) Go to Areas/Identity/Pages/Acount/Register.cshtml.cs
and in the OnPostAsync method's user object  to false to 
create one teacher at the start, then change it back to !isTeacher