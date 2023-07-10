create database DepartmentDetails

create table Department(
Departmentid int primary key,
name varchar(50)
)

create table Employee(
Employeeid int,
employeename varchar(50),
Departmentid int,
constraint e foreign key(Departmentid) references Department(Departmentid) 
)

select * from Department
select * from Employee

insert into Department values(1,'IT'),(2,'Marketing'),(3,'Sales'),(4,'HR')
insert into Employee values(1,'Mahima',1),(2,'Rupali',4),(3,'Akanksha',3),(4,'Mayuri',1),(5,'Jayesh',3),(6,'Monali',2),(7,'Shreya',1),(8,'Tanmay',2),(9,'Sahil',2)