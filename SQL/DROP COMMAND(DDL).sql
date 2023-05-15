-------------------------------------------------DROP COMMAND------------------------------------------------------------
--DDL commands (Data Definition Language)
--DROP
--TRUNCATE 
--CREATE 
--ALTER
--GRANT
--REVOKE

--DROP(DDL)
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
