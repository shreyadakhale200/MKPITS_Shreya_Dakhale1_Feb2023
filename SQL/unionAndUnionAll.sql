create database unionUnionAll

create table Customer(
id int,
Name varchar(20))

create table Customer1(
id int,
Name varchar(20))

insert into Customer values(1,'Shreya'),(2,'Manju'),(3,'Manoj')
insert into Customer1 values(1,'Shreya'),(2,'Sahil'),(3,'Mahi')

select * from Customer
union all
select * from Customer1

select * from Customer
union 
select * from Customer1

--------------------------
--ALTER

--ADD A COLUMN
alter table Customer
add age int

--MODIFY A DATATYPE
alter table Customer
alter column id decimal(10,2)

--ADDING A CONSTRAINT
alter table Customer
add constraint prcustomer primary key(id)

--DROPPING A CONSTRAINT
alter table Customer
drop column name
