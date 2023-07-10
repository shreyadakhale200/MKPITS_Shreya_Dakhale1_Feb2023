create database EmployeeDetails

create table Employee_List(
id int primary key identity,
Name varchar(50),
Age int,
Department varchar(50),
Salary Decimal(10,2)
)

drop table Employee_List