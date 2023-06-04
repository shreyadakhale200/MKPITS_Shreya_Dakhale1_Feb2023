select * from tablestudent
select * from tablemarks
--inner join
select s.*,m.* from tablestudent s inner join tablemarks m on s.studid = m.studid

--Left Join
select s.*,m.* from tablestudent s left join tablemarks m on s.studid = m.studid

--full outer join
select s.*,m.* from tablestudent s full outer join tablemarks m on s.studid = m.studid

--self join
select s.* from tablestudent s inner join tablestudent s1 on s.studid = s1.studid

--Functions - function a precompiled database object which is used to accept input paramrters perform a specific and return a single value or a result set
--There are two types of functions
--(1)	Scalar function
--(2)	Table valued function

--(1) Scalar function - Scalar function is used to operate on a single value and return the single value as the result
create function squarefunction(@number int)
returns int
as
begin
declare @result int;
set @result = @number * @number;
return @result;
end;

select dbo.squarefunction(5);

--second way (Scalar function)
CREATE FUNCTION squarefunction(@number INT)
RETURNS INT
AS
BEGIN
    DECLARE @result INT;
    SET @result = @number * @number;
    RETURN @result;
END;
GO

DECLARE @output INT;
SET @output = dbo.squarefunction(5);

SELECT @output;

--(2)Table valued function - table valued functnio is used to return a table or a result set

select * from tablestudent
select * from tablemarks

create function StudentResult(@studid int)
returns table
as
return(
	select s.studid,m.subjectname,m.studmarks from tablestudent s inner join tablemarks m on
	s.studid = m.studid
	);

	drop function StudentResult

select * from StudentResult(1)

--primary key
--column_name datatype primary key,

--foreign key
--contraint c foreign key(columnname) references referentialtable(column from the other table)

--unique key
create table StudentAddress(
studid int identity,
address varchar(20),
--You can define a candidate key by creating a unique key constraint on the desired column(s) of the table
--candidate key
unique(studid),

--composite key
--unique(column1,column2)


--foreign key
constraint c1 foreign key(studid) references tablestudent(studid)
)

insert into StudentAddress values('Banglore'),('Delhi'),('Pune'),('Nagpur'),('Gujrat')

select * from StudentAddress
select * from tablestudent
select * from tablemarks

drop table StudentAddress

--Union

select * from tablestudent
union
select subjectid,subjectname from tablemarks

--Union All

select * from tablestudent
union all
select subjectid,subjectname from tablemarks

select top 2 studmarks from tablemarks

select max(studmarks),subjectname from tablemarks group by studmarks,subjectname

select studname from tablestudent where studid in (select studid from tablemarks where studmarks = (select max(studmarks) from tablemarks))

select max(m.studmarks),s.studname from tablemarks m join tablestudent s on m.studid = s.studid group by studname

--to add a column 
alter table tablestudent add rollno int

--index syntax

create index searchStudent on tablestudent(studname)

select studname from tablestudent where studname = 'Ravi'

exec sp_help searchStudent

--how to show current date time

select getdate();
select CURRENT_TIMESTAMP

--what is substring
--substring function is used to extract substring from a given string

SELECT SUBSTRING('Hello world',7,5);

select SUBSTRING('Ravi',2,3) from tablestudent;

--delete
delete from tablestudent
delete from tablestudent where studname = 'Ravi'

--drop
drop table tablestudent
drop database student






