create table Exam(
Rollno int,
StudentName varchar(30),
University varchar(10),
Marks int,
grade char
)

insert into Exam values(101,'Shreya','RTMNU',98,'A')

insert into Exam values(102,'Mahima','RTMNU',99.99,'A')
insert into Exam values(103,'Rupali','SGBUA',97,'A')
insert into Exam values(104,'Mayuri','RTMNU',89,'A')
insert into Exam values(105,'Akansha','RTMNU',22,'F')
insert into Exam values(106,'Yasmin','Autonomous',72,'B')
insert into Exam values(107,'Tanmay','Autonomous',67,'C')
insert into Exam values(108,'Sahil','RTMNU',99,'A')
insert into Exam values(109,'Anjali','RTMNU',54,'D')
insert into Exam values(110,'Monali','UOD',43,'E')
insert into Exam values(111,'Tanushri','BHU',22,'F')
insert into Exam values(112,'Karishma','SPPU',95,'A')
insert into Exam values(113,'Ashish','JMI',76,'B')
insert into Exam values(114,'Jayesh','UNI',98,'A')
insert into Exam values(115,'Reeta','UOA',11,'G')

select * from Exam

--TOP,TOP PERCENT,DISTINCT, IN, NOT IN,BETWEEN,OR, AND,LIKE,LEN,WHERE,SELECT,ORDER BY,ASC,DESC,GROUP BY

--TOP
select TOP 10
* from Exam where Marks > 90 Order by StudentName

--TOP PERCENT
select TOP 90 PERCENT
* from Exam where Marks < 50 

--DISTINCT
select DISTINCT grade from Exam

--IN
select * from Exam where Marks in(99,98,97)

--NOT IN
select * from Exam where Marks not in(99,98,97,89,95)

--BETWEEN
select distinct * from Exam where grade between 'E' and 'G' order by grade

--OR
select * from Exam where StudentName = 'Akansha' or StudentName = 'Mayuri'

--AND
select * from Exam where StudentName like 'S%' and Marks in (99,98,96)

--LIKE
select * from Exam where StudentName like 'S%' or StudentName like 'Ru%'

select * from Exam order by StudentName,Marks,grade