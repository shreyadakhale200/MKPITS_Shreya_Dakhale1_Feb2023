select * from students_mkpits

alter table students_mkpits add Marks int
insert into students_mkpits (Marks) values(99)

UPDATE students_mkpits
SET marks = 4
WHERE first_name = 'Yasmin';

select * from students_mkpits

alter table students_mkpits drop column designations

alter table students_mkpits add Designations varchar(20) not null
DEFAULT 'FAIL'

alter table students_mkpits
drop column designations;

alter table students_mkpits
drop DF__students___Desig__14270015

select * from students_mkpits

UPDATE students_mkpits
SET Designations = 'Failed'
WHERE first_name = 'Jayesh';
select * from students_mkpits


