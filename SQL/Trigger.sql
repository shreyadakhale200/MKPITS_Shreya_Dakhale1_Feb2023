select * from product

create table productLOG(
ProductID int not null,
Operation nvarchar(10) not null,
UpdatedDate datetime not null
)

create trigger prod
on product
for delete 
as
insert into productLOG(ProductID,Operation,UpdatedDate)
select ProductID,'deleted',GETDATE() from deleted
select * from productLOG
select * from product

drop trigger prod
delete product where ProductID = 22
truncate table product 

INSERT INTO product(ProductID, ProductName, Price, Quantity) VALUES
  (1, 'Keyboard', 2099, 50),
  (2, 'Mouse', 1599, 100),
  (3, 'Monitor', 19999, 20),
  (4, 'Laptop', 99999, 10),
  (5, 'Desktop Computer', 79999, 15),
  (6, 'Headphones', 2999, 50),
  (7, 'External Hard Drive', 8999, 30),
  (8, 'Printer', 14999, 5),
  (9, 'Scanner', 7999, 8),
  (10, 'Webcam', 3999, 12),
  (11, 'Microphone', 4999, 20),
  (12, 'USB Flash Drive', 1499, 100),
  (13, 'Ethernet Cable', 999, 50),
  (14, 'WiFi Adapter', 1999, 30),
  (15, 'Wireless Router', 9999, 8),
  (16, 'Bluetooth Adapter', 1499, 20),
  (17, 'Gaming Mouse', 3999, 10),
  (18, 'Gaming Keyboard', 4999, 15),
  (19, 'Graphics Card', 8999, 5),
  (20, 'Sound Card', 5999, 8),
  (21, 'Power Supply', 6999, 12);

  select * from product