/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [username]
      ,[password]
  FROM [civica].[dbo].[users1]

  create table employee_civica(
  Empno numeric(18,0) not null,
  Empname varchar(50),
  Gender varchar(50),
  Email varchar(500),
  Mobileno numeric(18,0),
  cityid int,
  Dob date,
  constraint c3  foreign key(cityid) references CityDetails(cityid)
  )
  drop table employee_civica

  select * from employee_civica

  create table CityDetails(
  cityid int primary key identity,
  name varchar(50)
  )

  insert into CityDetails values('Nagpur'),('Pune'),('Mumbai'),('Banglore'),('Delhi')

  select * from employee_civica
  select * from CityDetails
