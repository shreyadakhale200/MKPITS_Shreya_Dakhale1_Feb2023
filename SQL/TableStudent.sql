create database student

create table tablestudent(
studid int primary key identity,
studname varchar(40)
)

create table tablemarks(
subjectid int primary key identity,
subjectname varchar(15),
studid int,
constraint c foreign key(studid) references tablestudent(studid)
)
alter table tablemarks add studmarks dec(10,2)

insert into tablestudent values('Rashmi'),('Pallavi'),('Ali'),('Ravi'),('Suresh'),('Mahesh')
insert into tablemarks values ('Maths',1,98),('Science',1,79),('SST',2,85),('English',3,57),('Hindi',5,93),('Sanskrit',6,48)
select * from tablestudent
select * from tablemarks

select s.studid,s.studname,m.subjectname,m.studmarks from tablestudent s inner join tablemarks m on s.studid = m.studid
--INNER JOIN
select s.studname,m.subjectname from tablestudent s inner join tablemarks m on s.studid = m.studid

--LEFT JOIN
select s.studid,s.studname,m.studmarks,m.studid from tablemarks m left join tablestudent s on m.studid = s.studid
select s.studid,s.studname,m.studmarks,m.studid from tablemarks m right join tablestudent s on m.studid = s.studid

select s.*,m.* from tablestudent s full outer join tablemarks m on s.studid = m.studid







