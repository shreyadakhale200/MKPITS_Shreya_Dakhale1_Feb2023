--create a table student having columns rno,name,email,city,courseid
--insert some records into student table
--create a table fees having columns feesid,rno,feesdate,amount,courseid
--write a query to display fees details of those student whose city=nagpur
--write a query to display fees details of those student whose city=mumbai
--write a query to display fees details of those student whose city=delhi
------------------------------------------------------------------
--create a table courses having column courseid, coursename,fees , duration
--write a query to get student details whose course is java

--write a query to get student details whose course is dotnet

--write a query to get student details whose course is php

create database Student_MKPITS
--rno,name,email,city,courseid
create table student(
rno int primary key,
name varchar(20),
email varchar(30),
city varchar(20),
courseid int
)
--Course - Java(2),Dotnet(1),PHP(3)
insert into student values(1,'Shreya','shreya@gmail.com','Nagpur',1)
insert into student values(2,'Lily','lily@gmail.com','Hyderabad',2)
insert into student values(3,'Sakshi','sakshiballal@gmail.com','Ahmedabad',3)
insert into student values(4,'Mansi','mansi23@gmail.com','Hyderabad',1)
insert into student values(5,'Naina','naina@gmail.com','Mumbai',3)
insert into student values(6,'Vanshika','vanshika1@gmail.com','Amravati',2)

update student set city = 'Delhi' where name = 'Mansi'

select * from student

--fees having columns feesid,rno,feesdate,amount,courseid
create table fees(
feesid int primary key,
rno int,						--foreign key(from student table)
feesdate varchar(10),
amount int,
courseid int
constraint c foreign key(rno) references student(rno)
)

insert into fees values(10023,1,'12-3-2023',56000,1)
insert into fees values(23244,2,'13-3-2023',34000,2)
insert into fees values(54892,3,'15-2-2023',12000,3)
insert into fees values(35892,4,'23-4-2023',98000,4)
insert into fees values(54982,5,'25-2-2023',78202,5)
insert into fees values(28954,6,'14-3-2023',58029,6)

select * from fees

--write a query to display fees details of those student whose city=nagpur
select s.rno,s.name,f.feesid,f.amount,f.feesdate from student s 
inner join fees f on s.rno = f.rno 
where city = 'Nagpur'

--write a query to display fees details of those student whose city=mumbai
select * from fees where rno =
(select rno from student where city = 'Mumbai')
-- ERROR - Only one expression can be specified in the select list when the subquery is not introduced with EXISTS.

--write a query to display fees details of those student whose city=delhi

--records can be updated using update query
update student set name = 'Anjali' where name = 'Lily' 
select * from student

--to drop column Marks
alter table student
drop column Marks;

--query to add a column in the existing table
alter table student add Marks int

--insert into student values(7,'Ansh','an@gmail.com','Hyderabad',2)

--deleting a row from the existing table
delete from student 
where name = 'Ansh'
select * from student



--TABLE QUERIES--

--query to rename the table name table is renamed
EXEC sp_rename 'student', 'newstudent';

--query to rename the column name column is renamed
EXEC sp_rename 'student.city','City','COLUMN'
select * from student
--identity will add the values in the records from one in the default manner
create table sample12345(
sampleid int identity primary key,
samplename varchar(20)
)
insert into sample12345 values('Sana')
insert into sample12345 values('Shahni')
insert into sample12345 values('Babar')
insert into sample12345 values('Suhani')

select * from sample12345
delete from sample12345

--after deleting the records now whenever the data will be inserted in the records it will
--start from after number of the value which has been deleted
insert into sample12345 values('Shabana')
insert into sample12345 values('Malika')
insert into sample12345 values('Sana')
insert into sample12345 values('Shahni')
insert into sample12345 values('Babar')
insert into sample12345 values('Suhani')

truncate table sample12345
--but if the table is truncated the value will be set by default to 1
insert into sample12345 values('Shabana')
insert into sample12345 values('Malika')
insert into sample12345 values('Sana')
insert into sample12345 values('Shahni')
insert into sample12345 values('Babar')
insert into sample12345 values('Suhani')

select * from student

--query to change the datatype of marks
alter table sample12345
alter column Marks dec(10,2)

alter table sample12345
add Marks int

select * from sample12345
exec sp_help sample12345

exec sp_rename 'newsample','sample12345'
select * from sample12345

update sample12345
set Marks = 34.54 where sampleid = 1

alter table sample12345
drop column Marks

delete from sample12345 where sampleid = 3