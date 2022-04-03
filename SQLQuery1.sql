create table Tasks(
Id int primary key identity(1,1),
TaskName nvarchar(50),
Difficulty int,
)



create table Employees(
  Id int primary key identity(1,1),
  FirstName nvarchar(50),
  LastName nvarchar(50),
  Point int,
  TaskId int,
  Foreign key(TaskId) references Tasks(Id),

)