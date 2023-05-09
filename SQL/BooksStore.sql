--Primary key
create database BookStore

create table Books(
Orderno int,
Bookid int,
Price int,
Qty int,
custid int,
primary key(Orderno,Bookid),					--Composite key(Orderno,Bookid)	
--constraint price_check check (Price = 200)
)

select * from Books

insert into Books values(1,23,200,1,212)
insert into Books values(1,24,400,2,212)
insert into Books values(2,25,500,1,214)
insert into Books values(3,23,200,1,214)
insert into Books values(3,27,1000,3,215)

create table Cost(
Bookid int primary key,
price int
)

insert into Cost values(23,200)
insert into Cost values(24,400)
insert into Cost values(25,500)
insert into Cost values(27,1000)

create table BookInfo(
Bookid int,								--foreign key(Bookid)
Orderno int,
Qty int,
Custid int
constraint b foreign key(Bookid) references Cost(Bookid)
)

insert into BookInfo values(23,1,1,212)
insert into BookInfo values(24,1,2,212)
insert into BookInfo values(25,2,1,214)
insert into BookInfo values(23,3,1,214)
insert into BookInfo values(27,2,3,212)

select * from BookInfo

--ALTER TABLE Cost
--ADD CONSTRAINT check_price
--CHECK(Price = 200);