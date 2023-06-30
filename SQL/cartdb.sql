select * from meeshoStore

update meeshoStore set prodname = 'Cutie Frock' where prodid = 3 

create table cart(
cartid int identity,
prodname varchar(100) not null,
prodprice numeric(10,2) not null,
qty int not null,
sessionid varchar(500)
)

alter table cart add prodimg varchar(100)

select * from cart
select * from meeshoStore


