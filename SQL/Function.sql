--there are two types of user-defined functions
--Table valued functions
--Scalar valued functions

--Table valued Functions
--create function f1()	--creates a new function f1
--returns table			--This line specifies the return type of the function. 
--In this case, the function returns a table, 
--which means that the result set returned by the function will be a set of rows and columns.
--as	--The definition of the function is about to begin.
--return (select * from students_mkpits)	--return result of the function
-- Define the function
create function f1()
returns table
as
return (select * from students_mkpits)

select * from f1()

drop function f1

create function f2()
returns int
as
begin
return(select roll_no from students_mkpits)
end

select roll_no from students_mkpits

--A table-valued function is a type of function in SQL Server
--that returns a table as its result. 