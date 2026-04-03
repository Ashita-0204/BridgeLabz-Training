/* =========================================================
   DATABASE CREATION (DDL)
  ========================================================= */

IF DB_ID('CollegeeDB') IS NULL
BEGIN
    CREATE DATABASE CollegeeDB;
END
GO

USE CollegeeDB;
GO


/* =========================================================
   DROP TABLES (ORDER MATTERS DUE TO FK)
  ========================================================= */

DROP TABLE IF EXISTS Enrollments;
DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Departments;

DROP TABLE IF EXISTS Student_1NF;
DROP TABLE IF EXISTS Student_2NF;
DROP TABLE IF EXISTS Department_3NF;
DROP TABLE IF EXISTS Teacher_Subject_BCNF;
GO


/* =========================================================
   CREATE TABLE : Departments
  ========================================================= */

CREATE TABLE Departments (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50) UNIQUE NOT NULL
);
GO


/* =========================================================
   CREATE TABLE : Students
  ========================================================= */

CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    DeptID INT,
    FOREIGN KEY (DeptID) REFERENCES Departments(DeptID)
);
GO


/* =========================================================
   CREATE TABLE : Courses
  ========================================================= */

CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50) NOT NULL,
    DeptID INT,
    FOREIGN KEY (DeptID) REFERENCES Departments(DeptID)
);
GO


/* =========================================================
   CREATE TABLE : Enrollments (COMPOSITE KEY)
  ========================================================= */

CREATE TABLE Enrollments (
    StudentID INT,
    CourseID INT,
    Semester VARCHAR(20),
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
GO


/* =========================================================
   INSERT DATA
  ========================================================= */

INSERT INTO Departments VALUES
(1, 'Computer Science'),
(2, 'Mechanical'),
(3, 'Electrical');

INSERT INTO Students VALUES
(101, 'Ravya', 'ravya@gmail.com', 1),
(102, 'Kavya', 'kavya@gmail.com', 1),
(103, 'Lavya', 'lavya@gmail.com', 2);

INSERT INTO Courses VALUES
(201, 'DBMS', 1),
(202, 'Operating Systems', 1),
(203, 'Thermodynamics', 2);

INSERT INTO Enrollments VALUES
(101, 201, 'Sem 8'),
(101, 202, 'Sem 8'),
(102, 201, 'Sem 8'),
(103, 203, 'Sem 8');
GO


/* =========================================================
   SELECT QUERIES
  ========================================================= */

SELECT * FROM Students;

SELECT * 
FROM Students 
WHERE DeptID = 1;

SELECT * 
FROM Students 
ORDER BY StudentName;

SELECT DeptID, COUNT(*) AS TotalStudents
FROM Students
GROUP BY DeptID;
GO


/* =========================================================
   JOINS
  ========================================================= */

SELECT s.StudentName, c.CourseName
FROM Students s
INNER JOIN Enrollments e ON s.StudentID = e.StudentID
INNER JOIN Courses c ON e.CourseID = c.CourseID;

SELECT s.StudentName, e.CourseID
FROM Students s
LEFT JOIN Enrollments e ON s.StudentID = e.StudentID;
GO


/* =========================================================
   UPDATE & DELETE
  ========================================================= */

UPDATE Students
SET Email = 'ravya_new@gmail.com'
WHERE StudentID = 101;

DELETE FROM Enrollments
WHERE StudentID = 102 AND CourseID = 201;
GO


/* =========================================================
   TRANSACTIONS (TCL)
  ========================================================= */

BEGIN TRANSACTION;
INSERT INTO Students VALUES (104, 'David', 'david@gmail.com', 3);
ROLLBACK;

BEGIN TRANSACTION;
INSERT INTO Students VALUES (105, 'Eva', 'eva@gmail.com', 2);
COMMIT;
GO


/* =========================================================
   NORMALIZATION TABLES
  ========================================================= */

-- 1NF: Atomic values
CREATE TABLE Student_1NF (
    StudentID INT,
    StudentName VARCHAR(50),
    Course VARCHAR(50)
);

-- 2NF: Remove partial dependency
CREATE TABLE Student_2NF (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(50)
);

-- 3NF: Remove transitive dependency
CREATE TABLE Department_3NF (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

-- BCNF: Every determinant is a candidate key
CREATE TABLE Teacher_Subject_BCNF (
    Teacher VARCHAR(50) PRIMARY KEY,
    Subject VARCHAR(50)
);
GO
