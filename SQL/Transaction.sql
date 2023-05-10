select * from product

--COMMIT TRANSACTION
--start a new transaction
BEGIN TRANSACTION
--sql satements
insert into product values(116,'Headphones',2000,30)
update product set Price = 40000 where ProductID = 121
--commit changes

--COMMIT TRANSACTION
--EXPLICIT TRANSACTION
select * from product

--start a new transaction
BEGIN TRANSACTION
--SQL statements
delete product where ProductID = 116
insert into product values(22,'Headphones',2000,30)
--commit changes
COMMIT TRANSACTION

select * from product
-----------------------------------------------------------------------
--AUTO COMMIT TRANSACTION
--auto commit is default in the SQL
-----------------------------------------------------------------------
--COMMIT TRANSACTION
--ROLLBACK TRANSACTION

--start of new transaction
BEGIN TRANSACTION
--SQL statements
delete product where ProductId = 1
update product set Price = 10000 where ProductID = 20
insert into product values(23,'Gaming Console',23000,3)
--revert changes
ROLLBACK TRANSACTION

select * from product


SET IMPLICIT_TRANSACTIONS ON
--IMPLICIT TRANSACTION
--BEGIN TRANSACTION
--SQL statements
delete product where ProductId = 1
update product set Price = 10000 where ProductID = 20
--revert changes
ROLLBACK TRANSACTION
select * from product









