CREATE DATABASE UniversityDataBase;
USE UniversityDataBase;

-- Departments Table
CREATE TABLE Departments (
    DeptId INT PRIMARY KEY IDENTITY(1,1),
    DeptName NVARCHAR(100) NOT NULL
);

-- Courses Table
CREATE TABLE Courses (
    CourseId INT PRIMARY KEY IDENTITY(1,1),
    CourseName NVARCHAR(100) NOT NULL,
    DeptId INT
);

-- Students Table
CREATE TABLE Students (
    StudentId INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    DeptId INT
);

-- Enrollments Table
CREATE TABLE Enrollments (
    EnrollmentId INT PRIMARY KEY IDENTITY(1,1),
    StudentId INT,
    CourseId INT,
    Grade CHAR(2)
);

-- Insert Departments
INSERT INTO Departments (DeptName) VALUES ('Computer Science'), ('Mathematics'), ('Physics');

-- Insert Courses
INSERT INTO Courses (CourseName, DeptId) VALUES 
('Data Structures', 1),
('Algorithms', 1),
('Linear Algebra', 2),
('Quantum Mechanics', 3);

-- Insert Students
INSERT INTO Students (FirstName, LastName, Email, DeptId) VALUES
('Alice', 'Johnson', 'alice@uni.com', 1),
('Bob', 'Smith', 'bob@uni.com', 2),
('Charlie', 'Brown', 'charlie@uni.com', 3);

-- Insert Enrollments
INSERT INTO Enrollments (StudentId, CourseId, Grade) VALUES
(1, 1, 'A'),
(1, 2, 'B'),
(2, 3, 'A'),
(3, 4, 'C');

select * from Students;
select * from Departments;
select * from Courses;
select * from Enrollments;



create or alter procedure [dbo].[CreateDepartment]
@DeptName varchar(100)
as 
begin
declare @DeptId INT;
Insert into Departments(DeptName)
values (@DeptName);
set @DeptId = SCOPE_IDENTITY();
end;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
create or alter procedure [dbo].[GetAllDepartments]
as
begin
select *
from Departments
end;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[DeleteDepartment]
@DeptId INT
AS
BEGIN
BEGIN TRANSACTION
Delete from Departments where DeptId = @DeptId;
COMMIT TRANSACTION

END

-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
create or alter procedure [dbo].[UpdateDepartment]
@DeptID INT,
@DeptName varchar(100)
as 
begin
update Departments
set DeptName = @DeptID
where DeptID = @DeptID
end;

-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
CREATE PROCEDURE [dbo].[GetDepartmentByID]
@DeptID INT
AS 
BEGIN

SELECT * 
From Departments
WHERE DeptId = @DeptID
END

Execute dbo.GetAllDepartments
Execute dbo.DeleteDepartment 1