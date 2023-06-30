select * from student

drop table student

create table student(
SrNo int identity,
Name varchar(50),
Address varchar(100),
Course varchar(20),
Courseid int,
age int,
constraint c1 foreign key(Courseid) references courseDetails(courseid)
)

alter table student drop column course

truncate table student

drop table courseDetails

insert into courseDetails values('Dotnet',75000),('Java',76000),('C',56700),('Python',80000),('C++',73000)

truncate table courseDetails

select * from courseDetails
select * from student

alter table student add studentid int primary key

alter table student drop column studentid

create table courseDetails(
courseid int primary key identity,
name varchar(20),
Price numeric(10,2)
)

truncate table student

update student set name = 'Am9h' where Address='Nagpur'
