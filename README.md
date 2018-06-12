# CodeFirstDemo
Demo app for SysKit Dev Edu

Start by creating a new .NET Core 2.0 solution
containing a React & Redux Web Project.
Continue by adding Class Library projects: DatabaseEntities, DAL and BL. 
DatabaseEntities will be responsible for handling all the stuff connected
to Entity Framework and database. 
DAL is the only layer with direct access to DB/EF and BL will contain all
of the logic.
CodeFirstDemo handles all the View related stuff using React.


Use these:
https://weblogs.asp.net/senthil/code-first-ef-core
https://codingblast.com/entityframework-core-idesigntimedbcontextfactory/
https://joonasw.net/view/aspnet-core-2-configuration-changes

From Database:
Create a project for your new context and then:

Scaffold-DbContext "Server=(localdb)\mssqllocaldb;Database=SysKitCodeFirstDemo;Trusted_Connection=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

Add-Migration InitialCreate –IgnoreChanges
EF Core doesn't have it so initial migration is filled and update breaks. Comment it out. 

Additionally, we need to register our new context in startup.
After that, Package Manager needs explicit reference to context
Update-Database -Context SysKitCodeFirstDemoContext
