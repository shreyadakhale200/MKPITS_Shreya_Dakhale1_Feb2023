create database Procedure_database

--create procedure procedure_name
--as
--begin
--select * from table_name
--end

create table salesman(
salesman_id int primary key,
name varchar(20),
city varchar(20),
commision dec(10,2)
)

insert into salesman values(5001,'James Hoog','New York',0.15)
insert into salesman values(5002,'Nail Knite','Paris',0.13)
insert into salesman values(5005,'Pit Alex','London',0.11)
insert into salesman values(5006,'Mc Lyon','Paris',0.14)
insert into salesman values(5007,'Paul Adam','Rome',0.13)
insert into salesman values(5003,'Lauson Hen','San Jose',0.12)

select * from salesman

create table customerOrder(
CustomerID int,
OrderID int,
OrderDate varchar(10),
ProductID int,
Quantity int,
PricePerUnit dec(10,2)
primary key(CustomerID,OrderID,ProductID)
)

select * from customerOrder

insert into customerOrder values(001,1001,'2021-01-01',101,2,50.00)
insert into customerOrder values(001,1002,'2021-01-02',102,3,25.00)
insert into customerOrder values(002,1003,'2021-01-03',101,1,50.00)
insert into customerOrder values(002,1004,'2021-01-04',103,4,20.00)


--creating a procedure(prod1)
create procedure prod1
as
begin
select * from salesman
end
-------------------------------------------------
--creating a procedure(prod)
create procedure prod
as 
begin
select * from customerOrder
end
exec prod
exec prod1

--Modifying a stored procedure
alter procedure prod1 
as
begin
select * from salesman
order by city
end
exec prod1
select * from salesman
---------------------------------------------------
--Modifiying prod procedure
alter procedure prod
as
begin
select CustomerID,OrderID,OrderDate,Quantity
from customerOrder order by Quantity
end
exec prod

--Deleting the stored procedure
drop procedure prod
--or
--drop proc prod
drop procedure prod1
exec prod		--Could not find stored procedure 'prod'.
exec prod1		--Could not find stored procedure 'prod1'.

--Creating a stored procedure with one parameter
select * from salesman
select * from customerOrder
drop procedure prod1					--For customerOrder
create procedure prod1(@minval as int)
as
begin
select * from customerOrder
where Quantity > @minval
end

exec prod1 2
------------------------------------------
--modifying prod procedure having one parameter
alter procedure prod(@minAlpha as char)
as
begin
select * from salesman
where city < @minAlpha
end
exec prod 'P%'
-------------------------------------------------
--modifying prod procedure having one parameter
alter procedure prod(@equalval as varchar(20))
as
begin
select * from salesman
where name = @equalval
end
select * from salesman
exec prod 'Nail Knite'
---------------------------------------------
--Modifying a procedure prod1 having price more than the given price
drop procedure prod1
create procedure prod1(@maxPrice as dec(10,2))
as
begin
select * from customerOrder
where PricePerUnit < @maxPrice
end
exec prod1 50.00
----------------------------------------------------
--Stored procedures with 2 parameters
select * from salesman
create procedure sales(@name as varchar(20), @city as varchar(20))
as
begin
select * from salesman
where name = @name
and city = @city
end
exec sales 'Mc Lyon','Paris'

select * from customerOrder

create procedure cust(@pID as int, @price as int)
as
begin
select * from customerOrder
where ProductID > @pID
and PricePerUnit < @price
end
exec cust 101,50

--Stored procedures can take one or more parameters. The parameters are separated by commas.

--passing arguments to the procedure in easier way
select * from salesman
alter procedure sales(@name as varchar(20), @id as int)
as 
begin
select * from salesman
where name = @name 
and salesman_id = @id 
end
exec sales @name = 'James Hoog',@id = 5001

select  * from customerOrder
alter procedure cust(@id as int, @date as varchar(20))
as
begin
select * from customerOrder
where OrderID = @id
and OrderDate = @date
end
exec cust @id = 1003,@date = '2021-01-03'
-------------------------------------------------
--Stored procedures with 3 parameters
select * from salesman
alter procedure sales(@commision as dec(10,2),@id as int,@name varchar(20))
as
begin
select * from salesman
where commision > @commision		--comission > 0.12 (pit,lauson)
and salesman_id > @id				--id > 5002(james,nail)
or name in(@name)					--
end
exec sales @commision = 0.12,@id = 5002,@name = 'Pit Alex,Mc Lyon,James Hoog,Lauson Hen,Nail Knite';

--Creating optional parameters
select * from salesman
alter procedure sales(@id as int,@city as varchar(20),@name as varchar(20))
as
begin
select * from salesman
where salesman_id > @id and city like @city and name like @name 
end
exec sales @id = 5000,@city = 'P%',@name = 'M%'
----------------------------------------------------------------



