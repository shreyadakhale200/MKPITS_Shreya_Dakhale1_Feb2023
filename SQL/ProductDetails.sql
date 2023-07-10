create database ProductDetails

create table Product_List(
Id int primary key identity,
Name varchar(100),
Quantity int,
Price Decimal(10,2)
)

drop table Product_List