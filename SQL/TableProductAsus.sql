create database InvoiceDetails

exec sp_rename LaptopBrandName,LaptopBrandDetails




select * from LaptopBrandDetails

drop table TableProductDetails

create table TableProductDetails(
Productid int primary key identity,
ProductName varchar(100),
AvailableQuantity int,
TotalQuantity int,
Price int,
BrandID int
constraint c foreign key(BrandID) references LaptopBrandDetails(BrandID)
)

--insert into TableProductDetails values
--('Dell Inspiron',50,70,58490,2),('Dell Vostro',40,80,41990,2),('Dell Inspiron',30,60,33990,2),
--('HP 15S',20,50,41990,1),('HP Probook',20,70,44990,1),('HP Pavilion',58,70,56999,1),
--('Asus Vivobook',40,60,74990,4),('Asus VivoBook S',30,50,65900,4),('Asus Vivobook Pro 16',10,40,89990,4),
--('Acer Aspire 5',70,90,89885,3),('Acer Aspire 5',43,50,60990,3),('Acer Aspire 5',20,30,60990,3),
--('Lenovo IdeaPad',10,30,55400,5),('Lenovo Ideapad 3',20,36,43975,5),('Lenovo IdeaPad',43,55,66990,5),
--('Dell Alienware',54,60,297000,6),('Dell Alienware x15',34,44,243890,6),('Acer Predator Helios Neo',15,34,109990,6),
--('Apple 2023 MacBook Pro',25,38,309900,7),('Apple 2022 MacBook Air',18,25,105490,7),('Apple 2023 MacBook Pro',35,40,349900,7),
--('Samsung Galaxy Book3 Pro',13,24,131990,8),('Samsung Galaxy Book2',25,54,79990,8),('Samsung Galaxy Book Pro',6,15,179990,8)

select * from LaptopBrandDetails
select * from TableProductDetails

drop table TableProductDetails


CREATE TABLE COMPUTER(ID INT PRIMARY KEY IDENTITY,NAME VARCHAR(30),AVAILABLE_QTY INT,SELL_QTY INT,
PRICE_PER_UNIT DECIMAL,CGST int,SGST int)


INSERT INTO COMPUTER VALUES('HP',52,2,45000,8,9)
INSERT INTO COMPUTER VALUES('LENOVO',42,1,50000,6,6)
INSERT INTO COMPUTER VALUES('DELL',62,2,48000,9,9)
INSERT INTO COMPUTER VALUES('ASUS',32,2,55000,7,7)
INSERT INTO COMPUTER VALUES('ACER',20,2,65000,5,5)
SELECT * FROM COMPUTER

insert into computer values('HP',52,2,45000,8,9),('Dell',42,1,50000,6,6),('Acer',20,2,65000,5,5),('Asus',32,2,55000,7,7),('Lenovo',40,3,60000,5,5),('Alienware',40,5,300000,8,8),('Apple',34,4,200000,6,6),('Samsung',25,3,50000,5,5)

create table computer(
ID int primary key identity,
Name varchar(30),
AVAILABLE_QTY int,
SELL_QTY int,
PRICE_PER_UNIT decimal,
CGST int,
SGST int
)

select * from computer
select * from computer where Name = 'Asus'

----------------------------------------CUSTOMER----------------------------------
CREATE TABLE CUSTOMER(
ID INT PRIMARY KEY IDENTITY,
FIRST_NAME VARCHAR(30),
LAST_NAME VARCHAR(30),
GENDER VARCHAR(10),
MOBILE VARCHAR(20),
PAID_AMOUNT DECIMAL)
SELECT * FROM CUSTOMER