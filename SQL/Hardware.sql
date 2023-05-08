create table Customers(
customer_id int primary key,	--primary key
first_name varchar(20),
last_name varchar(20),
phone bigint,
email varchar(30),
street varchar(20),
city varchar(20),
state varchar(20),
zip_code int
)

insert into Customers values(1,'Rahil','Mehta',9892383928,'rahilmehta@gmail.com','Mankapur','Nagpur','Mahrashtra',440030)
insert into Customers values(2,'Akshara','Kapoor',9548317632,'aksh@gmail.com','Ram Nagar','Nagpur','Maharashtra',440032)
insert into Customers values(3,'Basheer','Maumtaaz',9504938567,'bash@gmail.com','Ravi Nagar','Nagpur','Maharashtra',440034)
insert into Customers values(4,'Hardik','Anwar',9034218695,'hardik12@gmail.com','Shankar Nagar','Nagpur','Maharashtra',440037)

select * from Customers

create table orders(
order_id int primary key,		--primary key
customer_id int,					--foreign key(from Customers)
order_status varchar(20),
order_date varchar(10),
required_date varchar(10),
shipped_date varchar(10),
store_id int unique,
staff_id int unique
constraint c foreign key(customer_id) references  Customers(customer_id)
)
--customer id - 1,2,3,4
insert into orders values(10,1,'late Arrival','12-2-2023','20-2-2023','25-2-2023',100,200)
insert into orders values(11,2,'Recieved','4-4-2023','10-4-2023','5-4-2023',101,201)
insert into orders values(12,3,'In Process','5-5-2023','15-5-2023','15-5-2023',102,202)
insert into orders values(13,4,'Arriving','6-3-2023','16-3-2023','16-3-2023',103,203)

select * from orders

select c.first_name,c.last_name,c.phone,o.order_id,o.customer_id
from Customers c inner join orders o on c.customer_id = o.customer_id 
where street in ('Shankar Nagar','Mankapur')

select first_name,last_name,phone from Customers where customer_id = 
(select customer_id from orders where order_status ='In Process');

exec sp_help orders