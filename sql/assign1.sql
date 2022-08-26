-- assignment 1
-- create 'student_db' database
-- create following tables in database with proper data types

-- student: id (PK), name, address, phone, email, age, schoolId (FK)

-- school: id (PK), name, address, principal, phone

-- create relationship as shown in the table schema

-- add some dummy data

--------------------------------------------------------------------

-- create database student_db;
-- use student_db;

-- CREATE TABLE school(
-- id int PRIMARY KEY IDENTITY(1,1),
--    name varchar(20),
--    address varchar(30),
--    principal VARCHAR(20),
--    phone INT,
--  );

-- INSERT into school 
-- values ('school1','pune','principal1',1234556789)

-- INSERT into school 
-- values ('school2','mumbai','principal2',1234556789)

-- INSERT into school 
-- values ('school3','mumbai','principal3',1234666789)

-- INSERT into school 
-- values ('school4','pune','principal4',1234577789)


-- CREATE TABLE student(
-- id int PRIMARY KEY IDENTITY (1,1),
--    name varchar(20),
--    address varchar(30),
--    phone INT,
--    email varchar(20) UNIQUE,
--    age INT,
--    schoolid INT,
--    FOREIGN KEY(schoolid) REFERENCES school(id)
--  );

-- INSERT INTO student
-- VALUES ('STUDENT1', 'PUNE',1111111111,'STUDENT1@MAIL.COM',18,1)

-- INSERT INTO student
-- VALUES ('STUDENT2', 'mumbai',1111111221,'STUDENT2@MAIL.COM',18,2)

-- INSERT INTO student
-- VALUES ('STUDENT3', 'mumbai',1144111111,'STUDENT3@MAIL.COM',18,2)

-- INSERT INTO student
-- VALUES ('STUDENT4', 'Pune',1115671111,'STUDENT4@MAIL.COM',18,4)

-- select * from school;
-- select * from student;