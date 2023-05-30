create table TableCourse(
CourseId int primary key,						--primary key
CourseName varchar(20),
Fees int,
)

drop table TableCourse
select * from TableCountry

insert into TableCourse values(1,'Dotnet',75000),(2,'Java',80000)

create table TableCountry(
CountryId int primary key,						--primary key
CountryName varchar(20)
)

insert into TableCountry values(100,'India'),(101,'USA')

create table TableState(
StateId int primary key,						--primary key
StateName varchar(20),
CountryId int,									--foreign key (from TableCountry)
constraint c foreign key(CountryId) references TableCountry(CountryId)
)

drop table TableCountry
drop table TableState
drop table TableCity

insert into TableState values
(1,'Maharashtra',100),(2,'Pune',100),(3,'Mumbai',100),(4,'Banglore',100),
(5,'California', 101),(6,'Texas',101),(7,'Florida',101),(8,'Ohio',101)
--California
--Texas
--Florida
--Ohio

--Karnataka
--Punjab
--Jharkhand
--Assam

update TableState set StateName = 'Karnataka' where StateName = 'Pune'

update TableState set StateName = 'Punjab' where StateName = 'Mumbai'
update TableState set StateName = 'Assam' where StateName = 'Banglore'


create table TableCity(
CityId int primary key,							--primary key
CityName varchar(20),
StateId int,									--foreign key(from TableState)
constraint c1 foreign key(StateId) references TableState(StateId)
)

insert into TableCity values
(200,'Pune',1),(201,'Mumbai',1),
(202,'Bengaluru',2),(203,'Mysuru',2),
(204,'Amritsar',3),(205,'Ludhiana',3),
(206,'Guwahati',4),(207,'Goalpara',4),
(208,'San Francisco',5),(209,'Los Angeles',5),
(210,'Houston',6),(211,'Dallas',6),
(212,'Miami',7),(213,'Tampa',7),
(214,'Columbus',8),(215,'Cincinnati',8)


create table TableAdmissionDetails(
AdmissionId int identity primary key,
StudentName varchar(50),
Gender varchar(10),
Contact bigint,
Country varchar(50),
State varchar(20),
City varchar(20),
date Date,
Courseid int,
Fees int,
AmountPaid int,
Balance int
)

alter table TableAdmissionDetails alter column Contact varchar(30)


select * from TableCourse
select * from TableCountry
select * from TableState
select * from TableCity
select * from TableAdmissionDetails

update TableCourse set Fees_In_Dollar = 907.33 where CourseName = 'Dotnet'
update TableCourse set Fees_In_Dollar = 968.20 where CourseName = 'Java'

alter table TableCourse add Fees_In_Dollar int
alter table TableCourse alter column Fees_In_Dollar decimal(10,2)
-- Assuming we have a table called "Employees" with a column named "OldColumnName"
EXEC sp_rename 'TableCourse.Fees','Fees_In_Rupees','COLUMN';

exec sp_help TableCourse

select s.StateName from TableState s inner join TableCountry t on s.CountryId = t.CountryId where CountryName = 'India' 

select c.CityName from TableCity c inner join TableState t on c.StateId = t.StateId where StateName = 'Maharashtra' 

select fees from TableCourse where CourseName = 'Dotnet'

select * from TableAdmissionDetails

select * from TableCourse
select * from TableCountry

select Fees_In_Dollar from TableCourse where CourseName = 'Dotnet'

