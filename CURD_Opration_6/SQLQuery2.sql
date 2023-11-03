Create Database School;
USE School;

Create Table Student 
(
  Id int Primary Key Identity,
  Name Varchar(50),
  Age int,
  Gender Varchar(10),
  Standard int
)

Select * from Student;

Insert Into Student (Name,Age,Gender,Standard) Values('Jack',18,'Male',12);