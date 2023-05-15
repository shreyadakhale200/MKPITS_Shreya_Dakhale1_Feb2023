--DDL commands (Data Definition Language)
--DROP
--TRUNCATE 
--CREATE 
--ALTER
--GRANT
--REVOKE

--truncate or drop does not allow where clause
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

---------------------------------------------------------------------------------------------------------------------------
--ALTER FUNCTIONS
--Modifying a table - You can add, modify, or delete columns, change column data types, set or modify constraints, and modify table properties.

-- TO ADD A COLUMN
--SYNTAX
ALTER TABLE table_name
add column_name data_type
--Column 'Marks' will be added
ALTER TABLE Sheet1$
add Marks int

---TO MODIFY A COLUMN
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

UPDATE Sheet1$
SET gender = 'F',name = 'Jada Smith'
where gender = 'Female' AND name = 'Jada Smith'

--CASE
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
------------------------------------------------------------------------------------------------------------------------------
--RENAME FUNCTIONS
--CHANGE DATATYPE


--Dropping a column
alter table Sheet1$
drop column F6













