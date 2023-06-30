create database meeshodb

create table meeshoStore(
prodid int identity,
prodname varchar(500),
proddescription varchar(500),
catid int,
prodprice int,
qty int,
prodimage varchar(500)
)

drop table meeshoStore
