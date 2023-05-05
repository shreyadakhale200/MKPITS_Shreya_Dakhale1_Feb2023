create database Movies

create table Bollywood(
MovieID int primary key, 
Movie_Name varchar(30),
Director_Name varchar(30),
Actor_Name varchar(40),
Actress_Name varchar(40),
Ratings int,
Duration varchar(20),
Release_Year int
)

insert into Bollywood values(1,'Aarakshan','Prakash Jha','Saif Ali Khan','Deepika Padukone',3,'2h 46min',2011)

insert into Bollywood values(2,'Anari','Hrishikesh Mukherjee','Raj Kapoor','Nutan',8,'2h 46min',1959)
insert into Bollywood values(3,'Aa Gale Lag Jaa','Manmohan Desai','Shashi Kapoor','Sharmila Tagore',4,'2h 28min',1973)
insert into Bollywood values(4,'Aradhana','Shakti Samanta','Rajesh Khanna','Sharmila Tagore',7,'2h 49min',1969)
select * from Bollywood

insert into Bollywood values(5,'Amar Akbar Anthony','Manmohan Desai','Amitabh Bacchan','Parveen Babi',9,'3h 4min',1977)
insert into Bollywood values(6,'Amar Akbar Anthony','Manmohan Desai','Rishi Kapoor','Neetu Kapoor',9,'3h 4min',1977)
insert into Bollywood values(7,'Amar Akbar Anthony','Manmohan Desai','Vinod Khanna','Shabana Aazmi',9,'3h 4min',1977)

select * from Bollywood

insert into Bollywood values(8,'Bhool Bhulaiyaa','Priyadarshan','Akshay Kumar','Vidya Balan',10,'2h 39min',2007)
insert into Bollywood values(9,'Bombay','Mani Ratnam','Arvind Swamy','Manisha Koirala',8,'2h 10min',1995)
insert into Bollywood values(10,'Baghban','Ravi Chopra','Amitabh Bachhan','Hema Malini',7,'3h 1min',2003)
insert into Bollywood values(11,'Aashiqui 2','Mohit Suri','Aditya Kapoor','Shraddha Kapoor',8,'2h 12min',2012) 

select * from Bollywood

UPDATE Bollywood
SET Ratings = REPLACE(Ratings, 3, 8)
WHERE Ratings=3;

insert into Bollywood values(12,'Andaaz Apna Apna','Rajkumar Santoshi','Salman Khan','Raveena Tandon',8,'2h 40min',1994)
insert into Bollywood values(13,'Andaaz Apna Apna','Rajkumar Santoshi','Aamir Khan','Karishma Kapoor',8,'2h 40min',1994)
insert into Bollywood values(14,'PS1 (Poniyan Selvan)','Mani Ratnam','Aishwarya Rai Bacchan','Vikram',9,'2h 50min',2022)
insert into Bollywood values(15,'PS2 (Poniyan Selvan)','Mani Ratnam','Aishwarya Rai Bacchan','Vikram',9,'2h 44min',2023)

select * from Bollywood

insert into Bollywood values(16,'Ramleela','Sanjay Leela Bhansali','Ranveer Singh','Deepika Padukone',7,'2h 35min',2013)
insert into Bollywood values(17,'Bajirao Mastani','Sanjay Leela Bhansali','Ranveer Singh','Deepika Padukone',9,'2h 38min',2015)
insert into Bollywood values(18,'Bajirao Mastani','Sanjay Leela Bhansali','Ranveer Singh','Priyanka Chopra',9,'2h 38min',2015)
insert into Bollywood values(19,'Gangubai Kathiawadi','Sanjay Leela Bhansali','Ranveer Singh','Deepika Padukone',10,'2h 34min',2022)
insert into Bollywood values(20,'Om Shanti Om','Farah Khan','Shahrukh Khan','Deepika Padukone',9,'2h 42min',2007)

select * from Bollywood

insert into Bollywood values(21,'Aitraaz','Mustan Burmawalla, Abbas Burmawalla','Akshay Kumar','Priyanka Chopra'