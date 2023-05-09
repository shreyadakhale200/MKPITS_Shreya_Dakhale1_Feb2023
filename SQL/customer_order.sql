--create a table customer having custid,custname,telno
--create a table orders having orderid,orderdate,custid ,prodname,qty,rate

create table customer(
custid int not null default'NULL',
custname varchar(20),
telno int
)

insert into customer values(1,'Shreya',99701)
insert into customer values(2,'Vanshika',64303)
insert into customer values(3,'Anjali',52093)
insert into customer values(4,'Akansha',42094)
insert into customer values(5,'Mayuri',32094)
insert into customer values(6,'Mahima',54039)
select * from customer

update customer
set telno = 94869
where custname = 'Shreya'


create table customer_order(
order_id int,
orderdate varchar(10),
custid int,
prodname varchar(20),
qty int,
rate int
)
insert into customer_order values(100,'12-12-2022',1,'Clinic Plus',2,500)
insert into customer_order values(101,'1-2-2023',2,'Nivea Cream',4,1200)
insert into customer_order values(102,'21-1-2023',3,'Colgate',3,340)
insert into customer_order values(103,'23-3-2023',4,'Madhur Sugar',5,1500)
insert into customer_order values(104,'5-5-2023',5,'Kala Hit',6,2000)
insert into customer_order values(105,'2-3-2023',6,'Pantanjali Face wash',10,3000)
insert into customer_order values(106,'7-4-203',7,'Avocado',3,4000)
select * from customer
select * from customer_order

--INNER JOIN - values common in both the tables will be printed
select c.custid,c.custname,c.telno,co.order_id,co.custid,co.prodname
from customer c
inner join customer_order co
on c.custid = co.custid

--CROSS JOIN - values of both the tables will be cross joined means each row
--of one table will be multiplied each row of another table
select c.custid,c.custname,c.telno,
co.order_id,co.orderdate,co.custid,co.prodname,co.qty,co.rate
from customer c
cross join customer_order co

--OUTER JOIN
--LEFT OUTER JOIN
select c.custid,c.custname,c.telno,
co.order_id,co.orderdate,co.custid,co.prodname,co.qty,co.rate
from customer c
left outer join customer_order co
on c.custid = co.custid

--OUTER JOIN
--RIGHT JOIN
select c.custid,c.custname,c.telno,
co.order_id,co.orderdate,co.custid,co.prodname,co.qty,co.rate
from customer c
right outer join customer_order co
on c.custid = co.custid

--FULL OUTER JOIN
select c.custid,c.custname,c.telno,
co.order_id,co.orderdate,co.custid,co.prodname,co.qty,co.rate
from customer c
full outer join customer_order co
on c.custid = co.custid

--DIFFERENCE BETWEEN FULL OUTER JOIN AND CROSS JOIN
--FULL OUTER JOIN
select c.custid,c.custname,c.telno,
co.order_id,co.orderdate,co.custid,co.prodname,co.qty,co.rate
from customer c
full outer join customer_order co
on c.custid = co.custid

--CROSS JOIN
select c.custid,c.custname,c.telno,
co.order_id,co.orderdate,co.custid,co.prodname,co.qty,co.rate
from customer c
cross join customer_order co

select * from customer
select * from customer_order
