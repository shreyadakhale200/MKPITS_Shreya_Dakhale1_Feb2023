create table Movie_Details(
Movie_id int primary key,
Movie_Name varchar(40),
Ratings int,
Duration varchar(20),
Release_Year int
)

create table Movie_Cast(
Movie_id int,
Diretor_Name varchar(20),
Actor_Name varchar(20),
Actress_Name varchar(20)
constraint m1 foreign key(Movie_id)
references Movie_details(Movie_id))

insert into Movie_Details values(1,'Aarakshan',8,'2h 46min',2011)

insert into Movie_Cast values(1,'Prakash Jha','Saif Ali Khan','Deepika Padukone')

select * from Bollywood