create database StudentDetails

create table Student_List(
id int primary key identity,
Name varchar(50),
Age int,
Mobile varchar(15),
Address varchar(100)
)

select * from Student_List