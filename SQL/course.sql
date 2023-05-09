create table course(
courseid int primary key,
coursename varchar(20)
)

insert into course values(1,'Dotnet')
insert into course values(2,'Java')

create table studentDetails(
rollno int primary key,
studentname varchar(20),
courseid int,								--foreign key( from course)
constraint c foreign key(courseid) references course(courseid)
)

insert into studentDetails values(1,'Rupali',1)
insert into studentDetails values(2,'Mahima',1)
insert into studentDetails values(3,'Bharti',2)
insert into studentDetails values(4,'Pranay',2)

select * from course
select * from studentDetails

select c.coursename,sd.studentname from course c inner join studentDetails sd
on c.courseid = sd.courseid

select studentname from studentDetails where courseid = 
(select courseid from course where courseid = 1)

select studentname from studentDetails where courseid = 
(select courseid from course where courseid = 2)


--select cityname from city where stateid = 
--(select stateid from state where statename = 'Madhya Pradesh')
