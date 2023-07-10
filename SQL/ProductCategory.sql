create database ProductCategoryDetails

create table CategoryDetails(
Categoryid int primary key,
Name varchar(20)
)

drop table CategoryDetails

create table ProductDetails(
Productid int not null,
Productname varchar(50),
Categoryid int,
constraint p foreign key(Categoryid) references CategoryDetails(Categoryid)
)

select * from CategoryDetails
select * from ProductDetails

insert into CategoryDetails values(1,'Food'),(2,'Furniture')
insert into ProductDetails values(1,'Bread',1),(2,'Almirah',2),(3,'Pasta',1),(4,'Mirror',2)

insert into ProductDetails values(5,'Tomato',1),(6,'Spinach',1),(7,'Sofa',2),(8,'Dining Table',2)