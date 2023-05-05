--CustomerID | OrderID | OrderDate | ProductID | Quantity | PricePerUnit
-----------|---------|-----------|-----------|----------|-------------
--001        | 1001    | 2021-01-01| 101       | 2        | 50.00
--001        | 1002    | 2021-01-02| 102       | 3        | 25.00
--002        | 1003    | 2021-01-03| 101       | 1        | 50.00
--002        | 1004    | 2021-01-04| 103       | 4        | 20.00

create database BookStore

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

--CustomerID		OrderID 	OrderDate		PricePerUnit
--1					1001		2021-01-01		50.00
--1					1002		2021-01-02		25.00
--2					1003		2021-01-03		50.00
--2					1004		2021-01-04		20.00

--OrderID	ProductID	Quantity
--1001		101			2
--1002		102			3
--1003		101			1
--1004		103			4

--CustomerID <--> OrderID <--> OrderDate <--> PricePerUnit
--OrderID <--> ProductID <--> Quantity

CREATE TABLE Orders (
    CustomerID INT,
    OrderID INT,
    OrderDate VARCHAR(10),
    PricePerUnit INT,
    PRIMARY KEY (OrderID, CustomerID)
);

CREATE TABLE OrderDetails (
    OrderID INT,
    ProductID INT,
    Quantity INT,
    CONSTRAINT c1 FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);
