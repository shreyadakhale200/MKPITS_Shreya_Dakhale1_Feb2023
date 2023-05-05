create database CarsStore

create table stores(
store_id int primary key,						--primary key (store_id)
store_name varchar(20),
phone int,
email varchar(20),
street varchar(30),
city varchar(20),
state varchar(20),
zip_code int
)

insert into stores values(100,'Maruti Stores',284,'maruti@gmail.com','Mankapur','Nagpur','Mah',440021)
insert into stores values(101,'Audi store',432,'audi@gmail.com','Ajni','Nagpur','MAH',440003)
insert into stores values(102,'Mercedes store',657,'Mercedes@gmail.com','Govandi','Mumbai','MAH',400088)
insert into stores values(103,'Creta Co',986,'Creta@gmail.com','MG Road','Mumbai','MAH',400077)
insert into stores values(104,'Ferari Company',768,'ferari@gmail.com','MG Road','Mumbai','MAH',400077)
select * from stores


create table categories(
category_id int primary key,						--primary key(category_id)
category_name varchar(20)
)

insert into categories values(200,'SUV')
insert into categories values(201,'Sedan')
insert into categories values(202,'Sports Car')
insert into categories values(203,'Coupe')
insert into categories values(204,'Convertible')
insert into categories values(205,'Electric Vehicles')
insert into categories values(206,'Luxury')
insert into categories values(207,'All Purpose')
insert into categories values(208,'Automotive')

select * from categories

create table brands(
brand_id int primary key,							--primary key(brand_id)
brand_name varchar(20)
)

insert into brands values(300,'Tesla')
insert into brands values(301,'Infiniti')
insert into brands values(302,'Chevrolet')
insert into brands values(303,'Hyundai')
insert into brands values(304,'Ford')

select * from brands

create table products(
product_id int primary key,							--primary key(product_id)
product_name varchar(20),
brand_id int,										--foreign key(brand_id from brands)
category_id int,									--foreign key(category_id from categories)
model_year int,
list_price int
constraint p foreign key(brand_id) references brands(brand_id),
constraint p1 foreign key(category_id)references categories(category_id))

insert into products values(400,'Tesla S Plaid',300,205,2021,9133884)
insert into products values(401,'Tesla Model X Plaid',300,205,2023,20000000) 
insert into products values(402,'Infiniti Q50',301,206,2013,4400000)
insert into products values(403,'Infiniti Q60',301,206,2017,5400000)
insert into products values(404,'Chevrolet Cruz',302,207,2003,1300000)
insert into products values(405,'Chevrolet Camarao',302,207,1996,5000000)
insert into products values(406,'2023 Hyundai Aura',303,201,2023,632000)
insert into products values(407,'2023 Hyundai Varna',303,201,2023,1600000)
insert into products values(408,'Ford EcoSport',304,208,2012,800000)
insert into products values(409,'Ford Explorer',304,208,1991,4200000)

select * from products

create table customers(
customer_id int primary key,						--primary key(customer_id)
first_name varchar(20),
last_name varchar(20),
phone int,
email varchar(30),
street varchar(20),
city varchar(20),
state varchar(20),
zip_code int
)

insert into customers values(1,'Rupali','Barde',7057,'rupali@gmail.com','Bhandara','Nagpur','MAH',441904)
insert into customers values(2,'Mayuri',
select* from customers

create table staffs(
staff_id int primary key,							--primary key(staff_id)
first_name varchar(20),
last_name varchar(20),
email varchar(20),
active int,
store_id int,										--foreign key(store_id from stores)
manager_id int
constraint s1 foreign key(store_id) references stores(store_id)
)

create table stocks(
store_id int,										--foreign key(store_id from stores)
product_id int,		 								--foreign key(product_id from products)
quantity int
constraint s foreign key(store_id) references stores(store_id),
constraint s2 foreign key(product_id) references products(product_id)
)

create table orders(
order_id int primary key,							--primary key(order_id)
customer_id int,									--foreign key(customer_id from customers)
order_status varchar(15),					
order_date varchar(10),
required_date varchar(10),
shipped_date varchar(10),
store_id int,										--foreign key(store_id from stores)
staff_id int										--foreign key(staff_id from staffs)
constraint c1 foreign key(customer_id) references customers(customer_id),
constraint s3 foreign key(store_id) references stores(store_id),
constraint s4 foreign key(staff_id) references staffs(staff_id)
)

create table order_items(
order_id int,										--foreign key(order_id from orders)
item_id int,										--primary key
product_id int,										--foreign key(product_id from products)
quantity int,
list_price int,
discount int
constraint o foreign key(order_id) references orders(order_id),
constraint p2 foreign key(product_id) references products(product_id)
)