select * from Exam

--roll no is dependent on student,University is also dependent on student

create table Student_info(
Roll_no int primary key,							--Primary key(Roll_no)
Student_name varchar(20),
University varchar(10)
)

create table Result(
Roll_no int,										--Foreign Key(Roll_no)
Marks int,
Grade char
constraint m foreign key(Roll_no) references Student_info(Roll_no)
)