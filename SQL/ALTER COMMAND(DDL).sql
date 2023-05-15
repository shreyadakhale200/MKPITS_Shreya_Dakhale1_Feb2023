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

