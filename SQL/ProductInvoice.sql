create database TrustProject

create table Item_master(
Item_Id int identity primary key,
Item_Name varchar(50) not null,
Category varchar(50) not null,
rate decimal(10,2),
balance_quantity int not null
)

select * from Item_master
SET IDENTITY_INSERT Item_master OFF;

drop table Item_master

create table Department_mast(
Department_id int identity primary key,
Department_name varchar(50) not null
)
select * from Department_mast
truncate table Department_mast

drop table Item_master

drop table Department_mast
drop table Vendor_mast
create table Vendor_mast(
Vendor_id int identity primary key,
Vendor_name varchar(50) not null
)

SET IDENTITY_INSERT Vendor_mast OFF;

drop table Transaction_Process

select * from Vendor_mast
truncate table Vendor_mast

create table Transaction_Process(
Transaction_id int identity primary key,
item_id int,					--foreign key Item_Id (from table Item_master)
transaction_date date not null,
Department_id int,				--foreign key Department_id (from table Department_mast)
Vendor_Id int,					--foreign key Vendor_id		(from table Vendor_mast)
Quantity int not null
constraint c1 foreign key(item_id) references Item_master(Item_Id),
constraint c2 foreign key(Department_id) references Department_mast(Department_id),
constraint c3 foreign key(Vendor_Id) references Vendor_mast(Vendor_id)
)








