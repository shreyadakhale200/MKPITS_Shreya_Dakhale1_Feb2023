create database DrivenIT

create table ItemMaster(
ItemID int primary key identity(1,1) NOT NULL,
ItemDescr nvarchar(100) NULL,
BalQty int NULL,
CreatedOn Datetime
)
select  * from ItemMaster
insert into ItemMaster values('mouse',8,'01-20-2023')
insert into ItemMaster values('keyboard',10,'04-05-2023'),('Monitor',4,'05-25-2023'),('CPU',24,'10-03-2022')

create table Transactions(
TransID int primary key identity(1,1) NOT NULL,
ItemID int NOT NULL,									--foreign key(from table ItemMaster)
TransType char(1) NOT NULL,								--(We can insert I - Issue, R – Received),
TransQty int,
TransDate datetime,
constraint c foreign key (ItemID) references ItemMaster(ItemID) 
)

drop table Transactions

select max(balqty) from itemmaster where itemid=4
select balqty from itemmaster where itemid = 4
select * from ItemMaster
select * from Transactions

delete Transactions where TransID = 10 