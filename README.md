Step 1: Create an empty database in MsSQLServer

Step 2 : Open MyDbContext.cs file in catalog Entities

Step 3: Find line: "string baza = "Data Source=SQLSERVERNAME;Initial Catalog=DATABASENAME;Integrated Security=True";"

Replace 'SQLSERVERNAME' with your SQL server and 'DATABASENAME' with database name that you created in step 1

Step 4: Open NuGet Package Manager Console and write command: 'add-migration "MIGRATION_NAME"', then write command 'update-database'

Step 5: Run project
