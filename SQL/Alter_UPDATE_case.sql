--DDL commands (Data Definition Language)
--DROP
--TRUNCATE 
--CREATE 
--ALTER
--GRANT
--REVOKE
-------------------------------------------------------------------------------------------------------------------------
-- DROP(DDL)
-- DROP A TABLE
-- DROP A COLUMN
-- DROP A VIEW
-- DROP AN INDEX
-- DROP A STORED PROCEDURE
-- DROP A TRIGGER
-- DROP A USER-DEFINED FUNCTION

--DROP A TABLE
drop table Sheet1$	-- to drop a table drop command is directly used

--DROP A COLUMN
alter table Sheet1$ drop column name
-- is a error alter table Sheet1$ drop row -- is a error
--drop cannot be used to drop a row using delete

--DROP A VIEW
DROP VIEW view_name;

--DROP AN INDEX
DROP INDEX index_name ON table_name;

--DROP A STORED PROCEDURE
DROP PROCEDURE procedure_name;

--DROP A TRIGGER
DROP TRIGGER trigger_name ON table_name;

--DROP A USER-DEFINED FUNCTION
DROP FUNCTION function_name;

--truncate or drop does not allow where clause
-------------------------------------------------------------------------------------------------------------------------
--TRUNCATE(DDL)
TRUNCATE TABLE
-------------------------------------------------------------------------------------------------------------------------
-- CREATE(DDL)
-- CREATE A DATABASE
-- CREATE A TABLE
-- CREATE A VIEW

--Create a new database: You can use the CREATE DATABASE command to create a new database in SQL Server.
--CREATE A DATABASE
--SYNTAX
CREATE DATABASE DATABASE_NAME
--Creating a database
CREATE DATABASE SALES

--Create a new table: You can use the CREATE TABLE command to create a new table in a database. You can specify the table schema, column names, data types, and any constraints on the table.
--CREATE A TABLE
--SYNTAX
CREATE TABLE TABLE_NAME(
COLUMN1 DATATYPE,
COLUMN2 DATATYPE,
COLUMN3 DATATYPE,
COLUMN4 DATATYPE
)
--Creating a table
CREATE TABLE SALES(
product_id int,
product_name varchar(20),
Price int,
Quantity int
)

--Create a new view: You can use the CREATE VIEW command to create a new view in a database. A view is a virtual table that is based on the result of a SELECT statement.
--CREATE A VIEW
--SYNTAX
CREATE VIEW my_view
AS
SELECT column1, column2
FROM my_table
WHERE column3 = 'some_value';

--Creating a view
ALTER VIEW studentOfmkpit
AS
SELECT Name,Address
from student
where Course = 'DotNet'
select * from students_mkpits 

select * from studentOfmkpit
select * from student
select * from students_mkpits

--alter view input
--as
--update input
--set City = 'Mumbai'
--where City = 'Amravati'
--In SQL, views are read-only, and therefore cannot be directly modified

select * from input
-------------------------------------------------------------------------------------------------------------------------
create procedure accent
as
begin
select s.*,std.* from students_mkpits s join student std on s.roll_no = std.SrNo
end
exec accent
drop procedure accent
select * from students_mkpits

--A stored procedure is a precompiled set of SQL statements that is stored in the database and can be executed on demand
--by calling its name.
--A stored procedure can return multiple result sets, output parameters, or a return value
-------------------------------------------------------------------------------------------------------------------------
--ALTER FUNCTIONS
--Modifying a table - You can add, modify, or delete columns, change column data types, set or modify constraints, and modify table properties.
-- TO ADD A COLUMN
-- TO MODIFY A COLUMN
-- DELETING A COLUMN USING ALTER
-- ADDING A COLUMN TO SET A DEFAULT VALUES
-- ADDING A CONSTRAINT PRIMARY KEY
-- ADDING A CONSTRAINT NOT NULL TO THE COLUMN


-- TO ADD A COLUMN
--SYNTAX
ALTER TABLE table_name
add column_name data_type
--Column 'Marks' will be added
ALTER TABLE Sheet1$
add Marks int

--TO MODIFY A COLUMN
--SYNTAX
ALTER TABLE table_name
ALTER COLUMN column_name new_data_type;
--column 'Marks' is modified
ALTER TABLE Sheet1$ 
ALTER COLUMN Marks dec(10,2) 

--DELETING A COLUMN USING ALTER
--SYNTAX
ALTER TABLE TABLE_NAME
DROP COLUMN COLUMN_NAME
--column 'F6' is deleted using drop in alter
ALTER TABLE Sheet1$
drop column F6

--ADDING A COLUMN TO SET A DEFAULT VALUES
--SYNTAX
ALTER TABLE TABLE_NAME
ADD COLUMN_NAME DATATYPE IDENTITY
-- add column 'RollNo' having default(identity) rollno 
alter table Sheet1$
add RollNo int identity

exec sp_help Sheet1$

--ADDING A CONSTRAINT PRIMARY KEY
--SYNTAX
ALTER TABLE TABLE_NAME
ADD CONSTRAINT CONSTRAINT_NAME PRIMARY KEY (COLUMN_NAME)
-- add constraint primary key to RollNo
ALTER TABLE Sheet1$
ADD CONSTRAINT PK_Sheet1$ primary key (RollNo)

--ADDING A CONSTRAINT NOT NULL TO THE COLUMN
--SYNTAX
ALTER TABLE TABLE_NAME
ALTER COLUMN COLUMN_NAME DATATYPE NOT NULL
--add not null to Roll no 
ALTER TABLE Sheet1$
ALTER COLUMN RollNo int not null

--ALTER TABLE Sheet1$: This part of the statement specifies the name of the table (or worksheet in this case) that you want to modify.

--ALTER COLUMN grade: This part of the statement specifies the name of the column that you want to modify.

--INT: This specifies the new data type for the column. In this case, it's INT (short for integer).

--NOT NULL: This specifies that the "grade" column should not allow NULL values.

exec sp_help Sheet1$

-------------------------------------------------------------------------------------------------------------------------

--DELETE FUNCTIONS
select * from student
select * from students_mkpits

--(1)
--SYNTAX
DELETE TABLE_NAME
--Delete all rows: You can use the DELETE command without a WHERE clause to delete all rows from a table.
delete students_mkpits
--delete all rows from students_mkpits table

--(2)
--SYNTAX
DELETE FROM TABLE_NAME WHERE CONDITION
--Delete specific rows: You can specify a WHERE clause in the DELETE statement to delete only the rows that match a certain condition.
delete from student where SrNo = 6 
--delete specific row from students_mkpits using where 

--(3)
--SYNTAX
--DELETE ALIAS_OF_TABLE(VALUES OF WHICH YOU WANT TO DELETE)
--Delete rows from multiple tables: You can use the DELETE command with a JOIN clause to delete rows from multiple tables at once.
Delete s from students_mkpits s join student std on s.roll_no = std.SrNo where s.roll_no = 1 and std.SrNo = 1
--roll_no of students_mkpits = 1 is only deleted, only the values of the table is deleted if the its name is assigned after Delete

Delete s from students_mkpits s join student std on s.roll_no = std.SrNo where std.SrNo = 2 and s.roll_no = 2 
--roll_no of students_mkpits = 2 is only deleted, only the values of the table is deleted if the its name is assigned after Delete

Delete std from students_mkpits s join student std on s.roll_no = std.SrNo where std.SrNo = 3 and s.roll_no = 3 
--std.SrNo of students = 3 is only deleted, only the values of the table is deleted if the its name is assigned after Delete std

Delete std from student std join students_mkpits s on std.SrNo = s.roll_no where std.SrNo = 4 and s.roll_no = 4
--std.SrNo of students = 4 is only deleted, only the values of the table is deleted if the its name is assigned after Delete std

DELETE std
FROM student std
LEFT JOIN students_mkpits s ON std.SrNo =  s.roll_no 
WHERE std.SrNo = 5;
--std.SrNo of students = 5 is only deleted, only the values of the table is deleted if the its name is assigned after Delete std


DELETE s
FROM student std
LEFT JOIN students_mkpits s ON std.SrNo =  s.roll_no 
WHERE std.SrNo = 6;
--s.students_mkpits of students = 6 is only deleted, only the values of the table is deleted if the its name is assigned after Delete s


insert into student values(6,'Bharat','Pune','Java',24)
insert into student values(5,'Mayuri','Nagpur','DotNet',22)
insert into student values(4,'Mahima','Nagpur','DotNet',21)
insert into student values(3,'Bharti','Nagpur','Java',25)
insert into students_mkpits values(1,'Shreya','Dakhale','DotNet','Nagpur','Maharashtra',99,'Distinction')
insert into students_mkpits values(2,'Mahima','Barde','DotNet','Nagpur','Maharashtra',100,'Distinction')

--(4)
--Delete rows and return a result set: You can use the OUTPUT clause in the DELETE statement to return a result set that shows the rows that were deleted.
DELETE FROM students_mkpits
OUTPUT deleted.*
WHERE roll_no = 5;

select * from student
select * from students_mkpits

INSERT INTO students_mkpits (roll_no, first_name, last_name, course, city, state, Marks, Designations) 
VALUES
(1, 'John', 'Doe', 'Science', 'New York', 'Java', 80, 'Intern'),
(2, 'Jane', 'Smith', 'Math', 'Los Angeles', 'DotNet', 90, 'Analyst'),
(3, 'Mike', 'Johnson', 'English', 'Chicago', 'Java', 75, 'Manager'),
(4, 'Sara', 'Lee', 'History', 'Houston', 'DotNet', 85, 'Coordinator'),
(5, 'David', 'Kim', 'Art', 'San Francisco', 'DotNet', 95, 'Director'),
(6, 'Amy', 'Chen', 'Music', 'Seattle', 'Java', 70, 'Consultant');

--delete table students_mkpits where roll_no = 1
DELETE FROM students_mkpits WHERE roll_no = 1;

ALTER TABLE students_mkpits
DROP CONSTRAINT PK__studentL__28B564057727162C;
--to drop a constraint

SELECT CONSTRAINT_NAME
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'students_mkpits' AND CONSTRAINT_TYPE = 'PRIMARY KEY';
--to check exactlye which constraint is it

ALTER TABLE students_mkpits
ADD CONSTRAINT PK_students_mkpits PRIMARY KEY (roll_no);
--to add a primary key constraint

SELECT CONSTRAINT_NAME
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME = 'students_mkpits' AND CONSTRAINT_TYPE = 'PRIMARY KEY';

--truncate or drop does not allow where clause

--(5)
--Delete rows in batches: You can use the TOP clause in the DELETE statement to delete rows in batches of a certain size, which can help to improve performance and reduce transaction log growth.
DECLARE @BatchSize INT = 1;

WHILE 1=1
BEGIN
    DELETE TOP (@BatchSize) FROM Sheet1$ WHERE gender = 'Null';
    IF @@ROWCOUNT < @BatchSize BREAK;
END

select * from Sheet1$

--column havin a null value will be deleted
DELETE FROM Sheet1$ WHERE name IS NULL;

--(6)
--Delete rows and insert them into another table: You can use the OUTPUT clause with the INTO keyword to delete rows from one table and insert them into another table at the same time.
DELETE FROM Sheet1$
OUTPUT deleted.name, deleted.age INTO student(Name, age)
WHERE name = 'Jane Doe';

select * from student
select * from Sheet1$

-------------------------------------------------------------------------------------------------------------------------------
select * from Sheet1$

--UPDATE FUNCTIONS
--Change the value of a single column: You can use the UPDATE command to change the value of a single column in one or more rows of a table.
--SYNTAX
-----------------------------------------------------------
--UPDATE TABLE_NAME
--SET COLUMN_NAME = OLD_VALUE WHERE COLUMN_NAME = NEW_VALUE

--UPDATING VALUES IN THE TABLE OF A COLUMN
update Sheet1$
set gender = 'Male' where gender = 'M'


--//////////////////////////////////////////////////////////
--Change the value of multiple columns: You can also use the UPDATE command to change the values of multiple columns in one or more rows of a table.
update Sheet1$
set gender = 'Female', name = 'Jada Smith'
where gender = 'M' and name = 'John Smith'

--SYNTAX
--UPDATE TABLE_NAME
--SET COLUMN_NAME = OLD_VALUE,COLUMN_NAME1 = OLD_VALUE
--WHERE COLUMN_NAME = NEW_VALUE AND/OR COLUMN_NAME1 = NEW_VALUE

UPDATE Sheet1$
SET gender = 'F',name = 'Jada Smith'
where gender = 'Female' AND name = 'Jada Smith'

--------------------------------------------------------CASE-------------------------------------------------------------------
UPDATE Sheet1$
SET gender = 
    CASE 
        WHEN gender = 'F' THEN 'Male'
        WHEN gender = 'M' THEN 'Female'
        ELSE gender
    END
WHERE gender IN ('F', 'M');


select * from Sheet1$
drop table Sheet1$

--Update rows based on a condition: The UPDATE command allows you to update only those rows that meet a specified condition. This is done using the WHERE clause in the UPDATE statement.
update Sheet1$
set name = 'Jasminder Kaur' where name = 'Jane Doe' 

--UPDATING ROW BASED ON A JOIN
--Update rows based on a join: You can also use the UPDATE command to update rows in one table based on the values in another table. 
--This is done using the JOIN clause in the UPDATE statement.

UPDATE table1
SET column1 = table2.column1
FROM table1
JOIN table2 ON table1.key = table2.key
WHERE table1.column2 = 'value';

--Update rows using subqueries: The UPDATE command can also be used to update rows in a table using subqueries. This allows you to update rows based on values from other tables or complex conditions.
--Update rows with values from another column: You can use the UPDATE command to update rows with values from another column in the same table. This is done using the SET clause in the UPDATE statement.

select * from Sheet1$
select * from students_mkpits
------------------------------------------------------------------------------------------------------------------------------
--RENAME FUNCTIONS
--CHANGE DATATYPE
--AGGREGATE FUNCTIONS
--NORMALIZATION
--STORED PROCEDURE
--TRIGGER
--TRANSACTION

--Dropping a column
alter table Sheet1$
drop column F6













