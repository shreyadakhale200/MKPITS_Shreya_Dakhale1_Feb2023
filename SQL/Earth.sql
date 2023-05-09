create database Earth

create table country(
countryid int primary key,
countryname varchar(20)
)

insert into country values(1,'India')
insert into country values(2,'USA')

select * from country

create table state(
stateid int primary key,		--primary key
statename varchar(20),
countryid int,					--foreign key(from country table)
constraint c foreign key(countryid) references country(countryid)
)

insert into state values(1,'Maharashtra',1)
insert into state values(2,'Madhya Pradesh',1)
insert into state values(3,'Texas',2)
insert into state values(4,'Alaska',2)

select * from country
select * from state

create table city(
cityid int primary key,			--primary key
cityname varchar(20),
stateid int,					--foreign key(from state)
constraint c1 foreign key(stateid) references state(stateid)
)

insert into city values(1,'Nagpur',1)
insert into city values(2,'Mumbai',1)
insert into city values(3,'Bhopal',2)
insert into city values(4,'Indore',2)
insert into city values(5,'Seattle',3)
insert into city values(6,'Olympia',3)
insert into city values(7,'Austin',4)
insert into city values(8,'Houstan',4)

--inner join
select c1.countryid,c1.countryname,s1.statename 
from country c1 inner join state s1 on c1.countryid = s1.countryid
where countryname = 'India'
--inner join
select c1.countryid,c1.countryname,s1.statename
from country c1 inner join state s1 on c1.countryid = s1.countryid
where countryname = 'USA'

select s1.statename 
from country c1 inner join state s1 on c1.countryid = s1.countryid
where countryname = 'India'

select s1.statename
from country c1 inner join state s1 on c1.countryid = s1.countryid
where countryname = 'USA'

select ct.cityname
from city ct inner join state s1
on ct.stateid = s1.stateid
where statename = 'Maharashtra'

select ct.cityname
from city ct inner join state s1
on ct.stateid = s1.stateid
where statename = 'Madhya Pradesh'

select ct.cityname
from city ct inner join state s1
on ct.stateid = s1.stateid
where statename = 'Texas'

select ct.cityname
from city ct inner join state s1
on ct.stateid = s1.stateid
where statename = 'Alaska'

--Subquery
select statename from state where countryid =
--subquery
(select countryid from country where countryname = 'India')

select statename from state where countryid = 
(select countryid from country where countryname = 'USA')

select cityname from city where stateid = 
(select stateid from state where statename = 'Maharashtra')
--we will show city name whose state is Maharashtra

select cityname from city where stateid =
(select stateid from state where statename = 'Texas')
--we will show city name whose state is Texas

select cityname from city where stateid = 
(select stateid from state where statename = 'Madhya Pradesh')
--we will show city name whose state is Madhya Pradesh

select cityname from city where stateid = 
(select stateid from state where statename = 'Alaska')
--we will show city name whose state is Alaska

select * from state
