create database ProductStore
 
create table TableProductGSTDetails(
Product_Gst_ID int primary key,					--Primary key
Gst_Detail_Name varchar(500),
CGST Decimal(10,2),
SGST Decimal(10,2),
IGST Decimal(10,2)
)
alter table TableProductGSTDetails alter column CGST Decimal
alter table TableProductGSTDetails alter column SGST Decimal
alter table TableProductGSTDetails alter column IGST Decimal
insert into TableProductGSTDetails values(601,'AC and fridge',14,14,14),
(602,'Computers',9,9,9),(603,'Printers',9,9,9),(604,'Mobiles',6,6,6)
select * from TableProductGSTDetails

create table TableProductCategory(
Product_Category_ID int primary key,			--Primary key
Product_Type_Name varchar(500),
Product_Gst_ID int								--Foreign Key (from TableProductGSTDetails)
constraint p foreign key(Product_Gst_ID) references TableProductGSTDetails(Product_Gst_ID)
)
insert into TableProductCategory values(1001,'Computers',602),(1002,'Mobile',604),
(1003,'Printers',603),(1004,'AC and fridge',601)
select  * from TableProductCategory

create table TableProduct(
ProductID int primary key,
ProductTypeID int,								--Foreign Key(from TableProductCategory) 
ProductName varchar(500)
constraint p1 foreign key(ProductTypeID) references TableProductCategory(Product_Category_ID)
)
insert into TableProduct values(210,1002,'Apple'),(211,1002,'Lenovo'),
(212,1003,'Samsung'),(213,1004,'IFB'),(214,1004,'LG'),(215,1001,'Sony')
select * from TableProduct

create table TableInvoiceDetails(
Invoice_Detail_ID int primary key,
Customer_Name varchar(500),
Customer_Contact varchar(15),
Product_Category_ID int,						--Foreign key (from TableProductCategory)
Product_ID int,									--Foreign key (from TableProduct)
Residential_Type_ID int,
Invoice_Date DateTime,
Quantity decimal(10,2),
price decimal(10,2),
CGST decimal(10,2),
SGST decimal(10,2),
IGST decimal(10,2),
CGST_Value decimal(10,2),
SGST_Value decimal(10,2),
IGST_Value decimal(10,2),
Total_Amount decimal(10,2)
--Product_Category_ID int,						--Foreign key (from TableProductCategory)
--Product_ID int,									--Foreign key (from TableProduct)
constraint p2 foreign key(Product_Category_ID) references TableProductCategory(Product_Category_ID),
constraint p3 foreign key(Product_ID) references TableProduct(ProductID)
)
insert into TableInvoiceDetails values(1,'Rahul',9852132210,1002,210,3001,'2023-04-04',1,50000,6,6,12,3000,3000,6000,56000),
(2,'Nikita',7861232210,1001,211,3002,'2023-04-08',1,65000,9,9,18,11700,5850,5850,76700)

insert into TableInvoiceDetails values(12,'gopal',1234567890,1001,215,3003,'2023-04-12',1,60000,9,9,18,5400,5400,10800,70800),
(13,'anand',1234567890,1002,210,3004,'2023-04-12',1,40000,6,6,6,2400,2400,2400,42400)
select * from TableInvoiceDetails

alter table TableInvoiceDetails alter column Quantity Decimal
alter table TableInvoiceDetails alter column price Decimal

alter table TableInvoiceDetails alter column CGST Decimal
alter table TableInvoiceDetails alter column SGST Decimal
alter table TableInvoiceDetails alter column IGST Decimal
alter table TableInvoiceDetails alter column CGST_Value Decimal
alter table TableInvoiceDetails alter column SGST_Value Decimal
alter table TableInvoiceDetails alter column IGST_Value Decimal
alter table TableInvoiceDetails alter column Total_Amount Decimal

select * from TableProductCategory
select * from TableProduct

alter table TableProduct add price decimal
update TableProduct set price = 90000 where ProductName = 'Apple'
update TableProduct set price = 50000 where ProductName = 'Lenovo'
update TableProduct set price = 47000 where ProductName = 'Samsung'
update TableProduct set price = 29000 where ProductName = 'IFB'
update TableProduct set price = 65000 where ProductName = 'LG'
update TableProduct set price = 80000 where ProductName = 'Sony'

select * from TableProductCategory
select * from TableProduct

select t.ProductName from TableProduct t inner join TableProductCategory t1 on t1.Product_Category_ID = t.ProductTypeID
where Product_Type_Name = 'Computers'

truncate table TableInvoiceDetails

select * from TableInvoiceDetails

exec sp_help TableInvoiceDetails



