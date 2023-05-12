create database sales

create table salesman(
salesman_id int primary key,
name varchar(20),
city varchar(20),
commision dec(10,2)
)
delete from salesman where name = 'Paul Adam'
select * from salesman
insert into salesman values(5001,'James Hoog','New York',0.15)
insert into salesman values(5002,'Nail Knite','Paris',0.13)
insert into salesman values(5005,'Pit Alex','London',0.11)
insert into salesman values(5006,'Mc Lyon','Paris',0.14)
insert into salesman values(5007,'Paul Adam','Rome',0.13)
insert into salesman values(5003,'Lauson Hen','San Jose',0.12)

select * from salesman
--2. Write a SQL statement to display specific columns like name and commission for all the salesmen.    
select name,commision from salesman

create table salesmanInfo(
ord_no int primary key,
purch_amt dec(10,2),
ord_date varchar(10),
customer_id int,
salesman_id int			--foreign key(from salesman)
constraint c foreign key(salesman_id) references salesman(salesman_id)
)

insert into salesmanInfo values(70001,150.5,'2012-10-05',3005,5002)
insert into salesmanInfo values(70009,270.65,'2012-09-10',3001,5005)
insert into salesmanInfo values(70002,65.26,'2012-10-05',3002,5001)
insert into salesmanInfo values(70004,110.5,'2012-08-17',3009,5003)
insert into salesmanInfo values(70007,948.5,'2012-09-10',3005,5002)
insert into salesmanInfo values(70005,2400.6,'2012-07-27',3007,5001)
insert into salesmanInfo values(70008,5760,'2012-09-10',3002,5001)

select * from salesman
select * from salesmanInfo

--3. Write a query to display the columns in a specific order like order date, salesman id, order number and purchase amount from for all the orders.   
select ord_date, salesman_id,ord_no,purch_amt from salesmanInfo

--4. From the following table, write a SQL query to find the unique salespeople ID. Return salesman_id.   
select salesman_id from salesmanInfo group by salesman_id
select distinct salesman_id from salesmanInfo

--5. From the following table, write a SQL query to find the salespeople who lives in the City of 'Paris'. Return salesperson's name, city. 
select name,city from salesman where city = 'Paris'

create table customerInfo(
customerid int primary key,
cust_name varchar(20),
city varchar(20),
grade int,
salesman_id int,			--foreign key(from salesmanInfo)
constraint s foreign key(salesman_id) references salesman(salesman_id)
)

insert into customerInfo values(3002,'Nick Rimando','New York',100,5001)
insert into customerInfo values(3007,'Brad Davis','New York',200,5001)
insert into customerInfo values(3005,'Graham Zusi','California',200,5002)
insert into customerInfo values(3008,'Julian Green','London',300,5002)
insert into customerInfo values(3004,'Fabian Johnson','Paris',300,5006)
insert into customerInfo values(3009,'Geoff Cameron','Berlin',100,5003)
insert into customerInfo values(3003,'Jozy Altidor','Moscow',200,5007)

select * from customerInfo

--6. From the following table, write a SQL query to find those customers whose grade is 200. Return customer_id, cust_name, city, grade, salesman_id.
select customerid,cust_name,city,grade,salesman_id from customerInfo where grade = 200

--7. From the following table, write a SQL query to find the orders, which are delivered by a salesperson of ID. 5001. Return ord_no, ord_date, purch_amt. 
select ord_no,ord_date,purch_amt from salesmanInfo where salesman_id = 5001

create table winnerInfo(
year int,
subject varchar(20),
winner varchar(20),
country varchar(20),
category varchar(20)
)

insert into winnerInfo values(1970,'Physics','Hannes Alfven','Sweden','Sceintist')
insert into winnerInfo values(1970,'Physics','Louis Neel','France','Scientist')
insert into winnerInfo values(1972,'Chemistry','Luis Federico Leloir','France','Scientist')
insert into winnerInfo values(1970,'Physiology','Ulf von Euler','Sweden','Scientist')
insert into winnerInfo values(1973,'Physiology','Bernard Katz','Germany','Scientist')
insert into winnerInfo values(1970,'Literature','Aleksandr Solzhenits','Russia','Literature')
insert into winnerInfo values(1970,'Economics','Paul Samuelson','USA','Economist')

update winnerInfo set subject = 'Peace' where winner = 'Hannes Alfven'
 
select * from winnerInfo

update winnerInfo
set year = 1971 where country = 'Russia'

--9. From the following table, write a SQL query to find the Nobel Prize winner in 'Literature' in the year 1971. Return winner. 
select * from winnerInfo where category = 'Literature'

--10. From the following table, write a SQL query to find the Nobel Prize winner 'Bernard Katz'. Return year, subject. 
select year,subject from winnerInfo where winner = 'Bernard Katz'

--11. From the following table, write a SQL query to find the Nobel Prize winners in 'Physics' since the year 1950. Return winner
select * from winnerInfo where subject = 'Physics' and year >= 1950

--12.  From the following table, write a SQL query to find the Nobel Prize winners in 'Chemistry' between the years 1965 to 1975. Begin and end values are included. Return year, subject, winner, and country 
select year,subject,winner,country from winnerInfo where subject = 'Chemistry' and year  between 1965 and 1975

--13. Write a SQL query to show all details of the Physics winners after 1972 of Louis Neel and Ulf von Euler                                 .
select * from winnerInfo where year > 1972 and winner in ('Louis Neel','Ulf von Euler') and subject = 'Physics'

--14. From the following table, write a SQL query to find the details of the winners whose first name matches with the string 'Louis'. Return year, subject, winner, country, and category.   
select year,subject,winner,country,category from winnerInfo where winner like 'Louis%'

--15. From the following table, write a SQL query to combine the winners in Physics, 1970 and in Economics, 1971. Return year, subject, winner, country, and category
select * from winnerInfo where subject in('Physics','Economics')and year in(1970,1971)

--16. From the following table, write a SQL query to find the Nobel Prize winners in 1970 excluding the subjects Physiology and Economics. Return year, subject, winner, country, and category. 
select * from winnerInfo where year = 1970 and subject not in('Physiology','Economics')

--17. From the following table, write a SQL query to combine the winners in 'Physiology' before 1971 and winners in 'Peace' on or after 1974. Return year, subject, winner, country, and category. 
select * from winnerInfo where (subject = 'Physiology' and year < 1971) or (subject = 'Peace' and year >= 1974)
--combines means OR operator

--18. From the following table, write a SQL query to find the details of the Nobel Prize winner 'Louis Neel'. Return year, subject, winner, country, and category.
select * from winnerInfo where winner = 'Louis Neel'

--19. From the following table, write a SQL query to find the Nobel Prize winners for the subject  started with the letter 'P'. Return year, subject, winner, country, and category. Order the result by year, descending
select * from winnerInfo where subject like 'P%' order by year desc

--20. From the following table, write a SQL query to find the details of 1970 Nobel Prize winners. Order the result by subject,  Return year, subject, winner, country, and category.
select * from winnerInfo where  year = 1970 order by subject