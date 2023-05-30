create database CourseRegistration2

create table TableNation(
NationID int primary key,
NationName varchar(500)
)

create table TableState(
StateId int primary key,
NationID int,						--foreign Key(from TableNation)
StateName varchar(500)
constraint c foreign key(NationID) references TableNation(NationID)
)

create table TableCity(
CityID int primary key,
StateID int,						--foreign key(from Table TableState)
CityName varchar(500)
constraint c1 foreign key(StateID) references TableState(StateID)
)

create table TableCourseRegDetail(
CourseRegID int primary key identity,
CategoryId int,
FullName varchar(1500),
GenderId int
)
drop table TableRegAddress


create table TableFeeDetail(
FeeID int primary key identity,
CourseRegID int,						--foreign key(from TableCourseRegDetail)
TotalAmount int,
MinPer decimal,
PaidAmount decimal,
BalAmount decimal,
PaidDate DateTime
constraint c2 foreign key(CourseRegID) references TableCourseRegDetail(CourseRegID)
)

select * from TableNation
select * from TableState
select * from TableCity
select * from TableCourseRegDetail

select * from TableRegAddress
select * from TableFeeDetail


insert into TableNation values(1,'India'),(2,'United-Nation'),(3,'Nepal'),(4,'Sri Lanka')
insert into TableState values(101,1,'Andhra Pradesh'),(102,1,'Punjab'),(103,2,'California'),(104,2,'Florida'),(105,3,'Koshi'),(106,3,'Bagmati'),(107,4,'Colombo'),(108,4,'Ratnapura')
insert into TableCity values(1001,101,'Visakhapatnam'),(1002,101,'Vijaywada'),(1003,101,'Guntur'),(1004,102,'Amritsar'),(1005,102,'Jalandhar'),(1006,102,'Chandigarh'),(1007,103,'Los Angeles'),(1008,103,'San Jose'),(1009,103,'San Diego'),(1010,104,'Jacksonville'),(1011,104,'Miami'),(1012,104,'Tampa'),(1013,105,'Damak'),(1014,105,'Dharan'),(1015,105,'BiratNagar'),(1016,106,'Banepa'),(1017,106,'Bharatpur'),(1018,106,'Hetauda'),(1019,107,'Grandpass'),(1020,107,'Borella'),(1021,107,'Pettah'),(1022,108,'Balangoda'),(1023,108,'Kolonna')

insert into TableCourseRegDetail values(1,'mk',1),(2,'mk2',2),(1,'ravi',1),(1,'anand',1),(1,'gaurav',1),(1,'pranjali',2),(1,'mk3',1),(1,'mk4',1),(1,'mk5',1),(1,'mk6',1),(2,'dhananjay',1),(1,'m khan',1),(2,'Ananya',2)

insert into TableRegAddress values(4,4,102,1003),
insert into TableRegAddress values(5,4,104,1009),
insert into TableRegAddress values(6,4,102,1003)
insert into TableRegAddress values(7,4,104,1012)
insert into TableRegAddress values(8,2,104,1009)
insert into TableRegAddress values(9,2,104,1009),
insert into TableRegAddress values(4,2,103,1009)
insert into TableRegAddress values(5,2,103,1007)
insert into TableRegAddress values(12,1,102,1006)
insert into TableRegAddress values(13,1,101,1001)

--insert into TableRegAddress values(14,4,107,1021)
--insert into TableRegAddress values(15,2,104,1012)
--insert into TableRegAddress values(16,1,101,1002)

insert into TableFeeDetail values(4,1000,0,500,500,'2023-04-10'),(5,3000,0,20,2980,'2023-04-04'),(6,1000,0,200,800,'2023-04-10'),(7,1000,0,500,500,'2023-04-10'),(8,1000,0,500,500,'2023-04-10'),(9,1000,0,500,500,'2023-04-10'),(10,1000,0,500,500,'2023-04-10'),(11,1000,0,500,500,'2023-04-10'),(12,1000,0,600,400,'2023-04-10'),(13,1000,500,600,400,'2023-04-10')

--insert into TableFeeDetail values(14,3000,2400,2400,600,'2023-04-10'),(15,1000,500,500,500,'2023-04-10'),(16,3000,2400,2500,500,'2023-04-10')